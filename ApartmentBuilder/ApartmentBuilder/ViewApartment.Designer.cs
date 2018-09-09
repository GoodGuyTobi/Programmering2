namespace ApartmentBuilder
{
    partial class ViewApartment
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
            this.AptList = new System.Windows.Forms.ListBox();
            this.TxtAptNum = new System.Windows.Forms.Label();
            this.TxtRoomKit = new System.Windows.Forms.Label();
            this.TxtAvi = new System.Windows.Forms.Label();
            this.TxtOwn = new System.Windows.Forms.Label();
            this.BoxAptNum = new System.Windows.Forms.RichTextBox();
            this.BoxRoomKit = new System.Windows.Forms.RichTextBox();
            this.BoxAvi = new System.Windows.Forms.RichTextBox();
            this.BoxOwn = new System.Windows.Forms.RichTextBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AptList
            // 
            this.AptList.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AptList.FormattingEnabled = true;
            this.AptList.ItemHeight = 15;
            this.AptList.Location = new System.Drawing.Point(14, 58);
            this.AptList.Name = "AptList";
            this.AptList.Size = new System.Drawing.Size(135, 169);
            this.AptList.TabIndex = 0;
            this.AptList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // TxtAptNum
            // 
            this.TxtAptNum.AutoSize = true;
            this.TxtAptNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAptNum.Location = new System.Drawing.Point(155, 76);
            this.TxtAptNum.Name = "TxtAptNum";
            this.TxtAptNum.Size = new System.Drawing.Size(134, 16);
            this.TxtAptNum.TabIndex = 1;
            this.TxtAptNum.Text = "Apartment number";
            // 
            // TxtRoomKit
            // 
            this.TxtRoomKit.AutoSize = true;
            this.TxtRoomKit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRoomKit.Location = new System.Drawing.Point(155, 112);
            this.TxtRoomKit.Name = "TxtRoomKit";
            this.TxtRoomKit.Size = new System.Drawing.Size(121, 16);
            this.TxtRoomKit.TabIndex = 2;
            this.TxtRoomKit.Text = "Rooms + Kitchen";
            // 
            // TxtAvi
            // 
            this.TxtAvi.AutoSize = true;
            this.TxtAvi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAvi.Location = new System.Drawing.Point(155, 157);
            this.TxtAvi.Name = "TxtAvi";
            this.TxtAvi.Size = new System.Drawing.Size(84, 16);
            this.TxtAvi.TabIndex = 3;
            this.TxtAvi.Text = "Availability";
            // 
            // TxtOwn
            // 
            this.TxtOwn.AutoSize = true;
            this.TxtOwn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOwn.Location = new System.Drawing.Point(155, 195);
            this.TxtOwn.Name = "TxtOwn";
            this.TxtOwn.Size = new System.Drawing.Size(52, 16);
            this.TxtOwn.TabIndex = 4;
            this.TxtOwn.Text = "Owner";
            // 
            // BoxAptNum
            // 
            this.BoxAptNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.BoxAptNum.Enabled = false;
            this.BoxAptNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxAptNum.Location = new System.Drawing.Point(312, 73);
            this.BoxAptNum.MaximumSize = new System.Drawing.Size(65, 30);
            this.BoxAptNum.MinimumSize = new System.Drawing.Size(65, 30);
            this.BoxAptNum.Multiline = false;
            this.BoxAptNum.Name = "BoxAptNum";
            this.BoxAptNum.ReadOnly = true;
            this.BoxAptNum.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.BoxAptNum.Size = new System.Drawing.Size(65, 30);
            this.BoxAptNum.TabIndex = 0;
            this.BoxAptNum.Text = "";
            // 
            // BoxRoomKit
            // 
            this.BoxRoomKit.Cursor = System.Windows.Forms.Cursors.Default;
            this.BoxRoomKit.Enabled = false;
            this.BoxRoomKit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxRoomKit.Location = new System.Drawing.Point(312, 109);
            this.BoxRoomKit.MaximumSize = new System.Drawing.Size(65, 30);
            this.BoxRoomKit.MinimumSize = new System.Drawing.Size(65, 30);
            this.BoxRoomKit.Multiline = false;
            this.BoxRoomKit.Name = "BoxRoomKit";
            this.BoxRoomKit.ReadOnly = true;
            this.BoxRoomKit.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.BoxRoomKit.Size = new System.Drawing.Size(65, 30);
            this.BoxRoomKit.TabIndex = 5;
            this.BoxRoomKit.Text = "";
            // 
            // BoxAvi
            // 
            this.BoxAvi.Cursor = System.Windows.Forms.Cursors.Default;
            this.BoxAvi.Enabled = false;
            this.BoxAvi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxAvi.Location = new System.Drawing.Point(247, 157);
            this.BoxAvi.MaximumSize = new System.Drawing.Size(130, 20);
            this.BoxAvi.MinimumSize = new System.Drawing.Size(130, 20);
            this.BoxAvi.Multiline = false;
            this.BoxAvi.Name = "BoxAvi";
            this.BoxAvi.ReadOnly = true;
            this.BoxAvi.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.BoxAvi.Size = new System.Drawing.Size(130, 20);
            this.BoxAvi.TabIndex = 6;
            this.BoxAvi.Text = "";
            // 
            // BoxOwn
            // 
            this.BoxOwn.Cursor = System.Windows.Forms.Cursors.Default;
            this.BoxOwn.Enabled = false;
            this.BoxOwn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxOwn.Location = new System.Drawing.Point(247, 195);
            this.BoxOwn.MaximumSize = new System.Drawing.Size(130, 20);
            this.BoxOwn.MinimumSize = new System.Drawing.Size(130, 20);
            this.BoxOwn.Multiline = false;
            this.BoxOwn.Name = "BoxOwn";
            this.BoxOwn.ReadOnly = true;
            this.BoxOwn.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.BoxOwn.Size = new System.Drawing.Size(130, 20);
            this.BoxOwn.TabIndex = 7;
            this.BoxOwn.Text = "";
            this.BoxOwn.TextChanged += new System.EventHandler(this.viewOwn_TextChanged);
            // 
            // BackBtn
            // 
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(139, 329);
            this.BackBtn.MaximumSize = new System.Drawing.Size(150, 60);
            this.BackBtn.MinimumSize = new System.Drawing.Size(150, 60);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(150, 60);
            this.BackBtn.TabIndex = 8;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ViewApartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 453);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.BoxOwn);
            this.Controls.Add(this.BoxAvi);
            this.Controls.Add(this.BoxRoomKit);
            this.Controls.Add(this.BoxAptNum);
            this.Controls.Add(this.TxtOwn);
            this.Controls.Add(this.TxtAvi);
            this.Controls.Add(this.TxtRoomKit);
            this.Controls.Add(this.TxtAptNum);
            this.Controls.Add(this.AptList);
            this.MaximumSize = new System.Drawing.Size(450, 500);
            this.MinimumSize = new System.Drawing.Size(450, 500);
            this.Name = "ViewApartment";
            this.Text = "Apartment Viewer";
            this.Load += new System.EventHandler(this.ViewApartment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AptList;
        private System.Windows.Forms.Label TxtAptNum;
        private System.Windows.Forms.Label TxtRoomKit;
        private System.Windows.Forms.Label TxtAvi;
        private System.Windows.Forms.Label TxtOwn;
        private System.Windows.Forms.RichTextBox BoxAptNum;
        private System.Windows.Forms.RichTextBox BoxRoomKit;
        private System.Windows.Forms.RichTextBox BoxAvi;
        private System.Windows.Forms.RichTextBox BoxOwn;
        private System.Windows.Forms.Button BackBtn;
    }
}