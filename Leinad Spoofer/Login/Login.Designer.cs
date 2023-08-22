namespace Leinad_Spoofer.Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.labelKey = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.minimizedButton = new System.Windows.Forms.Button();
            this.closedButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lsTextBox1 = new Leinad_Spoofer.Components.LSTextBox();
            this.SuspendLayout();
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.labelKey.ForeColor = System.Drawing.Color.White;
            this.labelKey.Location = new System.Drawing.Point(9, 52);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(90, 14);
            this.labelKey.TabIndex = 1;
            this.labelKey.Text = "INSIRA SUA KEY";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.submitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(10, 106);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(371, 24);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Fazer login";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fazer login";
            // 
            // minimizedButton
            // 
            this.minimizedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.minimizedButton.FlatAppearance.BorderSize = 0;
            this.minimizedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizedButton.ForeColor = System.Drawing.Color.Transparent;
            this.minimizedButton.Location = new System.Drawing.Point(315, 9);
            this.minimizedButton.Name = "minimizedButton";
            this.minimizedButton.Size = new System.Drawing.Size(31, 27);
            this.minimizedButton.TabIndex = 5;
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
            this.closedButton.Location = new System.Drawing.Point(352, 9);
            this.closedButton.Name = "closedButton";
            this.closedButton.Size = new System.Drawing.Size(31, 27);
            this.closedButton.TabIndex = 6;
            this.closedButton.Text = "x";
            this.closedButton.UseVisualStyleBackColor = false;
            this.closedButton.Click += new System.EventHandler(this.closedButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(92, 136);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(192, 14);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Precisando de ajuda? Clique aqui!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lsTextBox1
            // 
            this.lsTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lsTextBox1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lsTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lsTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lsTextBox1.BorderSize = 2;
            this.lsTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsTextBox1.ForeColor = System.Drawing.Color.White;
            this.lsTextBox1.ForeColor1 = System.Drawing.Color.White;
            this.lsTextBox1.Location = new System.Drawing.Point(10, 70);
            this.lsTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.lsTextBox1.Multiline = false;
            this.lsTextBox1.Name = "lsTextBox1";
            this.lsTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.lsTextBox1.PasswordChat = false;
            this.lsTextBox1.Size = new System.Drawing.Size(371, 31);
            this.lsTextBox1.TabIndex = 8;
            this.lsTextBox1.UnderlineStyle = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(395, 159);
            this.Controls.Add(this.lsTextBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.closedButton);
            this.Controls.Add(this.minimizedButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.labelKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leinad Spoofer - Fazer login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minimizedButton;
        private System.Windows.Forms.Button closedButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Components.LSTextBox lsTextBox1;
    }
}