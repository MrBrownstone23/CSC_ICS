namespace WindowsFormsApplication1.AddToDB
{
    partial class AddPart
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
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tboPartNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboSerialNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboCategory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tboQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tboNotes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tboLocation = new System.Windows.Forms.TextBox();
            this.chkAddSeveral = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(130, 226);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 45);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tboPartNumber
            // 
            this.tboPartNumber.Location = new System.Drawing.Point(12, 66);
            this.tboPartNumber.Name = "tboPartNumber";
            this.tboPartNumber.Size = new System.Drawing.Size(182, 20);
            this.tboPartNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Part Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Serial Number";
            // 
            // tboSerialNumber
            // 
            this.tboSerialNumber.Location = new System.Drawing.Point(12, 121);
            this.tboSerialNumber.Name = "tboSerialNumber";
            this.tboSerialNumber.Size = new System.Drawing.Size(182, 20);
            this.tboSerialNumber.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description";
            // 
            // tboDescription
            // 
            this.tboDescription.Location = new System.Drawing.Point(12, 185);
            this.tboDescription.Name = "tboDescription";
            this.tboDescription.Size = new System.Drawing.Size(182, 20);
            this.tboDescription.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(221, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Category";
            // 
            // tboCategory
            // 
            this.tboCategory.Location = new System.Drawing.Point(221, 66);
            this.tboCategory.Name = "tboCategory";
            this.tboCategory.Size = new System.Drawing.Size(182, 20);
            this.tboCategory.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(324, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantity";
            // 
            // tboQuantity
            // 
            this.tboQuantity.Location = new System.Drawing.Point(324, 185);
            this.tboQuantity.Name = "tboQuantity";
            this.tboQuantity.Size = new System.Drawing.Size(79, 20);
            this.tboQuantity.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(221, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Notes";
            // 
            // tboNotes
            // 
            this.tboNotes.Location = new System.Drawing.Point(221, 121);
            this.tboNotes.Name = "tboNotes";
            this.tboNotes.Size = new System.Drawing.Size(182, 20);
            this.tboNotes.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(221, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Location";
            // 
            // tboLocation
            // 
            this.tboLocation.Location = new System.Drawing.Point(221, 185);
            this.tboLocation.Name = "tboLocation";
            this.tboLocation.Size = new System.Drawing.Size(79, 20);
            this.tboLocation.TabIndex = 16;
            // 
            // chkAddSeveral
            // 
            this.chkAddSeveral.AutoSize = true;
            this.chkAddSeveral.Location = new System.Drawing.Point(44, 254);
            this.chkAddSeveral.Name = "chkAddSeveral";
            this.chkAddSeveral.Size = new System.Drawing.Size(84, 17);
            this.chkAddSeveral.TabIndex = 18;
            this.chkAddSeveral.Text = "Add Several";
            this.chkAddSeveral.UseVisualStyleBackColor = true;
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 292);
            this.Controls.Add(this.chkAddSeveral);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tboLocation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tboNotes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tboQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboSerialNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboPartNumber);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Name = "AddPart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Part";
            this.Load += new System.EventHandler(this.AddPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tboPartNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboSerialNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboNotes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tboLocation;
        private System.Windows.Forms.CheckBox chkAddSeveral;
    }
}