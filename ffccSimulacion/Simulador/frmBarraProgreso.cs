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
        int contador = 1, desplazamiento = 0;
        public bool estado = false;
        Thread hilo;
        public frmBarraProgreso()
        {
            InitializeComponent();

            timer1.Start();

            desplazamiento = (int) progressBar1.Size.Width / 100;
        }

        public frmBarraProgreso(System.Threading.Thread threadSimulacion)
        {
            InitializeComponent();

            hilo = threadSimulacion;
            
            timer1.Start();

            desplazamiento = 2;
            //desplazamiento = (int)progressBar1.Size.Width / 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(desplazamiento);

            label1.Text = contador.ToString() + " %";

            contador = contador + desplazamiento;
            Console.WriteLine("Contador: " + contador);
            if (progressBar1.Value >= 100)
            {
                timer1.Stop();
                label1.Text = "100 %";
                estado = true;
                Console.WriteLine("Contador: (if)" + contador);
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hilo.Abort();
            estado = false;
            Close();
        }
    }
}
