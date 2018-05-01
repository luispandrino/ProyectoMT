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

        int contador = 0;
        string cadena;
        string[] datos;
        string aux;
        int cabezal = 0;
        int auxCabezal;
        bool bandera = false;
        bool escribir = false;

    public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
        

            if (RbtnPalindromo.Checked)
            {
                
             //q0
                if (contador == 0)
                {
                    cadena = txtCadena.Text + "B";
                    datos = new string[cadena.Length];
                    cabezal = 0;

                    for (int i = 0; i < cadena.Length; i++)
                    {
                        datos[i] = cadena[i].ToString();
                        CintaMT.Columns.Add(i.ToString(), i.ToString());
                        CintaMT[i, 0].Value = datos[i];
                    }
                    aux = datos[cabezal];
                    if (aux == "a")
                    {
                        CintaMT.Rows[0].Cells[cabezal].Value = "B";
                        CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                        

                    }
                } 
                //estado 1 
                if (contador == 1)
                {
                    for (int i = 1 ; i < datos.Length; i++)
                    {
                        auxCabezal = i;
                        if (datos[i] == "B")
                        {
                            CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.White;
                            CintaMT.Rows[0].Cells[auxCabezal].Style.BackColor = Color.Yellow;
                        }
                    }

                }
                contador++;
            }
            if (RbtnCopiar.Checked)
            {

            }
            if (RbtnMultiplicacion.Checked)
            {

            }
            if (RbtnSuma.Checked)
            {
                switch (contador)
                {
                    case (0):
                        cadena = txtCadena.Text;
                        datos = new string[cadena.Length];


                        for (int i = 0; i < cadena.Length; i++)
                        {
                            datos[i] = cadena[i].ToString();
                            CintaMT.Columns.Add(i.ToString(), i.ToString());
                            CintaMT[i, 0].Value = datos[i];
                        }




                        aux = datos[cabezal];
                        if (aux == "1")
                        {
                            CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                            cabezal++;
                            if (escribir)
                            {
                                int a = cabezal - 1;
                                CintaMT.Rows[0].Cells[a - 1].Style.BackColor = Color.White;
                            }
                            escribir = true;

                        }

                        else if (aux == "+")
                        {
                            CintaMT.Rows[0].Cells[cabezal - 1].Style.BackColor = Color.White;
                            CintaMT.Rows[0].Cells[cabezal].Value = "B";
                            CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                            contador++;
                            cabezal++;
                            

                        }
                        break;
                    case (1):
                        if (cabezal >= cadena.Length)
                        {
                            lblAviso.Text = "TERMINIOOOOO!!!!";
                            break;
                        }

                            aux = datos[cabezal];
                            if (aux == "1")
                            {
                                CintaMT.Rows[0].Cells[cabezal - 1].Style.BackColor = Color.White;
                                CintaMT.Rows[0].Cells[cabezal].Value = "B";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;  
                                cabezal--;
                                contador++;
                            }
                            

                   
                        break;
                    case (2):
                        if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() == "B")
                        {

                                CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                CintaMT.Rows[0].Cells[cabezal].Value = "1";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                cabezal++;
                                contador++;
                         }

                        
                        break;
                    case (3):
                        if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() == "B")
                        {
                            CintaMT.Rows[0].Cells[cabezal - 1].Style.BackColor = Color.White;
                            CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                            cabezal++;
                            contador = 1;

                        }

                            break;
                }
                
            }
            if (RbtnResta.Checked)
            {

            }


        }

    }
}
