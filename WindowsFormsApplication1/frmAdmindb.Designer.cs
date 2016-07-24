namespace WindowsFormsApplication1
{
    partial class frmAdmindb
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
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnAddTech = new System.Windows.Forms.Button();
            this.dgdAdmin = new System.Windows.Forms.DataGridView();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._WindowsFormsApplication1_DBContext_InventoryContextDataSet = new WindowsFormsApplication1._WindowsFormsApplication1_DBContext_InventoryContextDataSet();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.partTableAdapter = new WindowsFormsApplication1._WindowsFormsApplication1_DBContext_InventoryContextDataSetTableAdapters.PartTableAdapter();
            this.lblGrid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgdAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._WindowsFormsApplication1_DBContext_InventoryContextDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPart
            // 
            this.btnAddPart.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddPart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddPart.Location = new System.Drawing.Point(222, 12);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(150, 51);
            this.btnAddPart.TabIndex = 9;
            this.btnAddPart.Text = "Add Part";
            this.btnAddPart.UseVisualStyleBackColor = false;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // btnAddTech
            // 
            this.btnAddTech.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddTech.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTech.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddTech.Location = new System.Drawing.Point(34, 12);
            this.btnAddTech.Name = "btnAddTech";
            this.btnAddTech.Size = new System.Drawing.Size(150, 51);
            this.btnAddTech.TabIndex = 8;
            this.btnAddTech.Text = "Add Tech";
            this.btnAddTech.UseVisualStyleBackColor = false;
            this.btnAddTech.Click += new System.EventHandler(this.btnAddTech_Click);
            // 
            // dgdAdmin
            // 
            this.dgdAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdAdmin.Location = new System.Drawing.Point(34, 121);
            this.dgdAdmin.Name = "dgdAdmin";
            this.dgdAdmin.Size = new System.Drawing.Size(801, 484);
            this.dgdAdmin.TabIndex = 7;
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
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(842, 317);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 46);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "- Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(842, 381);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 46);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(842, 251);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 46);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "+Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // partTableAdapter
            // 
            this.partTableAdapter.ClearBeforeFill = true;
            // 
            // lblGrid
            // 
            this.lblGrid.AutoSize = true;
            this.lblGrid.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblGrid.Location = new System.Drawing.Point(28, 86);
            this.lblGrid.Name = "lblGrid";
            this.lblGrid.Size = new System.Drawing.Size(66, 26);
            this.lblGrid.TabIndex = 17;
            this.lblGrid.Text = "Parts";
            // 
            // frmAdmindb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(951, 617);
            this.Controls.Add(this.lblGrid);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.btnAddTech);
            this.Controls.Add(this.dgdAdmin);
            this.Name = "frmAdmindb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Database Managment";
            this.Load += new System.EventHandler(this.frmAdmindb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._WindowsFormsApplication1_DBContext_InventoryContextDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnAddTech;
        private System.Windows.Forms.DataGridView dgdAdmin;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private _WindowsFormsApplication1_DBContext_InventoryContextDataSet _WindowsFormsApplication1_DBContext_InventoryContextDataSet;
        private System.Windows.Forms.BindingSource partBindingSource;
        private _WindowsFormsApplication1_DBContext_InventoryContextDataSetTableAdapters.PartTableAdapter partTableAdapter;
        private System.Windows.Forms.Label lblGrid;
    }
}