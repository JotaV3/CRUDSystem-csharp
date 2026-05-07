namespace CRUDSystem
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.mskTxtBoxTelephone = new System.Windows.Forms.MaskedTextBox();
            this.mskTxtBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxName.Location = new System.Drawing.Point(208, 56);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(384, 31);
            this.txtBoxName.TabIndex = 1;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(208, 130);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(384, 31);
            this.txtBoxEmail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone";
            // 
            // btnRegister
            // 
            this.btnRegister.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(208, 385);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(166, 59);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Cadastrar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(426, 385);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(166, 59);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Voltar";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "CPF";
            // 
            // mskTxtBoxTelephone
            // 
            this.mskTxtBoxTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTxtBoxTelephone.Location = new System.Drawing.Point(208, 204);
            this.mskTxtBoxTelephone.Mask = "(99) 00000-0000";
            this.mskTxtBoxTelephone.Name = "mskTxtBoxTelephone";
            this.mskTxtBoxTelephone.PromptChar = '0';
            this.mskTxtBoxTelephone.Size = new System.Drawing.Size(384, 31);
            this.mskTxtBoxTelephone.TabIndex = 10;
            // 
            // mskTxtBoxCPF
            // 
            this.mskTxtBoxCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTxtBoxCPF.Location = new System.Drawing.Point(208, 273);
            this.mskTxtBoxCPF.Mask = "000,000,000-00";
            this.mskTxtBoxCPF.Name = "mskTxtBoxCPF";
            this.mskTxtBoxCPF.PromptChar = '0';
            this.mskTxtBoxCPF.Size = new System.Drawing.Size(384, 31);
            this.mskTxtBoxCPF.TabIndex = 11;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.mskTxtBoxCPF);
            this.Controls.Add(this.mskTxtBoxTelephone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxTelephone;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxCPF;
    }
}

