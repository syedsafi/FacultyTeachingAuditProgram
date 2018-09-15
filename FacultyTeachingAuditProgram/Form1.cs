using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultyTeachingAuditProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void btnbrowse_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //title of the dialog box
            ofd.Tag = "Open file ";
            //ofd.Filter = "type of file |*.doc";
            if (ofd.ShowDialog() ==System.Windows.Forms.DialogResult.OK)
            {
                txtbrowse.Text=ofd.FileName;
                lblselectfile.Visible = true;
                lblnamedisplay.Visible = true;
                lblnamedisplay.Text = ofd.SafeFileName;

            }
        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File Import Sucessfull!");
        }
    }
}
