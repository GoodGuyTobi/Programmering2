namespace ApartmentBuilder
{
    partial class ApartmentBuilder
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
            this.aptNumBox = new System.Windows.Forms.RichTextBox();
            this.roomCntBox = new System.Windows.Forms.NumericUpDown();
            this.ownerBox = new System.Windows.Forms.RichTextBox();
            this.bckBtn = new System.Windows.Forms.Button();
            this.saeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vacOrNot = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.roomCntBox)).BeginInit();
            this.SuspendLayout();
            // 
            // aptNumBox
            // 
            this.aptNumBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.aptNumBox.Enabled = false;
            this.aptNumBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aptNumBox.Location = new System.Drawing.Point(242, 56);
            this.aptNumBox.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.aptNumBox.Multiline = false;
            this.aptNumBox.Name = "aptNumBox";
            this.aptNumBox.ReadOnly = true;
            this.aptNumBox.Size = new System.Drawing.Size(63, 30);
            this.aptNumBox.TabIndex = 0;
            this.aptNumBox.Text = "";
            // 
            // roomCntBox
            // 
            this.roomCntBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomCntBox.InterceptArrowKeys = false;
            this.roomCntBox.Location = new System.Drawing.Point(242, 123);
            this.roomCntBox.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.roomCntBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.roomCntBox.Name = "roomCntBox";
            this.roomCntBox.ReadOnly = true;
            this.roomCntBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.roomCntBox.Size = new System.Drawing.Size(65, 23);
            this.roomCntBox.TabIndex = 1;
            this.roomCntBox.Tag = "";
            this.roomCntBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ownerBox
            // 
            this.ownerBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownerBox.Location = new System.Drawing.Point(242, 257);
            this.ownerBox.MaxLength = 18;
            this.ownerBox.Multiline = false;
            this.ownerBox.Name = "ownerBox";
            this.ownerBox.Size = new System.Drawing.Size(151, 20);
            this.ownerBox.TabIndex = 3;
            this.ownerBox.Text = "";
            // 
            // bckBtn
            // 
            this.bckBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bckBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bckBtn.Location = new System.Drawing.Point(39, 364);
            this.bckBtn.Margin = new System.Windows.Forms.Padding(30, 3, 3, 20);
            this.bckBtn.MaximumSize = new System.Drawing.Size(150, 60);
            this.bckBtn.MinimumSize = new System.Drawing.Size(150, 60);
            this.bckBtn.Name = "bckBtn";
            this.bckBtn.Size = new System.Drawing.Size(150, 60);
            this.bckBtn.TabIndex = 4;
            this.bckBtn.Text = "Back";
            this.bckBtn.UseVisualStyleBackColor = true;
            this.bckBtn.Click += new System.EventHandler(this.bckBtn_Click);
            // 
            // saeBtn
            // 
            this.saeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saeBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saeBtn.Location = new System.Drawing.Point(243, 364);
            this.saeBtn.Margin = new System.Windows.Forms.Padding(3, 3, 30, 20);
            this.saeBtn.MaximumSize = new System.Drawing.Size(150, 60);
            this.saeBtn.MinimumSize = new System.Drawing.Size(150, 60);
            this.saeBtn.Name = "saeBtn";
            this.saeBtn.Size = new System.Drawing.Size(150, 60);
            this.saeBtn.TabIndex = 5;
            this.saeBtn.Text = "Save";
            this.saeBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(30, 50, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Apartment number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(30, 50, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rooms + Kitchen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(30, 50, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Availability";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 257);
            this.label4.Margin = new System.Windows.Forms.Padding(30, 50, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Owner* (Optional)";
            // 
            // vacOrNot
            // 
            this.vacOrNot.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vacOrNot.FormattingEnabled = true;
            this.vacOrNot.ItemHeight = 15;
            this.vacOrNot.Items.AddRange(new object[] {
            "Vacant",
            "Occupied"});
            this.vacOrNot.Location = new System.Drawing.Point(242, 191);
            this.vacOrNot.MaximumSize = new System.Drawing.Size(100, 30);
            this.vacOrNot.MinimumSize = new System.Drawing.Size(100, 30);
            this.vacOrNot.Name = "vacOrNot";
            this.vacOrNot.Size = new System.Drawing.Size(100, 19);
            this.vacOrNot.TabIndex = 10;
            this.vacOrNot.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ApartmentBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 453);
            this.Controls.Add(this.vacOrNot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saeBtn);
            this.Controls.Add(this.bckBtn);
            this.Controls.Add(this.ownerBox);
            this.Controls.Add(this.roomCntBox);
            this.Controls.Add(this.aptNumBox);
            this.MaximumSize = new System.Drawing.Size(450, 500);
            this.MinimumSize = new System.Drawing.Size(450, 500);
            this.Name = "ApartmentBuilder";
            this.Text = "Create Apartment";
            this.Load += new System.EventHandler(this.ApartmentBuilder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomCntBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox aptNumBox;
        private System.Windows.Forms.NumericUpDown roomCntBox;
        private System.Windows.Forms.RichTextBox ownerBox;
        private System.Windows.Forms.Button bckBtn;
        private System.Windows.Forms.Button saeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox vacOrNot;
    }
}