namespace ApartmentBuilderV2
{
    partial class CreateNewApartment
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxApartmentNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxRooms = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxAvailability = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRoomCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 349);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.btnBack.MaximumSize = new System.Drawing.Size(200, 75);
            this.btnBack.MinimumSize = new System.Drawing.Size(200, 75);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 75);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(220, 349);
            this.btnSave.MaximumSize = new System.Drawing.Size(200, 75);
            this.btnSave.MinimumSize = new System.Drawing.Size(200, 75);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 75);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxApartmentNumber
            // 
            this.tbxApartmentNumber.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbxApartmentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxApartmentNumber.Location = new System.Drawing.Point(265, 30);
            this.tbxApartmentNumber.Name = "tbxApartmentNumber";
            this.tbxApartmentNumber.ReadOnly = true;
            this.tbxApartmentNumber.Size = new System.Drawing.Size(79, 27);
            this.tbxApartmentNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Apartment Number";
            // 
            // lbxRooms
            // 
            this.lbxRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxRooms.FormattingEnabled = true;
            this.lbxRooms.ItemHeight = 20;
            this.lbxRooms.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.lbxRooms.Location = new System.Drawing.Point(265, 79);
            this.lbxRooms.Name = "lbxRooms";
            this.lbxRooms.Size = new System.Drawing.Size(120, 104);
            this.lbxRooms.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of Rooms\r\n(Excluding Kitchen)";
            // 
            // lbxAvailability
            // 
            this.lbxAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAvailability.FormattingEnabled = true;
            this.lbxAvailability.ItemHeight = 20;
            this.lbxAvailability.Items.AddRange(new object[] {
            "Vacant",
            "Occupied"});
            this.lbxAvailability.Location = new System.Drawing.Point(265, 189);
            this.lbxAvailability.Name = "lbxAvailability";
            this.lbxAvailability.Size = new System.Drawing.Size(120, 64);
            this.lbxAvailability.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Availability";
            // 
            // lblRoomCounter
            // 
            this.lblRoomCounter.AutoSize = true;
            this.lblRoomCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomCounter.Location = new System.Drawing.Point(12, 283);
            this.lblRoomCounter.Name = "lblRoomCounter";
            this.lblRoomCounter.Size = new System.Drawing.Size(400, 32);
            this.lblRoomCounter.TabIndex = 8;
            this.lblRoomCounter.Text = "Number of rooms available: 10";
            // 
            // CreateNewApartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 453);
            this.Controls.Add(this.lblRoomCounter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbxAvailability);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxRooms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxApartmentNumber);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.MaximumSize = new System.Drawing.Size(450, 500);
            this.MinimumSize = new System.Drawing.Size(450, 500);
            this.Name = "CreateNewApartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateNewApartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxApartmentNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxRooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxAvailability;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRoomCounter;
    }
}