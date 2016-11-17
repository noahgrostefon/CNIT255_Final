using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDirector.Clear();
            txtGenre.Clear();
            txtMovie.Clear();
            txtProducer.Clear();
            txtRelease.Clear();
            cboAwards.SelectedIndex = -1;
            cboSite.SelectedIndex = -1;
        }
    }
}
