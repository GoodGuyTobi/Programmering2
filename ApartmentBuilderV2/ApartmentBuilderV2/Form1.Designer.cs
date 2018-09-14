namespace ApartmentBuilderV2
{
    partial class Form1
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
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.lbxApartments = new System.Windows.Forms.ListBox();
            this.lblApartmentCounter = new System.Windows.Forms.Label();
            this.lblRoomCounter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxApartmentDetails = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNew.Location = new System.Drawing.Point(173, 449);
            this.btnCreateNew.Margin = new System.Windows.Forms.Padding(3, 3, 150, 20);
            this.btnCreateNew.MaximumSize = new System.Drawing.Size(200, 75);
            this.btnCreateNew.MinimumSize = new System.Drawing.Size(200, 75);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(200, 75);
            this.btnCreateNew.TabIndex = 0;
            this.btnCreateNew.Text = "Create New Apartment";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // lbxApartments
            // 
            this.lbxApartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxApartments.FormattingEnabled = true;
            this.lbxApartments.ItemHeight = 25;
            this.lbxApartments.Location = new System.Drawing.Point(24, 51);
            this.lbxApartments.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.lbxApartments.MaximumSize = new System.Drawing.Size(230, 275);
            this.lbxApartments.MinimumSize = new System.Drawing.Size(230, 275);
            this.lbxApartments.Name = "lbxApartments";
            this.lbxApartments.Size = new System.Drawing.Size(230, 254);
            this.lbxApartments.TabIndex = 1;
            this.lbxApartments.SelectedIndexChanged += new System.EventHandler(this.lbxApartments_SelectedIndexChanged);
            // 
            // lblApartmentCounter
            // 
            this.lblApartmentCounter.AutoSize = true;
            this.lblApartmentCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApartmentCounter.Location = new System.Drawing.Point(39, 370);
            this.lblApartmentCounter.Name = "lblApartmentCounter";
            this.lblApartmentCounter.Size = new System.Drawing.Size(215, 32);
            this.lblApartmentCounter.TabIndex = 3;
            this.lblApartmentCounter.Text = "Apartments: 4/7";
            // 
            // lblRoomCounter
            // 
            this.lblRoomCounter.AutoSize = true;
            this.lblRoomCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomCounter.Location = new System.Drawing.Point(284, 370);
            this.lblRoomCounter.Name = "lblRoomCounter";
            this.lblRoomCounter.Size = new System.Drawing.Size(191, 32);
            this.lblRoomCounter.TabIndex = 4;
            this.lblRoomCounter.Text = "Rooms: 10/20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Apartments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apartment Details";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(405, 449);
            this.btnUpdate.MaximumSize = new System.Drawing.Size(70, 30);
            this.btnUpdate.MinimumSize = new System.Drawing.Size(70, 30);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 30);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxApartmentDetails
            // 
            this.tbxApartmentDetails.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbxApartmentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxApartmentDetails.Location = new System.Drawing.Point(278, 51);
            this.tbxApartmentDetails.MaximumSize = new System.Drawing.Size(230, 254);
            this.tbxApartmentDetails.MinimumSize = new System.Drawing.Size(230, 254);
            this.tbxApartmentDetails.Multiline = true;
            this.tbxApartmentDetails.Name = "tbxApartmentDetails";
            this.tbxApartmentDetails.ReadOnly = true;
            this.tbxApartmentDetails.Size = new System.Drawing.Size(230, 254);
            this.tbxApartmentDetails.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 553);
            this.Controls.Add(this.tbxApartmentDetails);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRoomCounter);
            this.Controls.Add(this.lblApartmentCounter);
            this.Controls.Add(this.lbxApartments);
            this.Controls.Add(this.btnCreateNew);
            this.MaximumSize = new System.Drawing.Size(550, 600);
            this.MinimumSize = new System.Drawing.Size(550, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apartment Builder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.ListBox lbxApartments;
        private System.Windows.Forms.Label lblApartmentCounter;
        private System.Windows.Forms.Label lblRoomCounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxApartmentDetails;
    }
}

