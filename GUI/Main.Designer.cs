namespace GUI
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.EditorPn = new System.Windows.Forms.Panel();
            this.CarregadorGB = new System.Windows.Forms.GroupBox();
            this.CarregarArquivoBT = new System.Windows.Forms.Button();
            this.localArquivoTXT = new System.Windows.Forms.TextBox();
            this.NomeArquivoLB = new System.Windows.Forms.Label();
            this.ImagemLoaderFD = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CarregadorGB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditorPn
            // 
            this.EditorPn.AutoScroll = true;
            this.EditorPn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EditorPn.Location = new System.Drawing.Point(6, 19);
            this.EditorPn.Name = "EditorPn";
            this.EditorPn.Size = new System.Drawing.Size(484, 575);
            this.EditorPn.TabIndex = 0;
            // 
            // CarregadorGB
            // 
            this.CarregadorGB.Controls.Add(this.CarregarArquivoBT);
            this.CarregadorGB.Controls.Add(this.localArquivoTXT);
            this.CarregadorGB.Controls.Add(this.NomeArquivoLB);
            this.CarregadorGB.Location = new System.Drawing.Point(12, 12);
            this.CarregadorGB.Name = "CarregadorGB";
            this.CarregadorGB.Size = new System.Drawing.Size(386, 49);
            this.CarregadorGB.TabIndex = 1;
            this.CarregadorGB.TabStop = false;
            this.CarregadorGB.Text = "Adicionar Imagem:";
            // 
            // CarregarArquivoBT
            // 
            this.CarregarArquivoBT.Location = new System.Drawing.Point(305, 17);
            this.CarregarArquivoBT.Name = "CarregarArquivoBT";
            this.CarregarArquivoBT.Size = new System.Drawing.Size(75, 23);
            this.CarregarArquivoBT.TabIndex = 2;
            this.CarregarArquivoBT.Text = "Carregar";
            this.CarregarArquivoBT.UseVisualStyleBackColor = true;
            this.CarregarArquivoBT.Click += new System.EventHandler(this.CarregarArquivoBT_Click);
            // 
            // localArquivoTXT
            // 
            this.localArquivoTXT.Enabled = false;
            this.localArquivoTXT.Location = new System.Drawing.Point(102, 19);
            this.localArquivoTXT.Name = "localArquivoTXT";
            this.localArquivoTXT.Size = new System.Drawing.Size(197, 20);
            this.localArquivoTXT.TabIndex = 1;
            // 
            // NomeArquivoLB
            // 
            this.NomeArquivoLB.AutoSize = true;
            this.NomeArquivoLB.Location = new System.Drawing.Point(6, 22);
            this.NomeArquivoLB.Name = "NomeArquivoLB";
            this.NomeArquivoLB.Size = new System.Drawing.Size(90, 13);
            this.NomeArquivoLB.TabIndex = 0;
            this.NomeArquivoLB.Text = "Local do Arquivo:";
            // 
            // ImagemLoaderFD
            // 
            this.ImagemLoaderFD.Filter = "Imagens Suportadas|*.jpg;*.jpeg;*.png";
            this.ImagemLoaderFD.Title = "Selecione a imagem de origem:";
            this.ImagemLoaderFD.FileOk += new System.ComponentModel.CancelEventHandler(this.ImagemLoaderFD_FileOk);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EditorPn);
            this.groupBox1.Location = new System.Drawing.Point(404, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 600);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visualizar e selecionar área de ação: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(912, 624);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CarregadorGB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeepCreamPy GUI";
            this.CarregadorGB.ResumeLayout(false);
            this.CarregadorGB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EditorPn;
        private System.Windows.Forms.GroupBox CarregadorGB;
        private System.Windows.Forms.Button CarregarArquivoBT;
        private System.Windows.Forms.TextBox localArquivoTXT;
        private System.Windows.Forms.Label NomeArquivoLB;
        private System.Windows.Forms.OpenFileDialog ImagemLoaderFD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

