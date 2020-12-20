using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamaTahtasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[] buttons = new Button[3];
            int left = 0;



            for (int i = 0; i < 3; i++)
            {
                buttons[i] = new Button();
                buttons[i].Width = 50;
                buttons[i].Height = 50;   
                buttons[i].Left =left;
                left += 50;
                this.Controls.Add(buttons[i]);
             
            }
        }
    }
}
