using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;


namespace ProcessamentoImagens
{
    public partial class frmPrincipal : Form
    {
        private Image image;
        private Bitmap imageBitmap;


        private Point posInicial;
        private Point posFinal;

        public frmPrincipal()
        {
            InitializeComponent();

            imageBitmap = new Bitmap(pictBoxImg1.ClientSize.Width,pictBoxImg1.ClientSize.Height,
                PixelFormat.Format24bppRgb);

            Filtros.imagemBranca(imageBitmap);

            pictBoxImg1.SizeMode = PictureBoxSizeMode.Normal;
            pictBoxImg1.Image = imageBitmap;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Filtros.imagemBranca(imageBitmap);
            pictBoxImg1.Image = imageBitmap;
        }

        private void btnEquacaoReta_CheckedChanged(object sender, EventArgs e)
        {
            Filtros.bresenham(imageBitmap, posInicial.X, posInicial.Y, posFinal.X, posFinal.Y);
            pictBoxImg1.Refresh();

        }

        private void btnDDA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPontoMedioRetas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPontoMedioElipse_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEquacaoCircunferencia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTrigonometria_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPontoMedioCircunferencia_CheckedChanged(object sender, EventArgs e)
        {

        }



        //capturar posição mouse
        private void pictBoxImg1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                posInicial = e.Location;
                Console.WriteLine($"Início: {posInicial.X}, {posInicial.Y}");
            }
        }

        private void pictBoxImg1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                posFinal = e.Location; // Salva a posição ao soltar
                Console.WriteLine($"Fim: {posFinal.X}, {posFinal.Y}");
            }
        }

        
    }
}
