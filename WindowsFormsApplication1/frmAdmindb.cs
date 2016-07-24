using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.AddToDB;

namespace WindowsFormsApplication1
{
    public partial class frmAdmindb : Form
    {
        public frmAdmindb()
        {
            InitializeComponent();
        }

        private void frmAdmindb_Load(object sender, EventArgs e)
        {
            HelperMethods.GetPartsGrid(dgdAdmin);

        }

        private void btnAddTech_Click(object sender, EventArgs e)
        {
            lblGrid.Text = "Techs";
            HelperMethods.GetTechGrid(dgdAdmin);
            var addTechWindow = new AddTech(this);
            addTechWindow.Show();
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            RefreshParts();
            lblGrid.Text = "Parts";
            var addPartWindow = new AddPart(this);
            addPartWindow.Show();
            
        }

        public void RefreshParts()
        {
            HelperMethods.GetPartsGrid(dgdAdmin);
        }

        public void RefreshTechs()
        {
            HelperMethods.GetTechGrid(dgdAdmin);
        }
    }
}
