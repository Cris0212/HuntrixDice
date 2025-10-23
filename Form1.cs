using System;
using System.Collections.Generic;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonDice
{
    public partial class Form1 : Form
    {
        
        private readonly List<int> Secuencia = new List<int>();
        private int indiceEntrada = 0;         
        private bool Hablando = false;         
        private bool EnJuego = false;           

        private Random rng;
        private SoundPlayer _player;
        private bool MusicaActiva = false;

        public Form1()
        {
            InitializeComponent();
            rng = new Random();

            
            this.Load += Form1_Load;
            btn_iniciar.Click += btn_iniciar_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            _player = new SoundPlayer(Properties.Resources.Golden);
            _player.Load();

            
            Zoey.Click += (s, ev) => ManejarClickJugador(0);
            Leon.Click += (s, ev) => ManejarClickJugador(1);
            Rumi.Click += (s, ev) => ManejarClickJugador(2);
            Mira.Click += (s, ev) => ManejarClickJugador(3);

            lbl_puntaje.Text = "0";
        }

        // ===== Música de fondo en loop =====
        private void ReproducirMusicaFondo()
        {
            try
            {
                if (!MusicaActiva)
                {
                    _player.PlayLooping();
                    MusicaActiva = true;
                }
            }
            catch { }
        }

        private void DetenerMusicaFondo()
        {
            try
            {
                if (MusicaActiva)
                {
                    _player.Stop();
                    MusicaActiva = false;
                }
            }
            catch { }
        }

      
        private async void btn_iniciar_Click(object sender, EventArgs e)
        {
            if (EnJuego) return;   

            
            Secuencia.Clear();
            indiceEntrada = 0;
            lbl_puntaje.Text = "0";
            EnJuego = true;
            btn_iniciar.Enabled = false;

            // Arranca música de fondo
            ReproducirMusicaFondo();

         
            AgregarPaso();
            await MostrarSecuenciaAsync();
        }

        private void AgregarPaso()
        {
            Secuencia.Add(rng.Next(0, 4)); 
            lbl_puntaje.Text = Secuencia.Count.ToString();
        }

  
        private async Task MostrarSecuenciaAsync()
        {
            Hablando = true;

           
            await Task.Delay(500);

            for (int i = 0; i < Secuencia.Count; i++)
            {
                int parte = Secuencia[i];
                var pb = ObtenerPictureBox(parte);
                if (pb == null) continue;

                var img_on = ObtenerImagenEncendida(parte);
                var img_off = ObtenerImagenApagada(parte);

                pb.Image = img_on;
                await Task.Delay(400);
                pb.Image = img_off;

                
                await Task.Delay(200);
            }

       
            indiceEntrada = 0;
            Hablando = false;
        }


        private async void ManejarClickJugador(int valor)
        {
            if (Hablando || !EnJuego || Secuencia.Count == 0)
                return;

            if (indiceEntrada >= Secuencia.Count)
                return;

            var pb = ObtenerPictureBox(valor);
            if (pb != null)
            {
                var img_on = ObtenerImagenEncendida(valor);
                var img_off = ObtenerImagenApagada(valor);
                pb.Image = img_on;
                await Task.Delay(150);
                pb.Image = img_off;
            }

            
            if (Secuencia[indiceEntrada] == valor)
            {
                indiceEntrada++;

                
                if (indiceEntrada >= Secuencia.Count)
                {
                    await Task.Delay(600);
                    AgregarPaso();           
                    await MostrarSecuenciaAsync(); 
                }
            }
            else
            {
                
                MessageBox.Show("❌ Has perdido.\nTu récord final: " + Secuencia.Count);
                DetenerMusicaFondo();
                EnJuego = false;
                btn_iniciar.Enabled = true;

                indiceEntrada = 0;
                Secuencia.Clear();
                lbl_puntaje.Text = "0";
            }
        }



        private PictureBox ObtenerPictureBox(int id)
        {
            switch (id)
            {
                case 0: return Zoey;
                case 1: return Leon;
                case 2: return Rumi;
                case 3: return Mira;
                default: return null;
            }
        }

        private System.Drawing.Image ObtenerImagenEncendida(int id)
        {
           
            switch (id)
            {
                case 0: return Properties.Resources._1_on;
                case 1: return Properties.Resources._2_on;
                case 2: return Properties.Resources._3_on;
                case 3: return Properties.Resources._4_on;
                default: return null;
            }
        }

        private System.Drawing.Image ObtenerImagenApagada(int id)
        {
            
            switch (id)
            {
                case 0: return Properties.Resources._1;
                case 1: return Properties.Resources._2;
                case 2: return Properties.Resources._3;
                case 3: return Properties.Resources._4;
                default: return null;
            }
        }
    }
}
