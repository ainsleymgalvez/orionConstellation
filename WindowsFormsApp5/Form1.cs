using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class orionConstellation : Form
    {
        public orionConstellation()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            betelgeuseLabel.Visible = true;
            alnilamLabel.Visible = true;
            alnitakLabel.Visible = true;
            saiphLabel.Visible = true;
            mintakaLabel.Visible = true;
            meissaLabel.Visible = true;
            rigelLabel.Visible = true;
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            betelgeuseLabel.Visible = false;
            alnilamLabel.Visible = false;
            alnitakLabel.Visible = false;
            saiphLabel.Visible = false;
            mintakaLabel.Visible = false;
            meissaLabel.Visible = false;
            rigelLabel.Visible = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
