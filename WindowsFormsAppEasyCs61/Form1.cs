using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEasyCs61
{
    public partial class Form1 : Form
    {
        private Label label;

        public void Display()
        {
            Application.Run(new Form1());
        }
        
        public Form1()
        {
            InitializeComponent();
            this.Text = "サンプル";
            this.Width = 250;
            this.Height = 200;

            label = new Label();
            label.Text = "ようこそ！";
            label.Parent = this;
            this.Click += new EventHandler(FormClick);
        }

        public void FormClick(Object sender, EventArgs e)
        {
            label.Text = "こんにちは";
        }
    }
}