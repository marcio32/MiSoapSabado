using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.MiSoap;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private static MiSoap.Service1Client Service1Client;
        public Form1()
        {
            Service1Client = new MiSoap.Service1Client();
            InitializeComponent();
        }

        private void suma_Click(object sender, EventArgs e)
        {
            var num1 = int.Parse(primerNumero.Text);
            var num2 = int.Parse(segundoNumero.Text);
            var resultado = Service1Client.GetCalculadora(num1, num2, 1);
            Tresultado.Text = resultado;
        }

        private void resta_Click(object sender, EventArgs e)
        {
            var num1 = int.Parse(primerNumero.Text);
            var num2 = int.Parse(segundoNumero.Text);
            var resultado = Service1Client.GetCalculadora(num1, num2, 2);
            Tresultado.Text = resultado;
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            var num1 = int.Parse(primerNumero.Text);
            var num2 = int.Parse(segundoNumero.Text);
            var resultado = Service1Client.GetCalculadora(num1, num2, 3);
            Tresultado.Text = resultado;
        }

        private void division_Click(object sender, EventArgs e)
        {
            var num1 = int.Parse(primerNumero.Text);
            var num2 = int.Parse(segundoNumero.Text);
            var resultado = Service1Client.GetCalculadora(num1, num2, 4);
            Tresultado.Text = resultado;
        }
    }
}
