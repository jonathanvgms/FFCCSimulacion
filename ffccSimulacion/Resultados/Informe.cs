using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

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

        static public void generarInforme(string idSimulacion, string nombre, string fecha, string hora)
        {
            Document doc = inicializarDocumento(nombre);

            doc.Open();

            doc = generarEncabezado(doc, idSimulacion, nombre, fecha, hora);

            doc = generarEscenario(doc);

            doc = generarResultado(doc);

            doc = generarPieDePagina(doc);

            doc.Close();
        }

        static private Document generarEncabezado(Document doc, string idSimulacion, string nombre, string fecha, string hora)
        {
            string path = "C:/Users/Jonathan/Desktop/pdfEjemplo/pdfEjemplo/logo.png";

            Image logo = Image.GetInstance(new Uri(path));

            logo.ScalePercent(30);

            logo.Alignment = Image.TEXTWRAP | Image.ALIGN_LEFT;

            Paragraph encabezado = new Paragraph("Simulador FFCC\nSimulación Nro: XXXXX\t Nombre: AAAAAAA\t Fecha: 01-10-2015\t Hora: 12:25");

            doc.Add(logo);

            doc.Add(encabezado);

            return doc;
        }

        static private Document generarEscenario(Document doc)
        {
            return doc;
        }

        static private Document generarResultado(Document doc)
        {
            return doc;
        }

        static private Document generarPieDePagina(Document doc)
        {
            return doc;
        }
    }
}
