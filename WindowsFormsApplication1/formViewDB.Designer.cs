namespace WindowsFormsApplication1
{
    partial class frmViewdb
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._WindowsFormsApplication1_DBContext_InventoryContextDataSet = new WindowsFormsApplication1._WindowsFormsApplication1_DBContext_InventoryContextDataSet();
            this.btnPartNumber = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.tboSearch = new System.Windows.Forms.TextBox();
            this.partTableAdapter = new WindowsFormsApplication1._WindowsFormsApplication1_DBContext_InventoryContextDataSetTableAdapters.PartTableAdapter();
            this.techBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techTableAdapter = new WindowsFormsApplication1._WindowsFormsApplication1_DBContext_InventoryContextDataSetTableAdapters.TechTableAdapter();
            this.cboTech = new System.Windows.Forms.ComboBox();
            this.btnSearchByTech = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._WindowsFormsApplication1_DBContext_InventoryContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(31, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(883, 435);
            this.dataGridView1.TabIndex = 0;
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataMember = "Part";
            this.partBindingSource.DataSource = this._WindowsFormsApplication1_DBContext_InventoryContextDataSet;
            // 
            // _WindowsFormsApplication1_DBContext_InventoryContextDataSet
            // 
            this._WindowsFormsApplication1_DBContext_InventoryContextDataSet.DataSetName = "_WindowsFormsApplication1_DBContext_InventoryContextDataSet";
            this._WindowsFormsApplication1_DBContext_InventoryContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPartNumber
            // 
            this.btnPartNumber.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPartNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPartNumber.Location = new System.Drawing.Point(31, 41);
            this.btnPartNumber.Name = "btnPartNumber";
            this.btnPartNumber.Size = new System.Drawing.Size(150, 51);
            this.btnPartNumber.TabIndex = 1;
            this.btnPartNumber.Text = "Part";
            this.btnPartNumber.UseVisualStyleBackColor = false;
            this.btnPartNumber.Click += new System.EventHandler(this.btnPartNumber_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTransactions.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTransactions.Location = new System.Drawing.Point(187, 41);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(150, 51);
            this.btnTransactions.TabIndex = 5;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.UseVisualStyleBackColor = false;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // tboSearch
            // 
            this.tboSearch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboSearch.Location = new System.Drawing.Point(31, 109);
            this.tboSearch.Name = "tboSearch";
            this.tboSearch.Size = new System.Drawing.Size(514, 25);
            this.tboSearch.TabIndex = 6;
            this.tboSearch.Text = "Search";
            this.tboSearch.TextChanged += new System.EventHandler(this.tboSearch_TextChanged);
            // 
            // partTableAdapter
            // 
            this.partTableAdapter.ClearBeforeFill = true;
            // 
            // techBindingSource
            // 
            this.techBindingSource.DataMember = "Tech";
            this.techBindingSource.DataSource = this._WindowsFormsApplication1_DBContext_InventoryContextDataSet;
            // 
            // techTableAdapter
            // 
            this.techTableAdapter.ClearBeforeFill = true;
            // 
            // cboTech
            // 
            this.cboTech.FormattingEnabled = true;
            this.cboTech.Location = new System.Drawing.Point(573, 109);
            this.cboTech.Name = "cboTech";
            this.cboTech.Size = new System.Drawing.Size(202, 21);
            this.cboTech.TabIndex = 7;
            this.cboTech.Visible = false;
            this.cboTech.SelectedIndexChanged += new System.EventHandler(this.cboTech_SelectedIndexChanged);
            // 
            // btnSearchByTech
            // 
            this.btnSearchByTech.Location = new System.Drawing.Point(782, 109);
            this.btnSearchByTech.Name = "btnSearchByTech";
            this.btnSearchByTech.Size = new System.Drawing.Size(75, 35);
            this.btnSearchByTech.TabIndex = 8;
            this.btnSearchByTech.Text = "Search Tech";
            this.btnSearchByTech.UseVisualStyleBackColor = true;
            this.btnSearchByTech.Visible = false;
            this.btnSearchByTech.Click += new System.EventHandler(this.btnSearchByTech_Click);
            // 
            // frmViewdb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(951, 617);
            this.Controls.Add(this.btnSearchByTech);
            this.Controls.Add(this.cboTech);
            this.Controls.Add(this.tboSearch);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnPartNumber);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmViewdb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Viewer";
            this.Load += new System.EventHandler(this.frmViewdb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._WindowsFormsApplication1_DBContext_InventoryContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPartNumber;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.TextBox tboSearch;
        private _WindowsFormsApplication1_DBContext_InventoryContextDataSet _WindowsFormsApplication1_DBContext_InventoryContextDataSet;
        private System.Windows.Forms.BindingSource partBindingSource;
        private _WindowsFormsApplication1_DBContext_InventoryContextDataSetTableAdapters.PartTableAdapter partTableAdapter;
        private System.Windows.Forms.BindingSource techBindingSource;
        private _WindowsFormsApplication1_DBContext_InventoryContextDataSetTableAdapters.TechTableAdapter techTableAdapter;
        private System.Windows.Forms.ComboBox cboTech;
        private System.Windows.Forms.Button btnSearchByTech;
    }
}