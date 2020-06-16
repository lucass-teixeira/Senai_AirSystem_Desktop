namespace Desktop
{
    partial class formLogin
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
            this.components = new System.ComponentModel.Container();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnNovoUsu = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkBoxMs = new System.Windows.Forms.CheckBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.labelIdioma = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(328, 332);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(51, 23);
            this.btnEntrar.TabIndex = 0;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(385, 332);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(45, 23);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnNovoUsu
            // 
            this.btnNovoUsu.Location = new System.Drawing.Point(449, 332);
            this.btnNovoUsu.Name = "btnNovoUsu";
            this.btnNovoUsu.Size = new System.Drawing.Size(83, 23);
            this.btnNovoUsu.TabIndex = 0;
            this.btnNovoUsu.Text = "Novo Usuário";
            this.btnNovoUsu.UseVisualStyleBackColor = true;
            this.btnNovoUsu.Click += new System.EventHandler(this.btnNovoUsu_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(390, 19);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(105, 24);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "20:30:22:22";
            this.lblTime.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(328, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(328, 209);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(36, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 251);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.Location = new System.Drawing.Point(328, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 97);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // checkBoxMs
            // 
            this.checkBoxMs.AutoSize = true;
            this.checkBoxMs.Location = new System.Drawing.Point(328, 235);
            this.checkBoxMs.Name = "checkBoxMs";
            this.checkBoxMs.Size = new System.Drawing.Size(92, 17);
            this.checkBoxMs.TabIndex = 10;
            this.checkBoxMs.Text = "mostrar senha";
            this.checkBoxMs.UseVisualStyleBackColor = true;
            this.checkBoxMs.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(325, 151);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "Usuário";
            this.lblUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(325, 193);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 11;
            this.lblSenha.Text = "Senha";
            this.lblSenha.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelIdioma
            // 
            this.labelIdioma.AutoSize = true;
            this.labelIdioma.Location = new System.Drawing.Point(330, 273);
            this.labelIdioma.Name = "labelIdioma";
            this.labelIdioma.Size = new System.Drawing.Size(38, 13);
            this.labelIdioma.TabIndex = 11;
            this.labelIdioma.Text = "Idioma";
            this.labelIdioma.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Português",
            "Inglês"});
            this.comboBox1.Location = new System.Drawing.Point(328, 289);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 367);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelIdioma);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.checkBoxMs);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnNovoUsu);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnSair);
            this.Name = "formLogin";
            this.Text = "Login - AirSystem";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnNovoUsu;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBoxMs;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label labelIdioma;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

