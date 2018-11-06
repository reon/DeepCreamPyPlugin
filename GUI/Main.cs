using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Main : Form
    {
        private Form preset = new Form();
        private Point atual = new Point();
        private Point antigo = new Point();
        private Pen caneta = new Pen(Color.FromArgb(0, 255, 0), 5);
        private Graphics editar;

        public Main()
        {
            InitializeComponent();
            preset.Size = Size;
            List<int> temp = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                temp.Add(i);
            }

            TamanhoCB.DataSource = temp;
            TamanhoCB.SelectedIndex = 4;
        }

        private void CarregarArquivoBT_Click(object sender, EventArgs e)
        {
            ImagemLoaderFD.ShowDialog(this);
        }

        private void ImagemLoaderFD_FileOk(object sender, CancelEventArgs e)
        {
            Size = preset.Size;
            localArquivoTXT.Text = ImagemLoaderFD.FileName;
            Image imagem = Image.FromFile(localArquivoTXT.Text);
            EditorPn.Size = imagem.Size;
            Width += EditorPn.Width + 10;
            if (imagem.Height > Height)
            {
                Height = imagem.Height + 60;
            }
            editar = EditorPn.CreateGraphics();
            EditorPn.BackgroundImage = imagem;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void SalvarBT_Click(object sender, EventArgs e)
        {
            //Bitmap 
        }

        private void EditorPn_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                atual = e.Location;
                editar.DrawLine(caneta, antigo, atual);
                antigo = atual;
            }
        }

        private void EditorPn_MouseDown(object sender, MouseEventArgs e)
        {
            antigo = e.Location;
        }

        private void TamanhoCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TamanhoCB.SelectedItem != null)
            {
                caneta.Width = Convert.ToInt32(TamanhoCB.SelectedItem);
            }
            
        }
    }
}
