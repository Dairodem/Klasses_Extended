namespace Klasses_Extended
{
    partial class FormAddAttraction
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbColors = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numCap = new System.Windows.Forms.NumericUpDown();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.btnAddAttraction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Naam:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(80, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(158, 20);
            this.txtName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kleur:";
            // 
            // cbColors
            // 
            this.cbColors.FormattingEnabled = true;
            this.cbColors.Location = new System.Drawing.Point(80, 51);
            this.cbColors.Name = "cbColors";
            this.cbColors.Size = new System.Drawing.Size(158, 21);
            this.cbColors.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Min. leeftijd:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Max Capaciteit:";
            // 
            // numCap
            // 
            this.numCap.Location = new System.Drawing.Point(118, 129);
            this.numCap.Name = "numCap";
            this.numCap.Size = new System.Drawing.Size(120, 20);
            this.numCap.TabIndex = 12;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(118, 95);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(120, 20);
            this.numAge.TabIndex = 13;
            // 
            // btnAddAttraction
            // 
            this.btnAddAttraction.Location = new System.Drawing.Point(24, 169);
            this.btnAddAttraction.Name = "btnAddAttraction";
            this.btnAddAttraction.Size = new System.Drawing.Size(214, 23);
            this.btnAddAttraction.TabIndex = 14;
            this.btnAddAttraction.Text = "Toevoegen";
            this.btnAddAttraction.UseVisualStyleBackColor = true;
            // 
            // FormAddAttraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(263, 211);
            this.Controls.Add(this.btnAddAttraction);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.numCap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbColors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormAddAttraction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attractie Toevoegen";
            this.Load += new System.EventHandler(this.FormAddAttraction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbColors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown numCap;
        public System.Windows.Forms.NumericUpDown numAge;
        public System.Windows.Forms.Button btnAddAttraction;
    }
}