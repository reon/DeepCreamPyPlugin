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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.salvarBT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TamanhoCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CarregadorGB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditorPn
            // 
            this.EditorPn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditorPn.AutoScroll = true;
            this.EditorPn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EditorPn.Location = new System.Drawing.Point(414, 12);
            this.EditorPn.Name = "EditorPn";
            this.EditorPn.Size = new System.Drawing.Size(0, 0);
            this.EditorPn.TabIndex = 0;
            this.EditorPn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EditorPn_MouseDown);
            this.EditorPn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EditorPn_MouseMove);
            // 
            // CarregadorGB
            // 
            this.CarregadorGB.Controls.Add(this.CarregarArquivoBT);
            this.CarregadorGB.Controls.Add(this.localArquivoTXT);
            this.CarregadorGB.Controls.Add(this.NomeArquivoLB);
            this.CarregadorGB.Location = new System.Drawing.Point(12, 12);
            this.CarregadorGB.Name = "CarregadorGB";
            this.CarregadorGB.Size = new System.Drawing.Size(386, 51);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TamanhoCB);
            this.groupBox2.Controls.Add(this.salvarBT);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 92);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controles:";
            // 
            // salvarBT
            // 
            this.salvarBT.Location = new System.Drawing.Point(90, 20);
            this.salvarBT.Name = "salvarBT";
            this.salvarBT.Size = new System.Drawing.Size(110, 23);
            this.salvarBT.TabIndex = 1;
            this.salvarBT.Text = "Save and Convert";
            this.salvarBT.UseVisualStyleBackColor = true;
            this.salvarBT.Click += new System.EventHandler(this.SalvarBT_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Corrigir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 55);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Local do DeepCreamPy:";
            // 
            // TamanhoCB
            // 
            this.TamanhoCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TamanhoCB.Location = new System.Drawing.Point(90, 49);
            this.TamanhoCB.Name = "TamanhoCB";
            this.TamanhoCB.Size = new System.Drawing.Size(121, 21);
            this.TamanhoCB.TabIndex = 2;
            this.TamanhoCB.SelectedIndexChanged += new System.EventHandler(this.TamanhoCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tamanho:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(413, 232);
            this.Controls.Add(this.EditorPn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CarregadorGB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeepCreamPy GUI";
            this.Load += new System.EventHandler(this.Main_Load);
            this.CarregadorGB.ResumeLayout(false);
            this.CarregadorGB.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EditorPn;
        private System.Windows.Forms.GroupBox CarregadorGB;
        private System.Windows.Forms.Button CarregarArquivoBT;
        private System.Windows.Forms.TextBox localArquivoTXT;
        private System.Windows.Forms.Label NomeArquivoLB;
        private System.Windows.Forms.OpenFileDialog ImagemLoaderFD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button salvarBT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TamanhoCB;
    }
}

