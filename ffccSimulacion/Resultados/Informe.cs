using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ffccSimulacion.Modelo;

namespace ffccSimulacion.Resultados
{
    static class Informe
    {
        static private Document inicializarDocumento(string nombre)
        {
            string archivo;

            archivo = string.Format("informeSimulacion.{0}.pdf", nombre);

            Document doc = new Document();

            PdfWriter.GetInstance(doc, new FileStream(archivo, FileMode.OpenOrCreate));

            return doc;
        }

        public static string dateString = @"d/M/yyyy";

        public static string timeString = @"HH:mm:ss";

        static public void generarInforme(ResultadoSimulacion resultados)
        {
            SaveFileDialog svdGuardarPdf = new SaveFileDialog();
            svdGuardarPdf.InitialDirectory = @"C:";
            svdGuardarPdf.Title = "Guardar Informe Simulación";
            svdGuardarPdf.DefaultExt = "pdf";
            svdGuardarPdf.Filter = "pdf Files (*.pdf)|*.pdf";
            svdGuardarPdf.FilterIndex = 2;
            svdGuardarPdf.RestoreDirectory = true;
            string nombreArchivo = "";
            if (svdGuardarPdf.ShowDialog() == DialogResult.OK)
            {
                nombreArchivo = svdGuardarPdf.FileName;
            }

            if (nombreArchivo.Trim() != "")
            {
                Document doc = new Document(PageSize.A4, 25, 25, 25, 25);
                FileStream file = new FileStream(nombreArchivo, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                PdfWriter.GetInstance(doc, file);
                DateTime dt = DateTime.Now;
                string fecha = dt.ToString(dateString);
                string hora = dt.ToString(timeString);
                doc.Open();
                doc = generarEncabezado(doc, resultados.nombreSimulacion, fecha, hora);
                doc = generarEscenario(doc, resultados.idTraza);
                doc = generarResultado(doc, resultados);
                doc = generarPieDePagina(doc);
                doc.Close();

                //Abre el archivo una vez creado no se si es necesario, pero es un buen feature
                Process.Start(nombreArchivo); 
            }
        }

        private static Document generarEscenario(Document doc, int idTraza)
        {
            string escenarioStr;
            char[] charToTrim = { ' ', ',', ')' , '.' };

            ffccSimulacionEntities context = new ffccSimulacionEntities ();

            Paragraph divisor = new Paragraph("___________________________________________________________________________");
            doc.Add(divisor);
            escenarioStr = context.Trazas.Where(x => x.Id == idTraza).FirstOrDefault().Nombre;
            doc.Add(new Paragraph("Escenario de Simulación\n", FontFactory.GetFont("ARIAL", 13, iTextSharp.text.Font.BOLD)));
            doc.Add(new Paragraph("Traza", FontFactory.GetFont("ARIAL", 10, iTextSharp.text.Font.BOLD)));
            doc.Add(new Paragraph(escenarioStr, FontFactory.GetFont("ARIAL", 10, iTextSharp.text.Font.ITALIC)));
            doc.Add(new Paragraph("Servicios", FontFactory.GetFont("ARIAL", 10, iTextSharp.text.Font.BOLD)));
            Servicios unServicio;
            Formaciones unaFormacion;
            Estaciones unaEstacion;
            escenarioStr = "";
            foreach (var ts in context.Trazas_X_Servicios.Where(x => x.Id_Traza == idTraza))
            {
                unServicio = context.Servicios.Where(y => y.Id == ts.Id_Servicio).FirstOrDefault();
                doc.Add(new Paragraph(unServicio.Nombre, FontFactory.GetFont("ARIAL", 10, iTextSharp.text.Font.ITALIC)));
                doc.Add(new Paragraph("Formaciones ", FontFactory.GetFont("ARIAL", 10, iTextSharp.text.Font.BOLD)));
                foreach (var sf in context.Servicios_X_Formaciones.Where(x => x.Id_Servicio == unServicio.Id))
                {
                    unaFormacion = context.Formaciones.Where(y => y.Id == sf.Id_Formacion).FirstOrDefault();
                    doc.Add(new Paragraph(unaFormacion.NombreFormacion, FontFactory.GetFont("ARIAL", 10, iTextSharp.text.Font.ITALIC)));
                    doc.Add(new Paragraph("Coches", FontFactory.GetFont("ARIAL", 10, iTextSharp.text.Font.BOLD)));
                    foreach (var fc in context.Formaciones_X_Coches.Where(x => x.Id_Formacion == unaFormacion.Id))
                    {
                        escenarioStr += context.Coches.Where(y => y.Id == fc.Id_Coche).FirstOrDefault().Modelo + ", ";
                    }
                    escenarioStr = escenarioStr.TrimEnd(charToTrim);
                }
            }
            escenarioStr = escenarioStr.TrimEnd(charToTrim);
            escenarioStr += ".";
            doc.Add(new Paragraph(escenarioStr, FontFactory.GetFont("ARIAL", 10, iTextSharp.text.Font.ITALIC)));
            escenarioStr = "";
            foreach (var ts in context.Trazas_X_Servicios.Where(x => x.Id_Traza == idTraza))
            {
                unServicio = context.Servicios.Where(y => y.Id == ts.Id_Servicio).FirstOrDefault();
                doc.Add(new Paragraph("Estaciones", FontFactory.GetFont("ARIAL", 10, iTextSharp.text.Font.BOLD)));
                foreach (var r in context.Relaciones.Where(y => y.Id_Servicio == ts.Id_Servicio))
                {
                    unaEstacion = context.Estaciones.Where(y => y.Id == r.Id_Estacion_Anterior).FirstOrDefault();
                    escenarioStr += unaEstacion.Nombre;
                    if (context.Estaciones_X_Incidentes.Any(x => x.Id_Estacion == unaEstacion.Id))
                    {
                        escenarioStr += " (";
                        foreach (var ei in context.Estaciones_X_Incidentes.Where(x => x.Id_Estacion == unaEstacion.Id))
                        {
                            escenarioStr += context.Incidentes.Where(y => y.Id == ei.Id_Incidente).FirstOrDefault().Nombre + ", ";
                        }
                        escenarioStr = escenarioStr.TrimEnd(charToTrim);
                        escenarioStr += ") ";
                    }
                    escenarioStr += ", ";
                }
            }
            escenarioStr = escenarioStr.TrimEnd(charToTrim);
            escenarioStr += ".";
            doc.Add(new Paragraph(escenarioStr, FontFactory.GetFont("ARIAL", 10, iTextSharp.text.Font.ITALIC)));
            return doc;
        }

        private static Document generarEncabezado(Document doc, string nombreSimulacion, string fecha, string hora)
        {
            /*
             * TODO busar la imagen dinamicamente el origen del proyecto
             */ 
            string path = "C:/Users/Jonathan/Desktop/pdfEjemplo/pdfEjemplo/logo.png";
            Image logo = Image.GetInstance(new Uri(path));
            logo.ScalePercent(30);
            logo.Alignment = Image.TEXTWRAP | Image.ALIGN_LEFT;
            string encabezadoStr = string.Format("Simulador FFCC\nNombre de Simulación: {0}         Fecha: {1}      Hora: {2}", nombreSimulacion, fecha, hora);
            Paragraph encabezado = new Paragraph(encabezadoStr, FontFactory.GetFont("ARIAL", 10, iTextSharp.text.Font.BOLDITALIC));
            doc.Add(logo);
            doc.Add(encabezado);
            return doc;
        }

        private static Document generarResultado(Document doc, ResultadoSimulacion resultados)
        {
            Paragraph divisor = new Paragraph("_________________________________________________________________________________");
            doc.Add(divisor);
            doc.Add(new Paragraph("Resultados", FontFactory.GetFont("ARIAL", 13, iTextSharp.text.Font.BOLD)));
            doc.Add(new Paragraph("Porcentaje de Trenes que Superaron el Máximo de Pasajeros Permitidos:  " + resultados.porcentajeSobrecarga + " %", FontFactory.GetFont("ARIAL", 10, iTextSharp.text.Font.ITALIC)));
            doc.Add(new Paragraph("Tiempo Promedio de Demora Por Incidentes:  " + resultados.promedioDemoraIncidentes + " Minutos", FontFactory.GetFont("ARIAL", 10, iTextSharp.text.Font.ITALIC)));
            doc.Add(new Paragraph("Promedio de Pasajeros Por Formación:  " + resultados.promedioPasajeros + " Pasajeros", FontFactory.GetFont("ARIAL", 10, iTextSharp.text.Font.ITALIC)));
            doc.Add(new Paragraph("Promedio de Demora Por Atención en Estación:  " + resultados.promedioDemoraAtencion + " Minutos", FontFactory.GetFont("ARIAL", 10, iTextSharp.text.Font.ITALIC)));
            doc.Add(new Paragraph("Costo de Formación Por Kilómetro:  " + resultados.costoKm + " $", FontFactory.GetFont("ARIAL", 10, iTextSharp.text.Font.ITALIC)));
            doc.Add(new Paragraph("Costo de Formación Por Pasajero:  " + resultados.costoPasajero + " $", FontFactory.GetFont("ARIAL", 10, iTextSharp.text.Font.ITALIC)));
            return doc;
        }

        static private Document generarPieDePagina(Document doc)
        {
            Paragraph divisor = new Paragraph("_________________________________________________________________________________");
            doc.Add(divisor);
            doc.Add(new Paragraph("SIMULADOR FFCC 2015- UTN FRBA. Todos los derechos Reservados.", FontFactory.GetFont("ARIAL", 8, iTextSharp.text.Font.NORMAL)));
            return doc;
        }
    }
}
