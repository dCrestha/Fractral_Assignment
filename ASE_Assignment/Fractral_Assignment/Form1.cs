using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractral_Assignment
{
    public partial class frontForm : Form
    {

        public frontForm()
        {
            InitializeComponent();

        }

        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit? ", "Fractral Assignment", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                Application.Exit();
           
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Developer developer = new About_Developer();
            developer.MdiParent = this;
            developer.Show();

        }

        private void aboutProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Product product = new About_Product();
            product.MdiParent = this;
            product.Show();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
