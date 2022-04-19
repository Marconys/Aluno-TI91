namespace Projeto_SendSec
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
            this.tb_membro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_EnviarEmail = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Sendemail = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Telefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_EnviarSms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_membro
            // 
            this.tb_membro.Location = new System.Drawing.Point(116, 23);
            this.tb_membro.MaxLength = 9;
            this.tb_membro.Name = "tb_membro";
            this.tb_membro.Size = new System.Drawing.Size(120, 20);
            this.tb_membro.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nº do membro";
            // 
            // btn_EnviarEmail
            // 
            this.btn_EnviarEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EnviarEmail.Location = new System.Drawing.Point(140, 357);
            this.btn_EnviarEmail.Name = "btn_EnviarEmail";
            this.btn_EnviarEmail.Size = new System.Drawing.Size(164, 64);
            this.btn_EnviarEmail.TabIndex = 2;
            this.btn_EnviarEmail.Text = "Enviar Email";
            this.btn_EnviarEmail.UseVisualStyleBackColor = true;
            this.btn_EnviarEmail.Click += new System.EventHandler(this.btn_EnviarEmail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "E-mail";
            // 
            // tb_Sendemail
            // 
            this.tb_Sendemail.Location = new System.Drawing.Point(106, 88);
            this.tb_Sendemail.Multiline = true;
            this.tb_Sendemail.Name = "tb_Sendemail";
            this.tb_Sendemail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_Sendemail.Size = new System.Drawing.Size(575, 238);
            this.tb_Sendemail.TabIndex = 4;
            this.tb_Sendemail.Text = "\r\n";
            this.tb_Sendemail.TextChanged += new System.EventHandler(this.tb_Sendemail_TextChanged);
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(310, 23);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(222, 20);
            this.tb_Email.TabIndex = 5;
            // 
            // tb_Telefone
            // 
            this.tb_Telefone.Location = new System.Drawing.Point(617, 22);
            this.tb_Telefone.Name = "tb_Telefone";
            this.tb_Telefone.Size = new System.Drawing.Size(120, 20);
            this.tb_Telefone.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(554, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefone";
            // 
            // btn_EnviarSms
            // 
            this.btn_EnviarSms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EnviarSms.Location = new System.Drawing.Point(464, 357);
            this.btn_EnviarSms.Name = "btn_EnviarSms";
            this.btn_EnviarSms.Size = new System.Drawing.Size(164, 64);
            this.btn_EnviarSms.TabIndex = 8;
            this.btn_EnviarSms.Text = "Enviar SMS";
            this.btn_EnviarSms.UseVisualStyleBackColor = true;
            this.btn_EnviarSms.Click += new System.EventHandler(this.btn_EnviarSms_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.btn_EnviarSms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Telefone);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.tb_Sendemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_EnviarEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_membro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SendSec -v1.0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_membro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_EnviarEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Telefone;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tb_Sendemail;
        private System.Windows.Forms.Button btn_EnviarSms;
    }
}

