using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.DBContext;
using WindowsFormsApplication1.EFModels;
using static WindowsFormsApplication1.Enums;

namespace WindowsFormsApplication1
{
    public static class HelperMethods
    {
        public static async void RemovePartFromDB(int partID, string destination, string reason, int techID)
        {
            using (var context = new InventoryContext())
            {
                var partToUpdate = await context.Part.Where(x => x.QuickID == partID).FirstOrDefaultAsync();
                var transaction = new Transaction();


                if (partToUpdate.Quantity.ToInt32() <= 0)
                {
                    MessageBox.Show($"The quantity of {partToUpdate.PartNumber}-{partToUpdate.Description} has a quantity of 0 or less and cannot be checked out.");

                }
                else
                {
                    transaction.QuickID = partID;
                    transaction.Quantity = -1;
                    transaction.Destination = destination;
                    transaction.TechID = techID;
                    transaction.TransactionType = EnumTransactionType.Take;
                    transaction.Reason = reason;
                    transaction.TimeStamp = DateTime.Now;

                    context.Transaction.Add(transaction);

                    
                    var quantity = partToUpdate.Quantity.ToInt32();
                    partToUpdate.Quantity = (quantity - 1).ToString();

                    context.Part.Attach(partToUpdate);
                    var entry = context.Entry(partToUpdate);

                    entry.Property(e => e.Quantity).IsModified = true;
                    

                    context.SaveChanges();
                }
            }

        }
            public static void SavePartToDB(Part part)
        {
            using (var context = new InventoryContext())
            {
                if (part.QuickID == 0)
                {
                    context.Part.Add(part);
                    context.SaveChanges();
                }
                else
                {
                    context.Part.Attach(part);
                    var entry = context.Entry(part);

                    entry.Property(e => e.Category).IsModified = true;
                    entry.Property(e => e.PartNumber).IsModified = true;
                    entry.Property(e => e.Location).IsModified = true;
                    entry.Property(e => e.SerialNumber).IsModified = true;
                    entry.Property(e => e.Description).IsModified = true;
                    entry.Property(e => e.Notes).IsModified = true;
                    entry.Property(e => e.Quantity).IsModified = true;
                    
                }
            }
        }

        public static void TakePartToDB(Part part, int techID, string destination, string reason)
        {
            using (var context = new InventoryContext())
            {

                
                var tech = context.Tech.Where(x => x.TechID == techID).FirstOrDefault();
                    var transaction = new Transaction
                    {
                        TechID = techID,
                        QuickID = part.QuickID,
                        TransactionType = EnumTransactionType.Take,
                        Quantity = -1,
                        Destination = destination,
                        Reason = reason,
                        TimeStamp = DateTime.Now,
                        
                    };
                context.Transaction.Add(transaction);
                context.Part.Attach(part);
                
                
                part.Quantity = (Convert.ToInt32(part.Quantity) - 1).ToString();
                var entry = context.Entry(part);
                entry.Property(x => x.Quantity).IsModified = true;
                
                

                context.SaveChanges();
            }
        }

        public static void ReturnPartToDB(Part part, int techID, string destination, string reason)
        {
            using (var context = new InventoryContext())
            {


                var tech = context.Tech.Where(x => x.TechID == techID).FirstOrDefault();
                var transaction = new Transaction
                {
                    TechID = techID,
                    QuickID = part.QuickID,
                    TransactionType = EnumTransactionType.Receive,
                    Quantity = 1,
                    Destination = destination,
                    Reason = reason,
                    TimeStamp = DateTime.Now,

                };
                context.Transaction.Add(transaction);
                context.Part.Attach(part);


                part.Quantity = (Convert.ToInt32(part.Quantity) + 1).ToString();
                var entry = context.Entry(part);
                entry.Property(x => x.Quantity).IsModified = true;



                context.SaveChanges();
            }
        }

        public static void SaveNewTechToDB(Tech tech)
        {
            using (var context = new InventoryContext())
            {
                if (tech.TechID == 0)
                {
                    context.Tech.Add(tech);
                    context.SaveChanges();
                }
                else
                {
                    context.Tech.Attach(tech);
                    var entry = context.Entry(tech);

                    entry.Property(x => x.FirstName).IsModified = true;
                    entry.Property(x => x.LastName).IsModified = true;
                    entry.Property(x => x.FullName).IsModified = true;
                }
                
            }

        }

