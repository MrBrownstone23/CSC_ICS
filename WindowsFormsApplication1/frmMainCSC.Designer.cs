namespace WindowsFormsApplication1
{
    partial class frmMainCSC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainCSC));
            this.btnTake = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewdb = new System.Windows.Forms.Button();
            this.btnAdmindb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTake
            // 
            this.btnTake.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTake.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTake.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTake.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTake.Location = new System.Drawing.Point(132, 304);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(289, 155);
            this.btnTake.TabIndex = 0;
            this.btnTake.Text = "Take from Inventory";
            this.btnTake.UseVisualStyleBackColor = false;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReturn.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReturn.Location = new System.Drawing.Point(506, 304);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(289, 155);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return to Inventory";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(335, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 207);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ethnocentric", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(93, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(789, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "CSC INVENTORY CONTROL SYSTEM";
            // 
            // btnViewdb
            // 
            this.btnViewdb.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnViewdb.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewdb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewdb.Location = new System.Drawing.Point(133, 497);
            this.btnViewdb.Name = "btnViewdb";
            this.btnViewdb.Size = new System.Drawing.Size(288, 64);
            this.btnViewdb.TabIndex = 4;
            this.btnViewdb.Text = "View Database";
            this.btnViewdb.UseVisualStyleBackColor = false;
            this.btnViewdb.Click += new System.EventHandler(this.btnViewdb_Click);
            // 
            // btnAdmindb
            // 
            this.btnAdmindb.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdmindb.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmindb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdmindb.Location = new System.Drawing.Point(506, 497);
            this.btnAdmindb.Name = "btnAdmindb";
            this.btnAdmindb.Size = new System.Drawing.Size(288, 64);
            this.btnAdmindb.TabIndex = 5;
            this.btnAdmindb.Text = "Admin Control";
            this.btnAdmindb.UseVisualStyleBackColor = false;
            this.btnAdmindb.Click += new System.EventHandler(this.btnAdmindb_Click);
            // 
            // frmMainCSC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(951, 617);
            this.Controls.Add(this.btnAdmindb);
            this.Controls.Add(this.btnViewdb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnTake);
            this.Name = "frmMainCSC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSC_ICS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewdb;
        private System.Windows.Forms.Button btnAdmindb;
    }
}

