using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.DBContext;
using WindowsFormsApplication1.EFModels;

namespace WindowsFormsApplication1
{
    public partial class frmViewdb : Form
    {
        public frmViewdb()
        {
            InitializeComponent();
            HelperMethods.GetPartsGrid(dataGridView1);
            cboTech.GetTechCbo();
            cboTech.SelectedIndex = -1;
            SwitchText = "None";
            
        }

        private void frmViewdb_Load(object sender, EventArgs e)
        {
            
            

        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            
            SwitchText = "Transaction";
            cboTech.Visible = true;
            btnSearchByTech.Visible = true;
           HelperMethods.GetTransactionsGrid(dataGridView1);

        }

        private void btnPartNumber_Click(object sender, EventArgs e)
        {
            
            SwitchText = "Part";
            cboTech.Visible = false;
            btnSearchByTech.Visible = false;
            HelperMethods.GetPartsGrid(dataGridView1);
        }

        private void cboTech_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSearchByTech_Click(object sender, EventArgs e)
        {
            var techID = Convert.ToInt32(cboTech.SelectedValue);
            HelperMethods.GetTransactionsGridByTechID(techID, dataGridView1);
        }

        public string SwitchText { get; set; }

        private void tboSearch_TextChanged(object sender, EventArgs e)
        {
            HelperMethods.SearchPartsByText(tboSearch.Text, SwitchText, dataGridView1);
        }
    }
}
