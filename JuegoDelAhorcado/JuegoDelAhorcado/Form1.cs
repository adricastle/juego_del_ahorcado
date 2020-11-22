using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoDelAhorcado
{
    public partial class Form1 : Form
    {
        char[] abecedario;
        char[] palabraAdivinar;
        string[] palabras = new string[] {};
        int oportunidades = 8;

        bool nivelBasico = false;
        bool nivelMedio = false;
        bool nivelAvanzado = false;
        bool segundaPartida = false;


        string path = @"C:\Users\adria\Documents\C#\JuegoDelAhorcado\JuegoDelAhorcado\Resources\archivo.txt";

        public Form1()
        {
            InitializeComponent();
            
            visibilidadJuego(false);
            
        }

        public void iniciarPartida()
        {
            
            cbDificultad.Enabled = false;
            btnIniciar.Visible = false;
            leerDesdeFichero();
            visibilidadJuego(true);
            elegirNivel();
            generarTeclado();
            generarPalabra();
            lblGanado.Visible = false;
            pLogin.Visible = false;
            pPalabra.Visible = false;
        }


        public void visibilidadJuego(bool v)
        {
            flpPalabras.Visible = v;
            btnAdmin.Visible = !v;
            flpTeclado.Visible = v;
            flpErroneas.Visible = v;
            pictureBox1.Visible = v;
            lblIntentos.Visible = v;
            labelN_intentos.Visible = v;
            labelErroneas.Visible = v;
            labelPalabraAdivinar.Visible = v;
            
          
        }
        public void elegirNivel()
        {
            if(cbDificultad.SelectedIndex == 0)
            {
                nivelBasico = true;

            }
            else if(cbDificultad.SelectedIndex == 1)
            {
                nivelMedio = true;
            }
            else if (cbDificultad.SelectedIndex == 2)
            {
                nivelAvanzado = true;
            }
            else
            {
                nivelMedio = true;
                cbDificultad.SelectedItem = 1;
                cbDificultad.Text = "nivel Medio";
                
            }
        }
        public void generarTeclado()
        {
            abecedario = "QWERTYUIOPASDFGHJKLÑ-ZXCVBNM-".ToCharArray();
            

            foreach (char letra in abecedario)
            {
                Button btnLetra = new Button();
                btnLetra.Tag = "";
                btnLetra.Text = letra.ToString();
                btnLetra.Width = 40;
                btnLetra.Height = 40;
                btnLetra.Click += comprobarPalabras;
                btnLetra.BackColor = Color.White;
                btnLetra.ForeColor = Color.Black;
                btnLetra.Font = new Font(btnLetra.Font.Name, 15, FontStyle.Bold);
                btnLetra.Name = letra.ToString();
                flpTeclado.Controls.Add(btnLetra);

                if (btnLetra.Text == "-")
                {
                    btnLetra.Text = "";
                    btnLetra.BackColor = Color.Beige;
                    btnLetra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btnLetra.FlatAppearance.BorderColor = Color.Beige;
                    btnLetra.Enabled = false;
                }

            }

        }

        public void generarPalabra()
        {
            
            Random random = new Random();
            int numeroRandom = random.Next(0, palabras.Length);
            palabraAdivinar = palabras[numeroRandom].ToUpper().ToCharArray();
            for (int i = 0; i < palabraAdivinar.Length; i++)
            {
                Button Letra = new Button();
                Letra.Tag = palabraAdivinar[i].ToString();
                Letra.Text = "-";
                Letra.Width = 35;
                Letra.Height = 70;
                Letra.ForeColor = Color.Black;
                Letra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                Letra.FlatAppearance.BorderColor = Color.Beige;
                Letra.Font = new Font(Letra.Font.Name, 25, FontStyle.Bold);
                Letra.Name = "letra" + i.ToString();
                Letra.Enabled = false;
                flpPalabras.Controls.Add(Letra);

            }
            if (nivelBasico == true)
            {
                //Muestro 2 letras aleatorias en nivel Basico
                //primera letra Random
                Random letraAleatoria = new Random();
                int nMostrada = letraAleatoria.Next(0, palabraAdivinar.Length);
                int nMostrada2 = letraAleatoria.Next(0, palabraAdivinar.Length);
                Button letra1 = this.Controls.Find("letra" + nMostrada, true).FirstOrDefault() as Button;
                letra1.Text = palabraAdivinar[nMostrada].ToString();
                palabraAdivinar[nMostrada] = '-';
                //segunda letra Random
                Button letra2 = this.Controls.Find("letra" + nMostrada2, true).FirstOrDefault() as Button;
                letra2.Text = palabraAdivinar[nMostrada2].ToString();
                palabraAdivinar[nMostrada2] = '-';
               

            }
            else if (nivelMedio == true)
            {
                //Muestro 1 letra aleatoria en nivel Basico
                Random letraAleatoria = new Random();
                int nMostrada = letraAleatoria.Next(0, palabraAdivinar.Length);
                Button letra1 = this.Controls.Find("letra" + nMostrada, true).FirstOrDefault() as Button;
                letra1.Text = palabraAdivinar[nMostrada].ToString();
                palabraAdivinar[nMostrada] = '-';
            }

        }

        public void comprobarPalabras(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Gray;
            btn.Enabled = false;

            bool ganar = true;
            bool encontrada = false;

            //recorro las palabras comparando con el boton pulsado
            for (int i = 0; i < palabraAdivinar.Length; i++)
            {
                if (palabraAdivinar[i] == char.Parse(btn.Text))
                {
                    //actualizo la letra por el Valor si se encuentra
                    Button tbx = this.Controls.Find("letra" + i, true).FirstOrDefault() as Button;
                    tbx.Text = palabraAdivinar[i].ToString();
                    palabraAdivinar[i] = '-';
                    encontrada = true;
                    
                }
                if (palabraAdivinar[i] != '-')
                {
                    ganar = false;
                }
            }
            //si no coincide con ninguna letra:
            if (encontrada == false)
            {
                oportunidades--;
                lblIntentos.Text = (oportunidades-1).ToString();
                pictureBox1.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("ahorcado" + oportunidades);

                //llevo la letra errónea al apartado de letras erróneas:
                Button btnError = new Button();
                btnError.Text = btn.Text;
                btnError.Width = 35;
                btnError.Height = 45;
                btnError.ForeColor = Color.White;
                btnError.BackColor = Color.LightCoral;
                btnError.Font = new Font(btn.Font.Name, 25, FontStyle.Bold);
                btnError.Name = "error" + btn.Name;
                btnError.Enabled = false;
               
                flpErroneas.Controls.Add(btnError);
            }

            if (ganar == true)
            {
                lblGanado.Visible = true;
                flpTeclado.Visible = false;
                cbDificultad.Enabled = true;
                btnIniciar.Visible = true;
                segundaPartida = true;
            }
            if (oportunidades <= 1)
            {
                lblGanado.Text = "YOU LOSE!!!";
                cbDificultad.Enabled = true;
                flpTeclado.Visible = false;
                btnIniciar.Visible = true;
                lblGanado.Visible = true;
                segundaPartida = true;



                for (int i=0; i < palabraAdivinar.Length; i++)
                {
                    Button btnLetra = this.Controls.Find("letra" + i, true).FirstOrDefault() as Button;
                    btnLetra.Text = btnLetra.Tag.ToString();
                }
                
            }

        }

        public void insertarPalabraEnFichero(string palabra)
        {
            //si existe el Fichero
            if (File.Exists(path))
            {
                
                File.AppendAllText(this.path, palabra);
                Console.WriteLine("Palabra insertada");

            }
            //si no se encuentra el fichero
            else
            {
                Console.WriteLine("No se encuentra el fichero de palabras especificado");
            }

        }

        public void leerDesdeFichero()
        {
           
            palabras = System.IO.File.ReadAllLines(this.path);
            Console.WriteLine(palabras.Length);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void cbDificultad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (segundaPartida == true)
            {
                Application.Restart();//para reiniciar el juego cuando se vuelva a pulsar el boton iniciar
                iniciarPartida();
            }
            else
                iniciarPartida();


        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            pLogin.Visible = true;
            btnAdmin.Enabled = false;
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if((txbUsuario.Text == "admin") && (txbPassword.Text == "1234"))
            {
                pPalabra.Visible = true;
                pLogin.Enabled = false;
                lblConfirmacion.ForeColor = Color.Green;
                lblConfirmacion.Text = "Login Correcto";
                lblConfirmacion.Visible = true;

            }
            else
            {
                lblConfirmacion.Visible = true;
                txbUsuario.Text = "";
                txbPassword.Text = "";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //añado el texto del textBox en nueva linea
            string palabraInsertar = "\n" + txbPalabra.Text.ToUpper();
            //la inserto en el fichero
            insertarPalabraEnFichero(palabraInsertar);
            txbPalabra.Text = "";

        }
    }
}