        public static void GetPartsGrid(DataGridView dataGridView)
        {
            using (var context = new InventoryContext())
            {
                var parts = context.Part.Select(x => x).ToList();

                var grid = parts.Select(x => new
                {
                    QuickID = x.QuickID,
                    PartNumber = x.PartNumber,
                    Description = x.Description,
                    SerialNumber = x.SerialNumber,
                    Category = x.Category,
                    Location = x.Location,
                    Quantity = x.Quantity
                }).OrderBy(x=> x.PartNumber).ToList();

                dataGridView.DataSource = grid;
                
            }
        }

        public static void GetTechGrid(DataGridView dataGridView)
        {
            using (var context = new InventoryContext())
            {
                var techs = context.Tech.Select(x => new
                {
                    x.TechID,
                    x.FirstName,
                    x.LastName,
                    x.FullName,
                    TransactionData = x.Transaction.Select(z => z),
                    //{
                    //    TimeStamp = z.TimeStamp == null ? new DateTime() : z.TimeStamp,
                    //    //TransactionID = z.TransactionID == 0 ? 0 : z.TransactionID,
                    //}).ToList()
                }).ToList();

                var grid = techs.Select(x => new
                {
                    ID = x.TechID,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    FullName = x.FullName,
                    TransactionCount = x.TransactionData.Count(),
                    //LastTransaction = x.TransactionData
                    //.Select(z => z.TimeStamp.Value.Date.ToShortDateString())
                    //.Last(),
                    //TransactionCount = x.TransactionData?.Select(y=> y.TransactionID).Count()

                }).OrderBy(x => x.LastName).ThenBy(x=> x.FirstName).ToList();

                dataGridView.DataSource = grid;

            }
        }

        public static void GetTransactionsGrid(DataGridView dataGrid)
        {

            using (var context = new InventoryContext())
            {
                var transactions = context.Transaction.Select(x => new
                {
                    x.Destination,
                    TransactionQuantity = x.Quantity,
                    x.Reason,
                    x.TimeStamp,
                    x.TransactionType,
                    PartInfo = context.Part.Where(z => z.QuickID == x.QuickID).Select(z => new
                    {
                        QuickID = z.QuickID,
                        PartNumber = z.PartNumber,
                        SerialNumber = z.SerialNumber,
                        Location = z.Location,
                        Category = z.Category
                    }).FirstOrDefault(),
                    TechName = context.Tech.Where(y => y.TechID == x.TechID).Select(y => y.FullName).FirstOrDefault()
                }).ToList();

                var grid = transactions.Select(x => new
                {
                    x.PartInfo.QuickID,
                    x.PartInfo.PartNumber,
                    x.PartInfo.SerialNumber,
                    Tech = x.TechName,
                    x.TransactionQuantity,
                    Date = x.TimeStamp.Value.Date.ToShortDateString(),
                    x.Reason,
                    x.Destination,
                    x.PartInfo.Location,
                    x.PartInfo.Category
                }).ToList();

                dataGrid.DataSource = grid;

            }
        }

        public static void GetTransactionsGridByTechID(int techID, DataGridView dataGrid)
    {

        using (var context = new InventoryContext())
        {
                var transactions = context.Part.Where(x=> x.Transaction.Select(y=> y.TechID).Contains(techID)).Select(x => new PartsGridInfo
                {
                    QuickID = x.QuickID,
                    PartNumber = x.PartNumber,
                    Description = x.Description,
                    SerialNumber = x.SerialNumber,
                    Category = x.Category,
                    Location = x.Location,
                    Transaction = x.Transaction.Select(z=> new TransactionGridInfo
                    {
                        TransactionQuantity  = z.Quantity,
                        Destination = z.Destination,
                        Reason = z.Reason,
                        TransactionDate = z.TimeStamp,
                        TechFullName = context.Tech.Where(t=> t.TechID == z.TechID).Select(t=> t.FullName).FirstOrDefault()
                        
                    }).ToList()
                   
                  
                }).ToList();

                var grid = transactions.Select(x => new
                {
                    x.QuickID,
                    x.PartNumber,
                    x.SerialNumber,
                    Tech = x.Transaction.Select(z => z.TechFullName).FirstOrDefault(),
                    TransactionQuantity = x.Transaction.Select(z => z.TransactionQuantity).FirstOrDefault(),
                    Date = x.Transaction.Select(z => z.TransactionDate.Value.Date.ToShortDateString()).FirstOrDefault(),
                    Reason = x.Transaction.Select(z => z.Reason).FirstOrDefault(),
                    Destination = x.Transaction.Select(z => z.Destination).FirstOrDefault(),
                    x.Location,
                    x.Category
                }).ToList();

                dataGrid.DataSource = grid;

        }
    }

