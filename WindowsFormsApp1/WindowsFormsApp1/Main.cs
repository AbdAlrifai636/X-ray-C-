using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        private Form currentChildForm;
        public Main()
        {
            InitializeComponent();
        }

        private void GoToComparison(object sender, EventArgs e)
        {
            OpenChildForm(new Comparison());
        }

        private void GoToDiagnosis(object sender, EventArgs e)
        {
            OpenChildForm(new Diagnosis());
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.Show();
        }

        private void GoToSearch(object sender, EventArgs e)
        {
            OpenChildForm(new Search());
        }

        private void GoToFourier(object sender, EventArgs e)
        {
            OpenChildForm(new Fourier());
        }
    }
}
