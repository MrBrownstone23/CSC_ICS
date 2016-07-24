using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.EFModels;

namespace WindowsFormsApplication1.AddToDB
{
    public partial class AddTech : Form
    {
        frmAdmindb _owner;
        public AddTech(frmAdmindb owner)
        {
            _owner = owner;

            InitializeComponent();
        }

        private void tboFirstName_TextChanged(object sender, EventArgs e)
        {
            lblFullName.Text = $"{tboFirstName.Text} {tboLastName.Text}";
        }

        private void tboLastName_TextChanged(object sender, EventArgs e)
        {
            lblFullName.Text = $"{tboFirstName.Text} {tboLastName.Text}";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tech = new EFModels.Tech();

            tech.FirstName = tboFirstName.Text;
            tech.LastName = tboLastName.Text;
            tech.FullName = $"{tboFirstName.Text} {tboLastName.Text}";

            HelperMethods.SaveNewTechToDB(tech);
            _owner.RefreshTechs();
            this.Close();
        }
    }
}
