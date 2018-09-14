namespace LessonForms
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
            this.cbxFarmers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxAnimals = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLegs = new System.Windows.Forms.TextBox();
            this.txtSpecies = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxFarmers
            // 
            this.cbxFarmers.FormattingEnabled = true;
            this.cbxFarmers.Location = new System.Drawing.Point(153, 74);
            this.cbxFarmers.Name = "cbxFarmers";
            this.cbxFarmers.Size = new System.Drawing.Size(169, 37);
            this.cbxFarmers.TabIndex = 0;
            this.cbxFarmers.SelectedIndexChanged += new System.EventHandler(this.cbxFarmers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Farmer";
            // 
            // lbxAnimals
            // 
            this.lbxAnimals.FormattingEnabled = true;
            this.lbxAnimals.ItemHeight = 29;
            this.lbxAnimals.Location = new System.Drawing.Point(470, 74);
            this.lbxAnimals.Name = "lbxAnimals";
            this.lbxAnimals.Size = new System.Drawing.Size(366, 294);
            this.lbxAnimals.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Animals";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Legs";
            // 
            // txtLegs
            // 
            this.txtLegs.Location = new System.Drawing.Point(202, 284);
            this.txtLegs.MaximumSize = new System.Drawing.Size(120, 35);
            this.txtLegs.MinimumSize = new System.Drawing.Size(120, 35);
            this.txtLegs.Name = "txtLegs";
            this.txtLegs.Size = new System.Drawing.Size(120, 34);
            this.txtLegs.TabIndex = 6;
            // 
            // txtSpecies
            // 
            this.txtSpecies.Location = new System.Drawing.Point(202, 232);
            this.txtSpecies.MaximumSize = new System.Drawing.Size(120, 35);
            this.txtSpecies.MinimumSize = new System.Drawing.Size(120, 35);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(120, 34);
            this.txtSpecies.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Species";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(72, 336);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(250, 55);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 453);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSpecies);
            this.Controls.Add(this.txtLegs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxAnimals);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxFarmers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(930, 500);
            this.MinimumSize = new System.Drawing.Size(930, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intro till Forms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxFarmers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxAnimals;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLegs;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmit;
    }
}

