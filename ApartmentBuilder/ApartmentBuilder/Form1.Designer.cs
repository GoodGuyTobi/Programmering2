namespace ApartmentBuilder
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
            this.title = new System.Windows.Forms.Label();
            this.crtApt = new System.Windows.Forms.Button();
            this.viewApt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(35, 66);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(345, 23);
            this.title.TabIndex = 0;
            this.title.Text = "GoodGuyTobi\'s Apartment Builder";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // crtApt
            // 
            this.crtApt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.crtApt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crtApt.Location = new System.Drawing.Point(90, 160);
            this.crtApt.Margin = new System.Windows.Forms.Padding(100, 3, 100, 3);
            this.crtApt.MaximumSize = new System.Drawing.Size(250, 70);
            this.crtApt.MinimumSize = new System.Drawing.Size(250, 70);
            this.crtApt.Name = "crtApt";
            this.crtApt.Size = new System.Drawing.Size(250, 70);
            this.crtApt.TabIndex = 1;
            this.crtApt.Text = "Create Apartment";
            this.crtApt.UseVisualStyleBackColor = true;
            this.crtApt.Click += new System.EventHandler(this.crtApt_Click);
            // 
            // viewApt
            // 
            this.viewApt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewApt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewApt.Location = new System.Drawing.Point(90, 271);
            this.viewApt.MaximumSize = new System.Drawing.Size(250, 70);
            this.viewApt.MinimumSize = new System.Drawing.Size(250, 70);
            this.viewApt.Name = "viewApt";
            this.viewApt.Size = new System.Drawing.Size(250, 70);
            this.viewApt.TabIndex = 2;
            this.viewApt.Text = "View Apartments";
            this.viewApt.UseVisualStyleBackColor = true;
            this.viewApt.Click += new System.EventHandler(this.viewApt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 453);
            this.Controls.Add(this.viewApt);
            this.Controls.Add(this.crtApt);
            this.Controls.Add(this.title);
            this.MaximumSize = new System.Drawing.Size(450, 500);
            this.MinimumSize = new System.Drawing.Size(450, 500);
            this.Name = "Form1";
            this.Text = "Tobi\'s Apartment Builder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button crtApt;
        private System.Windows.Forms.Button viewApt;
    }
}

