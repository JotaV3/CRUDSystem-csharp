namespace CRUDSystem
{
    partial class UsersManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNovoUsuario = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.txtBoxSearchUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNovoUsuario.FlatAppearance.BorderSize = 0;
            this.btnNovoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoUsuario.ForeColor = System.Drawing.Color.White;
            this.btnNovoUsuario.Location = new System.Drawing.Point(661, 55);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(170, 53);
            this.btnNovoUsuario.TabIndex = 0;
            this.btnNovoUsuario.Text = "+ Novo usuário";
            this.btnNovoUsuario.UseVisualStyleBackColor = false;
            this.btnNovoUsuario.Click += new System.EventHandler(this.btnNovoUsuario_Click);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewUsers.EnableHeadersVisualStyles = false;
            this.dataGridViewUsers.Location = new System.Drawing.Point(44, 141);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewUsers.RowTemplate.Height = 40;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(787, 215);
            this.dataGridViewUsers.TabIndex = 1;
            this.dataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellContentClick);
            // 
            // txtBoxSearchUser
            // 
            this.txtBoxSearchUser.BackColor = System.Drawing.Color.White;
            this.txtBoxSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearchUser.Location = new System.Drawing.Point(3, 4);
            this.txtBoxSearchUser.Name = "txtBoxSearchUser";
            this.txtBoxSearchUser.Size = new System.Drawing.Size(340, 31);
            this.txtBoxSearchUser.TabIndex = 2;
            this.txtBoxSearchUser.TextChanged += new System.EventHandler(this.txtBoxSearchUser_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pesquisar usuário";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtBoxSearchUser);
            this.panel1.Location = new System.Drawing.Point(44, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 40);
            this.panel1.TabIndex = 4;
            // 
            // UsersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 459);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.btnNovoUsuario);
            this.Name = "UsersManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Usuários";
            this.Load += new System.EventHandler(this.UsersManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovoUsuario;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.TextBox txtBoxSearchUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}