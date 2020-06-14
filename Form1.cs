using HangManGame.CusomItem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangManGame
{
    public partial class HangManGame : Form
    {
        private bool isLoad { get; set; } = true;

        char[] PalabrasAdivinadas; int oportunidades;
        char[] PalabrasSeleccionada;
        char[] Alfabeto;
       
        string[] Animales;
        string[] Frutas;
        string[] AutosBrands;

        int option = 0;

        public HangManGame()
        {
            
            InitializeComponent();
        }

        public void IniciarJuego(int categoria)
        {
            Random random = new Random();
            int IndicePalabrasSeleccionada = 0;
            flFichas.Controls.Clear();
            flFichas.Enabled = true;
            intento.Image = null;
            lbMensaje.Visible = false;
            oportunidades = 0; 
            btnIniciarJuego.Image = Properties.Resources.Jugando;

             Animales = new string[] {  "Perro", "Gato", "Elefante", "Vaca", "Burro", "Zorro", "Oso", "cebra", "Leon", "Mono" };
             Frutas = new string[] {"Uva", "Manzana", "Banana", "Pera", "Lechoza", "Fresa", "Mango", "Sandia", "Chinola", "Melon" };
             AutosBrands = new string[] { "Audi", "Corolla", "Honda", "Kia", "infiniti", "Mazda", "Nissan", "Ford", "Jeep", "Lexus" };

            Alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

           if (categoria == 1)
            {
                IndicePalabrasSeleccionada = random.Next(0, Animales.Length);
                PalabrasSeleccionada = Animales[IndicePalabrasSeleccionada].ToUpper().ToCharArray();
                PalabrasAdivinadas = PalabrasSeleccionada;
            }
           if (categoria == 2)
            {
                IndicePalabrasSeleccionada = random.Next(0, Frutas.Length);
                PalabrasSeleccionada = Frutas[IndicePalabrasSeleccionada].ToUpper().ToCharArray();
                PalabrasAdivinadas = PalabrasSeleccionada;
            }
           if (categoria == 3)
            {
                IndicePalabrasSeleccionada = random.Next(0, AutosBrands.Length);
                PalabrasSeleccionada = AutosBrands[IndicePalabrasSeleccionada].ToUpper().ToCharArray();
                PalabrasAdivinadas = PalabrasSeleccionada;
            }
            
            
           

            foreach (char LetraAlfabeto in Alfabeto)
            {
                Button btnLetra = new Button();
                btnLetra.Tag = "";
                btnLetra.Text = LetraAlfabeto.ToString();
                btnLetra.Width = 60;
                btnLetra.Height = 40;
                btnLetra.Click += Compara;
                btnLetra.ForeColor = Color.Transparent;
                btnLetra.FlatStyle = FlatStyle.Standard;
                btnLetra.Font = new Font(btnLetra.Font.Name, 15, FontStyle.Bold);
                btnLetra.BackgroundImageLayout = ImageLayout.Center;
                btnLetra.BackColor = Color.Black;
                btnLetra.Name = LetraAlfabeto.ToString();
                flFichas.Controls.Add(btnLetra);
            }

            flPalabra.Controls.Clear();
           
            for (int IndiceValorLetra = 0; IndiceValorLetra < PalabrasSeleccionada.Length; IndiceValorLetra++)
            {
                
                Button Letra = new Button();
                Letra.Tag = PalabrasSeleccionada[IndiceValorLetra].ToString();
                Letra.Text = "-";
                Letra.Width = 46;
                Letra.Height = 60;
                Letra.ForeColor = Color.Transparent;
                Letra.FlatStyle = FlatStyle.Standard;
                Letra.Font = new Font(Letra.Font.Name, 15, FontStyle.Bold);
                Letra.BackgroundImageLayout = ImageLayout.Center;
                Letra.BackColor = Color.Black;
                Letra.Name = "Adivinado" + IndiceValorLetra.ToString();
                flPalabra.Controls.Add(Letra);
            }
           
        }
         void Compara(object sender, EventArgs e)
        {
            bool encontrado = false;
            Button btnComparar = (Button)sender;
            btnComparar.BackColor = Color.Transparent;
            btnComparar.ForeColor = Color.Black;
            btnComparar.Enabled = false;

            for (int indiceReview = 0; indiceReview < PalabrasAdivinadas.Length; indiceReview++)
            {
                if (PalabrasAdivinadas[indiceReview] == char.Parse(btnComparar.Text))
                {
                    Button tbx = this.Controls.Find("Adivinado" + indiceReview, true).FirstOrDefault() as Button;
                    tbx.Text = PalabrasAdivinadas[indiceReview].ToString();
                    PalabrasAdivinadas[indiceReview] = '-';
                    encontrado = true;
                }
            }
            
            bool Ganaste = true;

            for (int indiceGanador = 0; indiceGanador < PalabrasAdivinadas.Length; indiceGanador++)
            {
                if (PalabrasAdivinadas[indiceGanador] != '-')
                {
                    Ganaste = false;
                }
            }

            if (Ganaste)
            {
                MessageBox.Show("Ganaste!!"); btnIniciarJuego.Image = Properties.Resources.btnStart;
            }

            if (!encontrado)
            {
                oportunidades = oportunidades + 1;
                intento.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("intento" + oportunidades);

            }

            if (oportunidades == 5)
            {
                lbMensaje.Visible = true;

                for (int IndiceValorLetra = 0; IndiceValorLetra < PalabrasSeleccionada.Length; IndiceValorLetra++)
                {

                    Button btnLetra = this.Controls.Find("Adivinado" + IndiceValorLetra, true).FirstOrDefault() as Button;
                    btnLetra.Text = btnLetra.Tag.ToString();

                }

                flFichas.Enabled = false;
                btnIniciarJuego.Image = Properties.Resources.btnStart;
            }
         }
         
        private void LoadComboBox()
        {
            ComboBoxItem animalesOpcion = new ComboBoxItem
            {
                Text = "Animales",
                Value = 1
            };
            ComboBoxItem frutasOpcion = new ComboBoxItem
            {
                Text = "Frutas",
                Value = 2
            };
            ComboBoxItem autosbrandOpcion = new ComboBoxItem
            {
                Text = "AutoBrand",
                Value = 3
            };
           
            cbxCategorias.Items.Add(animalesOpcion);
            cbxCategorias.Items.Add(frutasOpcion);
            cbxCategorias.Items.Add(autosbrandOpcion);
        }

        private void flPalabra_Paint(object sender, PaintEventArgs e)
        {
        }
        private void HangManGame_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            isLoad = false;
        }

        private void Seleccion() 
        {
            ComboBoxItem seleccionado = cbxCategorias.SelectedItem as ComboBoxItem;

            if (seleccionado.Value == null)
            {
                MessageBox.Show("Debe seleccionar una opcion de juego", "Advertencia");
            }
          
            if (Convert.ToInt32(seleccionado.Value) == 1)
            {
                option = 1;
            }
            if (Convert.ToInt32(seleccionado.Value) == 2)
            {
                option = 2;
            }
             if (Convert.ToInt32(seleccionado.Value) == 3)
             {
                option = 3;
             }
        }

        private void btnIniciarJuego_Click_1(object sender, EventArgs e)
        {
            IniciarJuego(option);
        }

        private void cbxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        { 
            Seleccion();
        }
    }
}