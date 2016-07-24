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
using static WindowsFormsApplication1.Enums;

namespace WindowsFormsApplication1
{
    public partial class frmReturnPart : Form
    {
        public frmReturnPart()
        {
            InitializeComponent();
            PartList = new List<Part>();
            AllParts = new List<int>();
            cboTechName.GetTechCbo();
            cboReasonReturn.GetReasonEnumCombobox();

            cboTechName.SelectedIndex = -1;
        }

        private void btnContinueTake_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboTechName.SelectedValue == null || cboReasonReturn.Text == "" || tboDestinationReturn.Text == "")
                {
                    throw new ArgumentNullException();
                }

                var partIDList = new List<int>();
                var techID = Convert.ToInt32(cboTechName.SelectedValue);
                var reason = cboReasonReturn.Text;
                var destination = tboDestinationReturn.Text;
                
                foreach (DataGridViewRow Datarow in dataGridView1.Rows)
                {
                    var quickID = Datarow.Cells[0].Value.ToString();

                    partIDList.Add((int)quickID.ToInt32());
                }
                var parts = new List<Part>();
                using (var context = new InventoryContext())
                {
                    parts = context.Part.Where(x => partIDList.Contains(x.QuickID)).Select(x => x).ToList();

                }

                foreach (var part in parts)
                {
                    HelperMethods.ReturnPartToDB(part, techID, destination, reason);
                }
                dataGridView1.DataSource = null;


                this.Close();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show($"All fields must have a value. \r\n {ex.Message}");
            }
        }

        private void tboDestination_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddquickID_Click(object sender, EventArgs e)
        {
            try
            {
                var quickID = int.Parse(tboQuickID.Text);
                if (AllParts.Contains(quickID))
                {
                    throw new Exception();
                }
                AllParts.Add(quickID);

                using (var context = new InventoryContext())
                {
                    var part = context.Part.Where(x => x.QuickID == quickID).FirstOrDefault();
                    if (part == null)
                    {
                        throw new ArgumentNullException();
                    }
                    PartList.Add(part);

                    var grid = PartList.Select(x => new
                    {
                        QuickID = x.QuickID,
                        PartNumber = x.PartNumber,
                        SerialNumber = x.SerialNumber,
                        Description = x.Description,
                        Location = x.Location,
                        Category = x.Category,
                        Quantity = 1
                    }).ToList();

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = grid;
                }

            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("That QuickID was not found.");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"You cannot add the same QuickID twice \r\n {ex.Message}");
            }
            
        }

        public List<Part> PartList { get; set; }
        public List<int> AllParts { get; set; }
    }
}
