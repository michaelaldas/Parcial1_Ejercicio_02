using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_Ejercicio_02
{
    public partial class FrmEjercicio02 : Form
    {
        public FrmEjercicio02()
        {
            InitializeComponent();
        }

        private void Btmcalcular_Click(object sender, EventArgs e)
        {
            //valido si el usuario ingreso una frase
            if (this.TxtFrase.Text.Length == 0)
                {
                    MessageBox.Show("Por favor ingrese la frase...");
                    //ubique el cursor en el cuadro de texto
                    this.TxtFrase.Focus();
                }  
            //crea el array de palabras
            string[] palabras = this.TxtFrase.Text.Split(' ');
            this.LstPablabras.Items.Clear();
            //lleno xe listabox con la palabra
            for(int i=0; i<palabras.Length;i++)
            {
                if (palabras[i].Length >0)
                this.LstPablabras.Items.Add(palabras[i] + "-->" + palabras[i].Length + "caracteres...");
            }
        }
    }
}
