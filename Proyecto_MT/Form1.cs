using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_MT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string cadena = txtCadena.Text+"="+"B";
            string[] datos = new string[cadena.Length];
            
            for (int i = 0; i < cadena.Length; i++)
            {
                datos[i] = cadena[i].ToString();
                CintaMT.Columns.Add(i.ToString(), i.ToString());
                CintaMT[i, 0].Value = datos[i];
               
          

            }
            


        }
    }
}
