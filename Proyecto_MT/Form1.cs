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
        bool escribir = false;
        int pasos = 0;

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
                        lblPasos.Text = pasos.ToString();
                        if (txtCadena.Text != "")
                        {
                            lblestado.Text = "q0";
                           
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
                                pasos++;

                            }

                            else if (aux == "+")
                            {
                                CintaMT.Rows[0].Cells[cabezal - 1].Style.BackColor = Color.White;
                                CintaMT.Rows[0].Cells[cabezal].Value = "B";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                contador++;
                                cabezal++;
                                pasos++;


                            }

                            if (datos[0] != "1")
                            {
                                lblAviso.Visible = true;
                                lblAviso.Text = "la cadena no es valida";
                                break;
                            }

                        }
                        else
                        {
                            lblAviso.Visible = true;
                            lblAviso.Text = "la cadena no es valida";
                            break;

                        }
                       
                        break;
                    case (1):
                        lblPasos.Text = pasos.ToString();
                        if (cabezal >= cadena.Length)
                        {
                            lblestado.Text = "q1";
                            lblAviso.Visible = true;
                            lblAviso.Text = "TERMINO";
                            lblPasos.Text = pasos.ToString();
                            break;
                        }
                            lblestado.Text = "q1";
                            aux = datos[cabezal];
                            if (aux == "1")
                            {
                                CintaMT.Rows[0].Cells[cabezal - 1].Style.BackColor = Color.White;
                                CintaMT.Rows[0].Cells[cabezal].Value = "B";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;  
                                cabezal--;
                                contador++;
                                pasos++;
                            }
                            

                   
                        break;
                    case (2):
                        lblPasos.Text = pasos.ToString();
                        if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() == "B")
                        {
                                lblestado.Text = "q2";
                                CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                CintaMT.Rows[0].Cells[cabezal].Value = "1";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                cabezal++;
                                contador++;
                                pasos++;
                         }

                        
                        break;
                    case (3):
                        lblPasos.Text = pasos.ToString();
                        if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() == "B")
                        {
                            lblestado.Text = "q3";
                            CintaMT.Rows[0].Cells[cabezal - 1].Style.BackColor = Color.White;
                            CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                            cabezal++;
                            pasos++;
                            contador = 1;

                        }

                        break;
                }
                
            }
            if (RbtnResta.Checked)
            {

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RbtnPalindromo.Checked)
            {

            
            }
            if (RbtnCopiar.Checked)
            {

            }
            if (RbtnMultiplicacion.Checked)
            {

            }
            if (RbtnSuma.Checked)
            {
                if (txtCadena.Text != "")
                {


                    cadena = txtCadena.Text;
                    datos = new string[cadena.Length];


                    for (int i = 0; i < cadena.Length; i++)
                    {
                        datos[i] = cadena[i].ToString();
                        CintaMT.Columns.Add(i.ToString(), i.ToString());
                        CintaMT[i,0].Value = datos[i];
                    }

                }
                else
                {
                    lblAviso.Visible = true;
                    lblAviso.Text = "la cadena no es valida";

                }
            }
            if (RbtnResta.Checked)
            {

            }

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            CintaMT.Rows.Clear();
            CintaMT.Columns.Clear();
            CintaMT.Refresh();
            contador = 0;
            cadena = "";
            pasos = 0;
            cabezal = 0;
            escribir = false;
            lblPasos.Text = "";
            lblestado.Text = "";
            lblAviso.Text = "";
        }
    }
}
