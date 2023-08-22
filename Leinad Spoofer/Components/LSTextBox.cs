using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leinad_Spoofer.Components
{
    public partial class LSTextBox : UserControl
    {
        //Fields
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlineStyle = false;
        private Color backColor = Color.White;
        private Color foreColor = Color.Black;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocusded = false;

        public LSTextBox()
        {
            InitializeComponent();
        }

        public Color BorderColor { get { return borderColor; } set { borderColor = value; } }
        public int BorderSize { get => borderSize; set => borderSize = value; }
        public bool UnderlineStyle { get => underlineStyle; set => underlineStyle = value; }
        public Color BackColor1 { get { return base.BackColor; } set { base.BackColor = value; textBox1.BackColor = value; this.backColor = value; } }

        public bool PasswordChat { get { return textBox1.UseSystemPasswordChar; } set { textBox1.UseSystemPasswordChar = value; } }

        public bool Multiline { get { return textBox1.Multiline; } set { textBox1.Multiline = value; } }

        public Color ForeColor1 { get { return base.ForeColor; } set { base.ForeColor = value; textBox1.ForeColor = value; } }

        public Color BorderFocusColor { get { return borderFocusColor; } set { borderFocusColor = value; } }

        public string Text1 { get { return textBox1.Text; } }

        //Overriden methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            //Draw border
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (isFocusded)
                {
                    penBorder.Color = borderFocusColor;
                }

                if (underlineStyle) //Line Style
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                else //Normal Style
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5f, this.Height - 0.5f);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if(textBox1.Multiline == false)
            {
                int textHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, textHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LSTextBox_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocusded = true;
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocusded = false;
            this.Invalidate();
        }
    }
}
