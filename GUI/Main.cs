using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
        private Bitmap imgfinal;
        private Image templete;

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
            templete = Image.FromFile(localArquivoTXT.Text);
            EditorPn.Size = templete.Size;
            Width += EditorPn.Width + 10;
            if (templete.Height > Height)
            {
                Height = templete.Height + 60;
            }
            editar = EditorPn.CreateGraphics();
            EditorPn.BackgroundImage = templete;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void SalvarBT_Click(object sender, EventArgs e)
        {
            imgfinal = new Bitmap(templete.Width, templete.Height);
            Graphics tImg = Graphics.FromImage(imgfinal);
            Rectangle marcador = EditorPn.RectangleToScreen(EditorPn.ClientRectangle);
            tImg.CopyFromScreen(marcador.Location, Point.Empty, templete.Size);
            tImg.Dispose();
            SaveFD.ShowDialog(this);
            
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

        private void SaveFD_FileOk(object sender, CancelEventArgs e)
        {
            if (File.Exists(SaveFD.FileName))
            {
                File.Delete(SaveFD.FileName);
            }
            imgfinal.Save(SaveFD.FileName, ImageFormat.Png);
        }
    }
}
