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
        bool escribir = false;
        int pasos = 0;

    public Form1()
        {
            InitializeComponent();
        }
       
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {

                if (RbtnPalindromo.Checked)
                {
                    switch (contador)
                    {

                        case (0):
                            if (datos[0] != "a" && datos[0] != "b" && datos[0] != "c")
                            {
                                lblAviso.Visible = true;
                                lblAviso.Text = "la cadena no es valida";
                                break;
                            }
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q0";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            if (aux == "a")
                            {

                                CintaMT.Rows[0].Cells[cabezal].Value = "B";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                contador++;
                                cabezal++;
                                if (escribir)
                                {
                                    int a = cabezal - 1;

                                    CintaMT.Rows[0].Cells[a - 1].Style.BackColor = Color.White;
                                }
                            }
                            if (aux == "b")
                            {

                                CintaMT.Rows[0].Cells[cabezal].Value = "B";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                contador = 4;
                                cabezal++;
                                if (escribir)
                                {
                                    int a = cabezal - 1;

                                    CintaMT.Rows[0].Cells[a - 1].Style.BackColor = Color.White;
                                }
                            }
                            if (aux == "c")
                            {

                                CintaMT.Rows[0].Cells[cabezal].Value = "B";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                contador = 7;
                                cabezal++;
                                if (escribir)
                                {
                                    int a = cabezal - 1;

                                    CintaMT.Rows[0].Cells[a - 1].Style.BackColor = Color.White;
                                }
                            }
                            if (aux == "B")
                            {
                                CintaMT.Rows[0].Cells[cabezal - 1].Style.BackColor = Color.White;
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;

                            }

                            break;
                        case (1):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q1";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            if (aux == "a" | aux == "b" | aux == "c")
                            {
                                CintaMT.Rows[0].Cells[0].Style.BackColor = Color.White;
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

                            else if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() == "B")
                            {
                                bool Salida = true;
                                for (int i = 0; i < cadena.Length; i++)
                                {
                                    if (CintaMT.Rows[0].Cells[i].Value.ToString() != "B")
                                    {
                                        Salida = false;
                                    }

                                }
                                CintaMT.Rows[0].Cells[cabezal - 1].Style.BackColor = Color.White;
                                CintaMT.Rows[0].Cells[cabezal].Value = "B";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                cabezal--;
                                pasos++;
                                contador++;

                                if (Salida)
                                {
                                    lblAviso.Visible = true;
                                    lblAviso.Text = "TERMINO LA CADENA ES PALINDROMO";
                                    break;
                                }
                            }

                            break;
                        case (2):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q2";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            if (aux == "a")
                            {
                                CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                CintaMT.Rows[0].Cells[cabezal].Value = "B";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                contador++;
                                cabezal--;
                                pasos++;
                                if (CintaMT.Rows[0].Cells[datos.Length / 2].Value.ToString() == "B" && CintaMT.Rows[0].Cells[(datos.Length / 2) + 1].Value.ToString() == "B" && CintaMT.Rows[0].Cells[(datos.Length / 2) - 1].Value.ToString() == "B")
                                {
                                    lblAviso.Visible = true;
                                    lblAviso.Text = "TERMINO LA CADENA ES PALINDROMO";
                                    break;
                                }
                            }
                            break;
                        case (3):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q3";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            switch (aux)
                            {
                                case ("a"):

                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() != "B")
                                    {
                                        cabezal--;
                                        pasos++;
                                    }
                                    break;
                                case ("b"):
                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() != "B")
                                    {
                                        cabezal--;
                                        pasos++;
                                    }
                                    break;
                                case ("c"):
                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() != "B")
                                    {
                                        cabezal--;
                                        pasos++;
                                    }
                                    break;
                                case ("B"):
                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Value = "B";
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    cabezal++;
                                    pasos++;
                                    contador = 0;

                                    break;
                            }
                            break;
                        case (4):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q4";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            if (aux == "a" | aux == "b" | aux == "c")
                            {
                                CintaMT.Rows[0].Cells[0].Style.BackColor = Color.White;
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

                            else if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() == "B")
                            {
                                bool Salida = true;
                                for (int i = 0; i < cadena.Length; i++)
                                {
                                    if (CintaMT.Rows[0].Cells[i].Value.ToString() != "B")
                                    {
                                        Salida = false;
                                    }

                                }
                                CintaMT.Rows[0].Cells[cabezal - 1].Style.BackColor = Color.White;
                                CintaMT.Rows[0].Cells[cabezal].Value = "B";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                cabezal--;
                                pasos++;
                                contador++;

                                if (Salida)
                                {
                                    lblAviso.Visible = true;
                                    lblAviso.Text = "TERMINO LA CADENA ES PALINDROMO";
                                    break;
                                }
                            }

                            break;
                        case (5):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q5";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            if (aux == "b")
                            {
                                CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                CintaMT.Rows[0].Cells[cabezal].Value = "B";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                contador++;
                                cabezal--;
                                pasos++;
                                if (CintaMT.Rows[0].Cells[datos.Length / 2].Value.ToString() == "B" && CintaMT.Rows[0].Cells[(datos.Length / 2) + 1].Value.ToString() == "B" && CintaMT.Rows[0].Cells[(datos.Length / 2) - 1].Value.ToString() == "B")
                                {
                                    lblAviso.Visible = true;
                                    lblAviso.Text = "TERMINO LA CADENA ES PALINDROMO";
                                    break;
                                }
                            }
                            break;
                        case (6):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q6";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            switch (aux)
                            {
                                case ("a"):

                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() != "B")
                                    {
                                        cabezal--;
                                        pasos++;
                                    }
                                    break;
                                case ("b"):
                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() != "B")
                                    {
                                        cabezal--;
                                        pasos++;
                                    }
                                    break;
                                case ("c"):
                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() != "B")
                                    {
                                        cabezal--;
                                        pasos++;
                                    }
                                    break;
                                case ("B"):
                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Value = "B";
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    cabezal++;
                                    pasos++;
                                    contador = 0;

                                    break;
                            }
                            break;
                        case (7):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q7";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            if (aux == "a" | aux == "b" | aux == "c")
                            {
                                CintaMT.Rows[0].Cells[0].Style.BackColor = Color.White;
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

                            else if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() == "B")
                            {
                                bool Salida = true;
                                for (int i = 0; i < cadena.Length; i++)
                                {
                                    if (CintaMT.Rows[0].Cells[i].Value.ToString() != "B")
                                    {
                                        Salida = false;
                                    }

                                }
                                CintaMT.Rows[0].Cells[cabezal - 1].Style.BackColor = Color.White;
                                CintaMT.Rows[0].Cells[cabezal].Value = "B";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                cabezal--;
                                pasos++;
                                contador++;

                                if (Salida)
                                {
                                    lblAviso.Visible = true;
                                    lblAviso.Text = "TERMINO LA CADENA ES PALINDROMO";
                                    break;
                                }
                            }

                            break;
                        case (8):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q8";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            if (aux == "c")
                            {
                                CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                CintaMT.Rows[0].Cells[cabezal].Value = "B";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                contador++;
                                cabezal--;
                                pasos++;
                                if (CintaMT.Rows[0].Cells[datos.Length / 2].Value.ToString() == "B" && CintaMT.Rows[0].Cells[(datos.Length / 2) + 1].Value.ToString() == "B" && CintaMT.Rows[0].Cells[(datos.Length / 2) - 1].Value.ToString() == "B")
                                {
                                    lblAviso.Visible = true;
                                    lblAviso.Text = "TERMINO LA CADENA ES PALINDROMO";
                                    break;
                                }
                            }
                            break;
                        case (9):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q9";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            switch (aux)
                            {
                                case ("a"):

                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() != "B")
                                    {
                                        cabezal--;
                                        pasos++;
                                    }
                                    break;
                                case ("b"):
                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() != "B")
                                    {
                                        cabezal--;
                                        pasos++;
                                    }
                                    break;
                                case ("c"):
                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() != "B")
                                    {
                                        cabezal--;
                                        pasos++;
                                    }
                                    break;
                                case ("B"):
                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Value = "B";
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    cabezal++;
                                    pasos++;
                                    contador = 0;

                                    break;
                            }
                            break;
                    }


                }
                if (RbtnCopiar.Checked)
                {
                    switch (contador)
                    {
                        case (0):
                            if (datos[0] != "a" && datos[0] != "b" && datos[0] != "c")
                            {
                                lblAviso.Visible = true;
                                lblAviso.Text = "la cadena no es valida";
                                break;
                            }
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q0";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            if (aux == "a")
                            {

                                CintaMT.Rows[0].Cells[cabezal].Value = "B";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                contador = 1;
                                cabezal++;
                                if (escribir)
                                {
                                    int a = cabezal - 1;

                                    CintaMT.Rows[0].Cells[a - 1].Style.BackColor = Color.White;
                                }

                            }
                            if (aux == "b")
                            {

                                CintaMT.Rows[0].Cells[cabezal].Value = "B";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                contador = 3;
                                cabezal++;
                                if (escribir)
                                {
                                    int a = cabezal - 1;

                                    CintaMT.Rows[0].Cells[a - 1].Style.BackColor = Color.White;
                                }
                            }
                            if (aux == "c")
                            {

                                CintaMT.Rows[0].Cells[cabezal].Value = "B";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                contador = 5;
                                cabezal++;
                                if (escribir)
                                {
                                    int a = cabezal - 1;

                                    CintaMT.Rows[0].Cells[a - 1].Style.BackColor = Color.White;
                                }
                            }
                            if (aux == "=")
                            {

                                CintaMT.Rows[0].Cells[cabezal].Value = "B";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                contador = 7;
                                cabezal++;
                                if (escribir)
                                {
                                    int a = cabezal - 1;

                                    CintaMT.Rows[0].Cells[a - 1].Style.BackColor = Color.White;
                                }
                            }

                            if (aux == "B")
                            {
                                CintaMT.Rows[0].Cells[cabezal - 1].Style.BackColor = Color.White;
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;

                            }
                            break;
                        case (1):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q1";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            if (aux == "a" | aux == "b" | aux == "c" | aux == "=")
                            {
                                CintaMT.Rows[0].Cells[0].Style.BackColor = Color.White;
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

                            else if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() == "B")
                            {
                                CintaMT.Rows[0].Cells[cabezal - 1].Style.BackColor = Color.White;
                                CintaMT.Rows[0].Cells[cabezal].Value = "a";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                cabezal--;
                                pasos++;
                                contador++;
                            }

                            break;
                        case (2):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q2";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            switch (aux)
                            {
                                case ("a"):

                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() != "B")
                                    {
                                        cabezal--;
                                        pasos++;
                                    }
                                    break;
                                case ("b"):
                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() != "B")
                                    {
                                        cabezal--;
                                        pasos++;
                                    }
                                    break;
                                case ("c"):
                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() != "B")
                                    {
                                        cabezal--;
                                        pasos++;
                                    }
                                    break;
                                case ("="):
                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() != "B")
                                    {
                                        cabezal--;
                                        pasos++;
                                    }
                                    break;
                                case ("B"):
                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Value = "a";
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    cabezal++;
                                    pasos++;
                                    contador = 0;

                                    break;
                            }
                            break;
                        case (3):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q3";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            if (aux == "a" | aux == "b" | aux == "c" | aux == "=")
                            {
                                CintaMT.Rows[0].Cells[0].Style.BackColor = Color.White;
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

                            else if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() == "B")
                            {
                                CintaMT.Rows[0].Cells[cabezal - 1].Style.BackColor = Color.White;
                                CintaMT.Rows[0].Cells[cabezal].Value = "b";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                cabezal--;
                                pasos++;
                                contador++;
                            }

                            break;
                        case (4):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q4";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            switch (aux)
                            {
                                case ("a"):

                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() != "B")
                                    {
                                        cabezal--;
                                        pasos++;
                                    }
                                    break;
                                case ("b"):
                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() != "B")
                                    {
                                        cabezal--;
                                        pasos++;
                                    }
                                    break;
                                case ("c"):
                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() != "B")
                                    {
                                        cabezal--;
                                        pasos++;
                                    }
                                    break;
                                case ("="):
                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() != "B")
                                    {
                                        cabezal--;
                                        pasos++;
                                    }
                                    break;
                                case ("B"):
                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Value = "b";
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    cabezal++;
                                    pasos++;
                                    contador = 0;

                                    break;
                            }
                            break;
                        case (5):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q5";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            if (aux == "a" | aux == "b" | aux == "c" | aux == "=")
                            {
                                CintaMT.Rows[0].Cells[0].Style.BackColor = Color.White;
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

                            else if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() == "B")
                            {
                                CintaMT.Rows[0].Cells[cabezal - 1].Style.BackColor = Color.White;
                                CintaMT.Rows[0].Cells[cabezal].Value = "c";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                cabezal--;
                                pasos++;
                                contador++;
                            }

                            break;
                        case (6):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q6";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            switch (aux)
                            {
                                case ("a"):

                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() != "B")
                                    {
                                        cabezal--;
                                        pasos++;
                                    }
                                    break;
                                case ("b"):
                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() != "B")
                                    {
                                        cabezal--;
                                        pasos++;
                                    }
                                    break;
                                case ("c"):
                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() != "B")
                                    {
                                        cabezal--;
                                        pasos++;
                                    }
                                    break;
                                case ("="):
                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    if (CintaMT.Rows[0].Cells[cabezal].Value.ToString() != "B")
                                    {
                                        cabezal--;
                                        pasos++;
                                    }
                                    break;
                                case ("B"):
                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Value = "c";
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    cabezal++;
                                    pasos++;
                                    contador = 0;

                                    break;
                            }
                            break;
                        case (7):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q7";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            if (aux == "a")
                            {
                                CintaMT.Rows[0].Cells[cabezal - 1].Style.BackColor = Color.White;
                                CintaMT.Rows[0].Cells[cabezal].Value = "B";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                contador = 8;
                                cabezal--;
                            }
                            if (aux == "b")
                            {

                                CintaMT.Rows[0].Cells[cabezal - 1].Style.BackColor = Color.White;
                                CintaMT.Rows[0].Cells[cabezal].Value = "B";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                contador = 10;
                                cabezal--;

                            }
                            if (aux == "c")
                            {

                                CintaMT.Rows[0].Cells[cabezal - 1].Style.BackColor = Color.White;
                                CintaMT.Rows[0].Cells[cabezal].Value = "B";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                contador = 12;
                                cabezal--;

                            }
                            if (aux == "B")
                            {
                                lblAviso.Visible = true;
                                lblAviso.Text = "TERMINO";
                            }
                            break;
                        case (8):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q8";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            if (aux == "B")
                            {
                                CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                CintaMT.Rows[0].Cells[cabezal].Value = "a";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                contador++;
                                cabezal++;
                            }

                            break;
                        case (9):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q9";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            if (aux == "B")
                            {
                                CintaMT.Rows[0].Cells[cabezal - 1].Style.BackColor = Color.White;
                                CintaMT.Rows[0].Cells[cabezal].Value = "B";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                contador = 7;
                                cabezal++;
                            }
                            break;
                        case (10):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q10";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            if (aux == "B")
                            {
                                CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                CintaMT.Rows[0].Cells[cabezal].Value = "b";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                contador++;
                                cabezal++;
                            }

                            break;
                        case (11):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q11";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            if (aux == "B")
                            {
                                CintaMT.Rows[0].Cells[cabezal - 1].Style.BackColor = Color.White;
                                CintaMT.Rows[0].Cells[cabezal].Value = "B";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                contador = 7;
                                cabezal++;
                            }
                            break;
                        case (12):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q12";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            if (aux == "B")
                            {
                                CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                CintaMT.Rows[0].Cells[cabezal].Value = "c";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                contador++;
                                cabezal++;
                            }

                            break;
                        case (13):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q13";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            if (aux == "B")
                            {
                                CintaMT.Rows[0].Cells[cabezal - 1].Style.BackColor = Color.White;
                                CintaMT.Rows[0].Cells[cabezal].Value = "B";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                contador = 7;
                                cabezal++;
                            }
                            break;
                    }

                }
                if (RbtnMultiplicacion.Checked)
                {
                    switch (contador)
                    {
                        case (0):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q0";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            if (aux == "1")
                            {

                                CintaMT.Rows[0].Cells[cabezal].Value = "B";
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                contador++;
                                cabezal++;
                                if (escribir)
                                {
                                    int a = cabezal - 1;

                                    CintaMT.Rows[0].Cells[a - 1].Style.BackColor = Color.White;
                                }
                                escribir = true;
                            }
                            if (aux == "x")
                            {
                                if (datos[0] == "x")
                                {
                                    lblAviso.Visible = true;
                                    lblAviso.Text = "la cadena no es valida";
                                    break;
                                }
                                CintaMT.Rows[0].Cells[cabezal - 1].Style.BackColor = Color.White;
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                cabezal++;
                                pasos++;
                                contador = 8;

                            }
                            if (datos[0] != "1")
                            {
                                lblAviso.Visible = true;
                                lblAviso.Text = "la cadena no es valida";
                                break;
                            }
                            break;
                        case (1):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q1";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            switch (aux)
                            {
                                case ("1"):

                                    CintaMT.Rows[0].Cells[cabezal - 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    cabezal++;
                                    pasos++;

                                    break;
                                case ("x"):
                                    CintaMT.Rows[0].Cells[cabezal - 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    cabezal++;
                                    pasos++;
                                    contador++;
                                    break;
                            }
                            break;
                        case (2):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q2";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            switch (aux)
                            {
                                case ("1"):

                                    CintaMT.Rows[0].Cells[cabezal - 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Value = "B";
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    contador++;
                                    cabezal++;

                                    break;
                                case ("="):
                                    CintaMT.Rows[0].Cells[cabezal - 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    cabezal--;
                                    pasos++;
                                    contador = 6;
                                    break;
                            }
                            break;
                        case (3):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q3";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            switch (aux)
                            {
                                case ("1"):

                                    CintaMT.Rows[0].Cells[cabezal - 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    cabezal++;
                                    pasos++;

                                    break;
                                case ("="):
                                    CintaMT.Rows[0].Cells[cabezal - 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    cabezal++;
                                    pasos++;
                                    contador++;
                                    break;
                            }
                            break;
                        case (4):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q4";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            switch (aux)
                            {
                                case ("1"):

                                    CintaMT.Rows[0].Cells[cabezal - 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    cabezal++;
                                    pasos++;

                                    break;
                                case ("B"):
                                    CintaMT.Rows[0].Cells[cabezal - 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Value = "1";
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    cabezal--;
                                    pasos++;
                                    contador++;
                                    break;
                            }
                            break;
                        case (5):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q5";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            switch (aux)
                            {
                                case ("1"):

                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    cabezal--;
                                    pasos++;

                                    break;
                                case ("="):

                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    cabezal--;
                                    pasos++;

                                    break;
                                case ("B"):
                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Value = "1";
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    cabezal++;
                                    pasos++;
                                    contador = 2;
                                    break;
                            }
                            break;
                        case (6):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q6";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            if (aux == "1")
                            {

                                CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                contador++;
                                cabezal--;
                            }
                            break;
                        case (7):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q7";
                            aux = CintaMT.Rows[0].Cells[cabezal].Value.ToString();
                            switch (aux)
                            {
                                case ("1"):

                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    cabezal--;
                                    pasos++;

                                    break;
                                case ("x"):

                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    cabezal--;
                                    pasos++;

                                    break;
                                case ("B"):
                                    CintaMT.Rows[0].Cells[cabezal + 1].Style.BackColor = Color.White;
                                    CintaMT.Rows[0].Cells[cabezal].Value = "1";
                                    CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                                    cabezal++;
                                    pasos++;
                                    contador = 0;
                                    break;
                            }
                            break;
                        case (8):
                            lblPasos.Text = pasos.ToString();
                            lblestado.Text = "q8";
                            CintaMT.Rows[0].Cells[cabezal - 1].Style.BackColor = Color.White;
                            CintaMT.Rows[0].Cells[cabezal].Style.BackColor = Color.Yellow;
                            pasos++;
                            lblAviso.Visible = true;
                            lblAviso.Text = "TERMINO";
                            break;

                    }

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
                                    if (datos[0] == "+")
                                    {
                                        lblAviso.Visible = true;
                                        lblAviso.Text = "la cadena no es valida";
                                        break;
                                    }
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
            catch (Exception)
            {
                lblAviso.Visible = true;
                lblAviso.Text = "Error en la cadena";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (RbtnPalindromo.Checked)
            {
                if (txtCadena.Text != "")
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


                }
                else
                {
                    lblAviso.Visible = true;
                    lblAviso.Text = "la cadena no es valida";

                }
       

            }
            if (RbtnCopiar.Checked)
            {

                if (txtCadena.Text != "")
                {
                    cadena = txtCadena.Text +"=";
                    for (int i = 0; i < txtCadena.TextLength*2; i++)
                    {
                        cadena = cadena + "B";
                    }
                    datos = new string[cadena.Length*2];
                    cabezal = 0;

                    for (int i = 0; i < cadena.Length; i++)
                    {
                        datos[i] = cadena[i].ToString();
                        CintaMT.Columns.Add(i.ToString(), i.ToString());
                        CintaMT[i, 0].Value = datos[i];
                    }


                }
                else
                {
                    lblAviso.Visible = true;
                    lblAviso.Text = "la cadena no es valida";

                }

            }
            if (RbtnMultiplicacion.Checked)
            {
                if (txtCadena.Text != "")
                {
                    cadena = txtCadena.Text + "=";
                    for (int i = 0; i < txtCadena.TextLength * 20; i++)
                    {
                        cadena = cadena + "B";
                    }
                    datos = new string[cadena.Length * 20];
                    cabezal = 0;

                    for (int i = 0; i < cadena.Length; i++)
                    {
                        datos[i] = cadena[i].ToString();
                        CintaMT.Columns.Add(i.ToString(), i.ToString());
                        CintaMT[i, 0].Value = datos[i];
                    }


                }
                else
                {
                    lblAviso.Visible = true;
                    lblAviso.Text = "la cadena no es valida";

                }

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
            txtCadena.Text = "";
        }
    }
}
