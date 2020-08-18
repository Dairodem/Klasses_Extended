namespace Klasses_Extended
{
    partial class FormAddWorker
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
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.calBirthDate = new System.Windows.Forms.MonthCalendar();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.Location = new System.Drawing.Point(18, 245);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(227, 23);
            this.btnAddWorker.TabIndex = 0;
            this.btnAddWorker.Text = "Toevoegen";
            this.btnAddWorker.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(87, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(158, 20);
            this.txtName.TabIndex = 1;
            // 
            // calBirthDate
            // 
            this.calBirthDate.Location = new System.Drawing.Point(18, 71);
            this.calBirthDate.Name = "calBirthDate";
            this.calBirthDate.TabIndex = 2;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(116, 38);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(129, 21);
            this.cbGender.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Naam:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(25, 46);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 13);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Geslacht:";
            // 
            // FormAddWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(267, 287);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.calBirthDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAddWorker);
            this.Name = "FormAddWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Werker Toevoegen";
            this.Load += new System.EventHandler(this.FormAddWorker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnAddWorker;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.MonthCalendar calBirthDate;
        public System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
    }
}