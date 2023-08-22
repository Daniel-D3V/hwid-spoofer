namespace Leinad_Spoofer.UserController
{
    partial class UC_Otimization
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
            this.deleteFilesButton = new System.Windows.Forms.Button();
            this.deleteModsButton = new System.Windows.Forms.Button();
            this.clearCacheButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deleteFilesButton
            // 
            this.deleteFilesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.deleteFilesButton.FlatAppearance.BorderSize = 0;
            this.deleteFilesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteFilesButton.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteFilesButton.ForeColor = System.Drawing.Color.White;
            this.deleteFilesButton.Location = new System.Drawing.Point(12, 159);
            this.deleteFilesButton.Name = "deleteFilesButton";
            this.deleteFilesButton.Size = new System.Drawing.Size(125, 32);
            this.deleteFilesButton.TabIndex = 17;
            this.deleteFilesButton.Text = "Delete Temp Files";
            this.deleteFilesButton.UseVisualStyleBackColor = false;
            this.deleteFilesButton.Click += new System.EventHandler(this.deleteFilesButton_Click);
            // 
            // deleteModsButton
            // 
            this.deleteModsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.deleteModsButton.FlatAppearance.BorderSize = 0;
            this.deleteModsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteModsButton.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteModsButton.ForeColor = System.Drawing.Color.White;
            this.deleteModsButton.Location = new System.Drawing.Point(12, 115);
            this.deleteModsButton.Name = "deleteModsButton";
            this.deleteModsButton.Size = new System.Drawing.Size(125, 32);
            this.deleteModsButton.TabIndex = 16;
            this.deleteModsButton.Text = "Deletar Mods";
            this.deleteModsButton.UseVisualStyleBackColor = false;
            this.deleteModsButton.Click += new System.EventHandler(this.deleteModsButton_Click);
            // 
            // clearCacheButton
            // 
            this.clearCacheButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.clearCacheButton.FlatAppearance.BorderSize = 0;
            this.clearCacheButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearCacheButton.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearCacheButton.ForeColor = System.Drawing.Color.White;
            this.clearCacheButton.Location = new System.Drawing.Point(12, 70);
            this.clearCacheButton.Name = "clearCacheButton";
            this.clearCacheButton.Size = new System.Drawing.Size(125, 32);
            this.clearCacheButton.TabIndex = 15;
            this.clearCacheButton.Text = "Limpar Cache";
            this.clearCacheButton.UseVisualStyleBackColor = false;
            this.clearCacheButton.Click += new System.EventHandler(this.clearCacheButton_Click);
            // 
            // UC_Otimization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.Controls.Add(this.deleteFilesButton);
            this.Controls.Add(this.deleteModsButton);
            this.Controls.Add(this.clearCacheButton);
            this.Name = "UC_Otimization";
            this.Size = new System.Drawing.Size(655, 293);
            this.Load += new System.EventHandler(this.UC_Otimization_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteFilesButton;
        private System.Windows.Forms.Button deleteModsButton;
        private System.Windows.Forms.Button clearCacheButton;
    }
}