    public static void GetTechCbo(this ComboBox comboBox)
    {


        var techs = new List<Tech>();
        using (var context = new InventoryContext())
        {
            techs = context.Tech.Select(x => x).ToList();
        }
        comboBox.DataSource = techs;
        comboBox.DisplayMember = "FullName";
        comboBox.ValueMember = "TechID";


    }

        public static void  SearchPartsByText(string searchText,string switchText, DataGridView dataGrid)
        {
            using (var context = new InventoryContext())
            {
                var partData  = context.Part.Select(x => new PartsGridInfo
                {
                    QuickID = x.QuickID,
                    PartNumber = x.PartNumber,
                    Description = x.Description,
                    SerialNumber = x.SerialNumber,
                    Transaction = x.Transaction.Select(z => new TransactionGridInfo
                    {
                        TransactionQuantity = z.Quantity,
                        Destination = z.Destination,
                        Reason = z.Reason,
                        TransactionDate = z.TimeStamp,
                        TechFullName = context.Tech.Where(t => t.TechID == z.TechID).Select(t => t.FullName).FirstOrDefault()

                    }).ToList()
                }).ToList();

                var transactions = context.Transaction.Select(x => new
                {
                    x.Destination,
                    TransactionQuantity = x.Quantity,
                    x.Reason,
                    x.TimeStamp,
                    x.TransactionType,
                    PartInfo = context.Part.Where(z => z.QuickID == x.QuickID).Select(z => new
                    {
                        QuickID = z.QuickID,
                        PartNumber = z.PartNumber,
                        SerialNumber = z.SerialNumber,
                        Location = z.Location,
                        Category = z.Category
                    }).FirstOrDefault(),
                    TechName = context.Tech.Where(y => y.TechID == x.TechID).Select(y => y.FullName).FirstOrDefault()
                }).ToList();

                var gridParts = partData.Where(x=> x.PartNumber.Contains(searchText)).Select(x => new
                {
                    QuickID = x.QuickID,
                    PartNumber = x.PartNumber,
                    Description = x.Description,
                    SerialNumber = x.SerialNumber,
                    Category = x.Category,
                    Location = x.Location,
                    Quantity = x.Quantity
                }).OrderBy(x => x.PartNumber).ToList();

                var gridTransaction = transactions.Where(x => x.PartInfo.PartNumber.Contains(searchText)).Select(x => new
                {
                    x.PartInfo.QuickID,
                    x.PartInfo.PartNumber,
                    x.PartInfo.SerialNumber,
                    Tech = x.TechName,
                    x.TransactionQuantity,
                    Date = x.TimeStamp.Value.Date.ToShortDateString(),
                    x.Reason,
                    x.Destination,
                    x.PartInfo.Location
                }).ToList();

                if (switchText == "Part")
                {
                    dataGrid.DataSource = gridParts;
                }
                if (switchText == "Transaction")
                {
                    dataGrid.DataSource = gridTransaction;
                }


            }
        }

        public static void GetReasonEnumCombobox(this ComboBox comboBox)
        {
            var modes = Enum.GetValues(typeof(EnumReason)).Cast<EnumReason>().Select(mode =>
                   new { Value = mode, Title = mode.ToDescription() }).
                 ToList();
            comboBox.ValueMember = "Value";
            comboBox.DisplayMember = "Title";
            comboBox.DataSource = modes;
        }




}
}
