namespace WindowsFormsApplication1
{
    partial class frmReturnPart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReturnPart));
            this.lblTakeInfo = new System.Windows.Forms.Label();
            this.cboTechName = new System.Windows.Forms.ComboBox();
            this.lblConfirmInfo = new System.Windows.Forms.Label();
            this.btnCancelReturn = new System.Windows.Forms.Button();
            this.btnContinueReturn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tboDestinationReturn = new System.Windows.Forms.TextBox();
            this.cboReasonReturn = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAddquickID = new System.Windows.Forms.Button();
            this.tboQuickID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTakeInfo
            // 
            this.lblTakeInfo.AutoSize = true;
            this.lblTakeInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblTakeInfo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTakeInfo.Location = new System.Drawing.Point(37, 180);
            this.lblTakeInfo.Name = "lblTakeInfo";
            this.lblTakeInfo.Size = new System.Drawing.Size(869, 32);
            this.lblTakeInfo.TabIndex = 8;
            this.lblTakeInfo.Text = "Scan your part(s) and verify the correct part(s) in the table below.";
            // 
            // cboTechName
            // 
            this.cboTechName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTechName.FormattingEnabled = true;
            this.cboTechName.Location = new System.Drawing.Point(328, 218);
            this.cboTechName.Name = "cboTechName";
            this.cboTechName.Size = new System.Drawing.Size(255, 24);
            this.cboTechName.TabIndex = 13;
            this.cboTechName.Text = "Select Your Name";
            // 
            // lblConfirmInfo
            // 
            this.lblConfirmInfo.AutoSize = true;
            this.lblConfirmInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmInfo.Location = new System.Drawing.Point(164, 274);
            this.lblConfirmInfo.Name = "lblConfirmInfo";
            this.lblConfirmInfo.Size = new System.Drawing.Size(617, 19);
            this.lblConfirmInfo.TabIndex = 12;
            this.lblConfirmInfo.Text = "Click \"Continue\" to Finalize the Transaction, or \"Cancel\" to Void the transaction" +
    ".";
            // 
            // btnCancelReturn
            // 
            this.btnCancelReturn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancelReturn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelReturn.Location = new System.Drawing.Point(28, 542);
            this.btnCancelReturn.Name = "btnCancelReturn";
            this.btnCancelReturn.Size = new System.Drawing.Size(185, 62);
            this.btnCancelReturn.TabIndex = 11;
            this.btnCancelReturn.Text = "Cancel / Void";
            this.btnCancelReturn.UseVisualStyleBackColor = false;
            // 
            // btnContinueReturn
            // 
            this.btnContinueReturn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnContinueReturn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinueReturn.Location = new System.Drawing.Point(738, 542);
            this.btnContinueReturn.Name = "btnContinueReturn";
            this.btnContinueReturn.Size = new System.Drawing.Size(185, 62);
            this.btnContinueReturn.TabIndex = 10;
            this.btnContinueReturn.Text = "Continue";
            this.btnContinueReturn.UseVisualStyleBackColor = false;
            this.btnContinueReturn.Click += new System.EventHandler(this.btnContinueTake_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(323, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 210);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(895, 238);
            this.dataGridView1.TabIndex = 7;
            // 
            // tboDestinationReturn
            // 
            this.tboDestinationReturn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboDestinationReturn.Location = new System.Drawing.Point(599, 234);
            this.tboDestinationReturn.Name = "tboDestinationReturn";
            this.tboDestinationReturn.Size = new System.Drawing.Size(240, 22);
            this.tboDestinationReturn.TabIndex = 15;
            this.tboDestinationReturn.TabStop = false;
            this.tboDestinationReturn.Text = "Optional Notes (Please Type)";
            this.tboDestinationReturn.TextChanged += new System.EventHandler(this.tboDestination_TextChanged);
            // 
            // cboReasonReturn
            // 
            this.cboReasonReturn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReasonReturn.FormattingEnabled = true;
            this.cboReasonReturn.Location = new System.Drawing.Point(328, 247);
            this.cboReasonReturn.Name = "cboReasonReturn";
            this.cboReasonReturn.Size = new System.Drawing.Size(255, 24);
            this.cboReasonReturn.TabIndex = 14;
            this.cboReasonReturn.Text = "Reason for Returning part?";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(52, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(279, 185);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // btnAddquickID
            // 
            this.btnAddquickID.Location = new System.Drawing.Point(389, 582);
            this.btnAddquickID.Name = "btnAddquickID";
            this.btnAddquickID.Size = new System.Drawing.Size(75, 23);
            this.btnAddquickID.TabIndex = 17;
            this.btnAddquickID.Text = "button1";
            this.btnAddquickID.UseVisualStyleBackColor = true;
            this.btnAddquickID.Click += new System.EventHandler(this.btnAddquickID_Click);
            // 
            // tboQuickID
            // 
            this.tboQuickID.Location = new System.Drawing.Point(389, 556);
            this.tboQuickID.Name = "tboQuickID";
            this.tboQuickID.Size = new System.Drawing.Size(100, 20);
            this.tboQuickID.TabIndex = 18;
            // 
            // frmReturnPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(951, 617);
            this.Controls.Add(this.tboQuickID);
            this.Controls.Add(this.btnAddquickID);
            this.Controls.Add(this.tboDestinationReturn);
            this.Controls.Add(this.cboReasonReturn);
            this.Controls.Add(this.lblTakeInfo);
            this.Controls.Add(this.cboTechName);
            this.Controls.Add(this.lblConfirmInfo);
            this.Controls.Add(this.btnCancelReturn);
            this.Controls.Add(this.btnContinueReturn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "frmReturnPart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Returning Part(s) to Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTakeInfo;
        private System.Windows.Forms.ComboBox cboTechName;
        private System.Windows.Forms.Label lblConfirmInfo;
        private System.Windows.Forms.Button btnCancelReturn;
        private System.Windows.Forms.Button btnContinueReturn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tboDestinationReturn;
        private System.Windows.Forms.ComboBox cboReasonReturn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAddquickID;
        private System.Windows.Forms.TextBox tboQuickID;
    }
}