namespace Desktop.Views
{
    partial class frmAdministrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListUser = new System.Windows.Forms.Button();
            this.btnLIstAviao = new System.Windows.Forms.Button();
            this.btnGAviao = new System.Windows.Forms.Button();
            this.btnGComp = new System.Windows.Forms.Button();
            this.btnGRel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListUser
            // 
            this.btnListUser.Location = new System.Drawing.Point(181, 85);
            this.btnListUser.Name = "btnListUser";
            this.btnListUser.Size = new System.Drawing.Size(129, 100);
            this.btnListUser.TabIndex = 0;
            this.btnListUser.Text = "LIstar Usuários";
            this.btnListUser.UseVisualStyleBackColor = true;
            this.btnListUser.Click += new System.EventHandler(this.btnListUser_Click);
            // 
            // btnLIstAviao
            // 
            this.btnLIstAviao.Location = new System.Drawing.Point(331, 85);
            this.btnLIstAviao.Name = "btnLIstAviao";
            this.btnLIstAviao.Size = new System.Drawing.Size(119, 100);
            this.btnLIstAviao.TabIndex = 1;
            this.btnLIstAviao.Text = "Listar Avião";
            this.btnLIstAviao.UseVisualStyleBackColor = true;
            // 
            // btnGAviao
            // 
            this.btnGAviao.Location = new System.Drawing.Point(471, 85);
            this.btnGAviao.Name = "btnGAviao";
            this.btnGAviao.Size = new System.Drawing.Size(118, 100);
            this.btnGAviao.TabIndex = 2;
            this.btnGAviao.Text = "Gerenciar Avião";
            this.btnGAviao.UseVisualStyleBackColor = true;
            // 
            // btnGComp
            // 
            this.btnGComp.Location = new System.Drawing.Point(181, 211);
            this.btnGComp.Name = "btnGComp";
            this.btnGComp.Size = new System.Drawing.Size(129, 83);
            this.btnGComp.TabIndex = 3;
            this.btnGComp.Text = "Gerenciar Companhia";
            this.btnGComp.UseVisualStyleBackColor = true;
            // 
            // btnGRel
            // 
            this.btnGRel.Location = new System.Drawing.Point(331, 211);
            this.btnGRel.Name = "btnGRel";
            this.btnGRel.Size = new System.Drawing.Size(119, 83);
            this.btnGRel.TabIndex = 4;
            this.btnGRel.Text = "Gerenciar Relátorio";
            this.btnGRel.UseVisualStyleBackColor = true;
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGRel);
            this.Controls.Add(this.btnGComp);
            this.Controls.Add(this.btnGAviao);
            this.Controls.Add(this.btnLIstAviao);
            this.Controls.Add(this.btnListUser);
            this.Name = "frmAdministrador";
            this.Text = "Tela Principal - AirSystem";
            this.Load += new System.EventHandler(this.frmAdministrador_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListUser;
        private System.Windows.Forms.Button btnLIstAviao;
        private System.Windows.Forms.Button btnGAviao;
        private System.Windows.Forms.Button btnGComp;
        private System.Windows.Forms.Button btnGRel;
    }
}