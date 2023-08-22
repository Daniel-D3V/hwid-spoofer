using System.Windows.Forms;

namespace Leinad_Spoofer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panelController = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hardwareButtonMenu = new System.Windows.Forms.Button();
            this.cityButtonMenu = new System.Windows.Forms.Button();
            this.globalButtonMenu = new System.Windows.Forms.Button();
            this.minimizedButton = new System.Windows.Forms.Button();
            this.closedButton = new System.Windows.Forms.Button();
            this.otmizeButtonMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelController.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "LEINAD SPOOFER";
            // 
            // panelController
            // 
            this.panelController.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.panelController.Controls.Add(this.label5);
            this.panelController.Controls.Add(this.label4);
            this.panelController.Location = new System.Drawing.Point(12, 126);
            this.panelController.Name = "panelController";
            this.panelController.Size = new System.Drawing.Size(655, 272);
            this.panelController.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Black", 7F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "PC Name: DESKTOP-LEL6AJJ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 7F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "USERNAME: Daniel Silva";
            // 
            // hardwareButtonMenu
            // 
            this.hardwareButtonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.hardwareButtonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hardwareButtonMenu.FlatAppearance.BorderSize = 0;
            this.hardwareButtonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hardwareButtonMenu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.hardwareButtonMenu.ForeColor = System.Drawing.Color.White;
            this.hardwareButtonMenu.Location = new System.Drawing.Point(357, 71);
            this.hardwareButtonMenu.Name = "hardwareButtonMenu";
            this.hardwareButtonMenu.Size = new System.Drawing.Size(125, 32);
            this.hardwareButtonMenu.TabIndex = 8;
            this.hardwareButtonMenu.Text = "Hwid";
            this.hardwareButtonMenu.UseVisualStyleBackColor = false;
            // 
            // cityButtonMenu
            // 
            this.cityButtonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cityButtonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cityButtonMenu.FlatAppearance.BorderSize = 0;
            this.cityButtonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cityButtonMenu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.cityButtonMenu.ForeColor = System.Drawing.Color.White;
            this.cityButtonMenu.Location = new System.Drawing.Point(186, 71);
            this.cityButtonMenu.Name = "cityButtonMenu";
            this.cityButtonMenu.Size = new System.Drawing.Size(125, 32);
            this.cityButtonMenu.TabIndex = 7;
            this.cityButtonMenu.Text = "Cidade";
            this.cityButtonMenu.UseVisualStyleBackColor = false;
            // 
            // globalButtonMenu
            // 
            this.globalButtonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.globalButtonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.globalButtonMenu.FlatAppearance.BorderSize = 0;
            this.globalButtonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.globalButtonMenu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.globalButtonMenu.ForeColor = System.Drawing.Color.White;
            this.globalButtonMenu.Location = new System.Drawing.Point(16, 71);
            this.globalButtonMenu.Name = "globalButtonMenu";
            this.globalButtonMenu.Size = new System.Drawing.Size(125, 32);
            this.globalButtonMenu.TabIndex = 6;
            this.globalButtonMenu.Text = "Global";
            this.globalButtonMenu.UseVisualStyleBackColor = false;
            this.globalButtonMenu.Click += new System.EventHandler(this.globalButtonMenu_Click);
            // 
            // minimizedButton
            // 
            this.minimizedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.minimizedButton.FlatAppearance.BorderSize = 0;
            this.minimizedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizedButton.ForeColor = System.Drawing.Color.Transparent;
            this.minimizedButton.Location = new System.Drawing.Point(599, 18);
            this.minimizedButton.Name = "minimizedButton";
            this.minimizedButton.Size = new System.Drawing.Size(31, 27);
            this.minimizedButton.TabIndex = 4;
            this.minimizedButton.Text = "-";
            this.minimizedButton.UseVisualStyleBackColor = false;
            this.minimizedButton.Click += new System.EventHandler(this.minimizedButton_Click);
            // 
            // closedButton
            // 
            this.closedButton.AccessibleDescription = "";
            this.closedButton.AccessibleName = "Minimzar";
            this.closedButton.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.closedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.closedButton.FlatAppearance.BorderSize = 0;
            this.closedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closedButton.ForeColor = System.Drawing.Color.Transparent;
            this.closedButton.Location = new System.Drawing.Point(636, 18);
            this.closedButton.Name = "closedButton";
            this.closedButton.Size = new System.Drawing.Size(31, 27);
            this.closedButton.TabIndex = 5;
            this.closedButton.Text = "x";
            this.closedButton.UseVisualStyleBackColor = false;
            this.closedButton.Click += new System.EventHandler(this.closedButton_Click);
            // 
            // otmizeButtonMenu
            // 
            this.otmizeButtonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.otmizeButtonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.otmizeButtonMenu.FlatAppearance.BorderSize = 0;
            this.otmizeButtonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.otmizeButtonMenu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otmizeButtonMenu.ForeColor = System.Drawing.Color.White;
            this.otmizeButtonMenu.Location = new System.Drawing.Point(528, 71);
            this.otmizeButtonMenu.Name = "otmizeButtonMenu";
            this.otmizeButtonMenu.Size = new System.Drawing.Size(125, 32);
            this.otmizeButtonMenu.TabIndex = 12;
            this.otmizeButtonMenu.Text = "Otimização";
            this.otmizeButtonMenu.UseVisualStyleBackColor = false;
            this.otmizeButtonMenu.Click += new System.EventHandler(this.otmizeButtonMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(625, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "v" + Application.ProductVersion;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(679, 431);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.otmizeButtonMenu);
            this.Controls.Add(this.closedButton);
            this.Controls.Add(this.minimizedButton);
            this.Controls.Add(this.panelController);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.globalButtonMenu);
            this.Controls.Add(this.cityButtonMenu);
            this.Controls.Add(this.hardwareButtonMenu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leinad Spoofer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panelController.ResumeLayout(false);
            this.panelController.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelController;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button globalButtonMenu;
        private System.Windows.Forms.Button cityButtonMenu;
        private System.Windows.Forms.Button hardwareButtonMenu;
        private System.Windows.Forms.Button minimizedButton;
        private System.Windows.Forms.Button closedButton;
        private System.Windows.Forms.Button otmizeButtonMenu;
        private System.Windows.Forms.Label label2;
    }
}

