using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ffccSimulacion.Simulador
{
    public partial class frmBarraProgreso : Form
    {
        int des;
        public bool estado = false;
        Thread hilo;
        double frecuencia, duracion, cont, desplazamiento;
        public frmBarraProgreso()
        {
            InitializeComponent();
        }

        public frmBarraProgreso(System.Threading.Thread threadSimulacion, double _frecuencia, double _duracion)
        {
            InitializeComponent();

            hilo = threadSimulacion;
            
            timer1.Start();

            frecuencia = _frecuencia;

            duracion = _duracion;

            desplazamiento = frecuencia * 100.0 / duracion;

            timer1.Interval = 500;
            //belgrano 500
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cont = cont + desplazamiento;
            
            des = Convert.ToInt32(Math.Truncate(cont));
            
            label1.Text = des.ToString() + " %";
            
            if (des <= 100)
            {
                progressBar1.Value = des;
                Console.WriteLine("\nBarra Progreso = {0} %", cont);
                //Console.WriteLine(hilo.IsAlive);
                if (!hilo.IsAlive)
                {
                    timer1.Stop();
                    progressBar1.Value = 100;
                    label1.Text = "100 %";
                    Thread.Sleep(1000);
                    estado = true;
                    Close();
                }
            }
            else
            {
                timer1.Stop();
                label1.Text = "100 %";
                estado = true;
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hilo.Abort();
            //Thread.EndThreadAffinity();
            estado = false;
            timer1.Stop();
            Close();
        }
    }
}
