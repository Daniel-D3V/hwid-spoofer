namespace Leinad_Spoofer.UserController
{
    partial class UC_Global
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.unbanButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // unbanButton
            // 
            this.unbanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.unbanButton.FlatAppearance.BorderSize = 0;
            this.unbanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unbanButton.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unbanButton.ForeColor = System.Drawing.Color.White;
            this.unbanButton.Location = new System.Drawing.Point(12, 159);
            this.unbanButton.Name = "unbanButton";
            this.unbanButton.Size = new System.Drawing.Size(125, 32);
            this.unbanButton.TabIndex = 14;
            this.unbanButton.Text = "Unban FIveM";
            this.unbanButton.UseVisualStyleBackColor = false;
            this.unbanButton.Click += new System.EventHandler(this.unbanButton_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(12, 115);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 32);
            this.button5.TabIndex = 13;
            this.button5.Text = "Citzen Download";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(12, 70);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(125, 32);
            this.logoutButton.TabIndex = 12;
            this.logoutButton.Text = "Logout FiveM";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // UC_Global
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.Controls.Add(this.unbanButton);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.logoutButton);
            this.Name = "UC_Global";
            this.Size = new System.Drawing.Size(655, 293);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button unbanButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button logoutButton;
    }
}
