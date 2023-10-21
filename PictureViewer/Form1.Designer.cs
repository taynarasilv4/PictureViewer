namespace PictureViewer
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MostrarBotao = new System.Windows.Forms.Button();
            this.LimparBotao = new System.Windows.Forms.Button();
            this.CorFundoBotao = new System.Windows.Forms.Button();
            this.FecharBotao = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(662, 410);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(658, 350);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(2, 356);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 19);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Stretch\r\n";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.MostrarBotao);
            this.flowLayoutPanel1.Controls.Add(this.LimparBotao);
            this.flowLayoutPanel1.Controls.Add(this.CorFundoBotao);
            this.flowLayoutPanel1.Controls.Add(this.FecharBotao);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(101, 356);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(559, 35);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // MostrarBotao
            // 
            this.MostrarBotao.AutoSize = true;
            this.MostrarBotao.Location = new System.Drawing.Point(421, 2);
            this.MostrarBotao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MostrarBotao.Name = "MostrarBotao";
            this.MostrarBotao.Size = new System.Drawing.Size(136, 25);
            this.MostrarBotao.TabIndex = 0;
            this.MostrarBotao.Text = "Mostrar uma imagem";
            this.MostrarBotao.UseVisualStyleBackColor = true;
            this.MostrarBotao.Click += new System.EventHandler(this.MostrarBotao_Click);
            // 
            // LimparBotao
            // 
            this.LimparBotao.AutoSize = true;
            this.LimparBotao.Location = new System.Drawing.Point(299, 2);
            this.LimparBotao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LimparBotao.Name = "LimparBotao";
            this.LimparBotao.Size = new System.Drawing.Size(118, 25);
            this.LimparBotao.TabIndex = 3;
            this.LimparBotao.Text = " Limpar a imagem";
            this.LimparBotao.UseVisualStyleBackColor = true;
            this.LimparBotao.Click += new System.EventHandler(this.LimparBotao_Click);
            // 
            // CorFundoBotao
            // 
            this.CorFundoBotao.AutoSize = true;
            this.CorFundoBotao.Location = new System.Drawing.Point(121, 2);
            this.CorFundoBotao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CorFundoBotao.Name = "CorFundoBotao";
            this.CorFundoBotao.Size = new System.Drawing.Size(174, 25);
            this.CorFundoBotao.TabIndex = 4;
            this.CorFundoBotao.Text = "Definir a cor da tela de fundo";
            this.CorFundoBotao.UseVisualStyleBackColor = true;
            this.CorFundoBotao.Click += new System.EventHandler(this.CorFundoBotao_Click);
            // 
            // FecharBotao
            // 
            this.FecharBotao.AutoSize = true;
            this.FecharBotao.Location = new System.Drawing.Point(61, 2);
            this.FecharBotao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FecharBotao.Name = "FecharBotao";
            this.FecharBotao.Size = new System.Drawing.Size(56, 25);
            this.FecharBotao.TabIndex = 5;
            this.FecharBotao.Text = "Fechar";
            this.FecharBotao.UseVisualStyleBackColor = true;
            this.FecharBotao.Click += new System.EventHandler(this.FecharBotao_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Selecionar um arquivo de imagem";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 410);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Picture Viewer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button MostrarBotao;
        private System.Windows.Forms.Button LimparBotao;
        private System.Windows.Forms.Button CorFundoBotao;
        private System.Windows.Forms.Button FecharBotao;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

