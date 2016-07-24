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
    public partial class AddPart : Form
    {
        frmAdmindb _owner;
        public AddPart(frmAdmindb owner)
        {
            _owner = owner;
            InitializeComponent();
        }

        private void AddPart_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var part = new Part();

            part.Category = tboCategory.Text;
            part.PartNumber = tboPartNumber.Text;
            part.Location = tboLocation.Text;
            part.SerialNumber = tboSerialNumber.Text;
            part.Description = tboDescription.Text;
            part.Notes = tboNotes.Text;
            part.Quantity = tboQuantity.Text;

            HelperMethods.SavePartToDB(part);

            _owner.RefreshParts();
            if (chkAddSeveral.Checked)
            {
                tboCategory.Clear();
                tboPartNumber.Clear();
                tboLocation.Clear();
                tboSerialNumber.Clear();
                tboDescription.Clear();
                tboNotes.Clear();
                tboQuantity.Clear();
            }
            else
            {
                this.Close();
            }
            

        }
    }
}
