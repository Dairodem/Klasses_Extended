namespace Klasses_Extended
{
    partial class Oefening1
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
            this.gbPretpark = new System.Windows.Forms.GroupBox();
            this.gbWerknemers = new System.Windows.Forms.GroupBox();
            this.btnRemoveWerker = new System.Windows.Forms.Button();
            this.btnAddWerker = new System.Windows.Forms.Button();
            this.gbInfoWerker = new System.Windows.Forms.GroupBox();
            this.lblNameW = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lbWerknemers = new System.Windows.Forms.ListBox();
            this.gbAttracties = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAddAttractie = new System.Windows.Forms.Button();
            this.gbInfoAttractie = new System.Windows.Forms.GroupBox();
            this.lblMaxPers = new System.Windows.Forms.Label();
            this.lblMinAge = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblNameA = new System.Windows.Forms.Label();
            this.lbAttracties = new System.Windows.Forms.ListBox();
            this.gbPretpark.SuspendLayout();
            this.gbWerknemers.SuspendLayout();
            this.gbInfoWerker.SuspendLayout();
            this.gbAttracties.SuspendLayout();
            this.gbInfoAttractie.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPretpark
            // 
            this.gbPretpark.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gbPretpark.Controls.Add(this.gbWerknemers);
            this.gbPretpark.Controls.Add(this.gbAttracties);
            this.gbPretpark.Location = new System.Drawing.Point(12, 12);
            this.gbPretpark.Name = "gbPretpark";
            this.gbPretpark.Size = new System.Drawing.Size(426, 406);
            this.gbPretpark.TabIndex = 0;
            this.gbPretpark.TabStop = false;
            this.gbPretpark.Text = "pretParkName";
            // 
            // gbWerknemers
            // 
            this.gbWerknemers.BackColor = System.Drawing.Color.Ivory;
            this.gbWerknemers.Controls.Add(this.btnRemoveWerker);
            this.gbWerknemers.Controls.Add(this.btnAddWerker);
            this.gbWerknemers.Controls.Add(this.gbInfoWerker);
            this.gbWerknemers.Controls.Add(this.lbWerknemers);
            this.gbWerknemers.Location = new System.Drawing.Point(15, 36);
            this.gbWerknemers.Name = "gbWerknemers";
            this.gbWerknemers.Size = new System.Drawing.Size(160, 354);
            this.gbWerknemers.TabIndex = 0;
            this.gbWerknemers.TabStop = false;
            this.gbWerknemers.Text = "Werknemers";
            // 
            // btnRemoveWerker
            // 
            this.btnRemoveWerker.Location = new System.Drawing.Point(18, 265);
            this.btnRemoveWerker.Name = "btnRemoveWerker";
            this.btnRemoveWerker.Size = new System.Drawing.Size(120, 26);
            this.btnRemoveWerker.TabIndex = 3;
            this.btnRemoveWerker.Text = "Verwijderen";
            this.btnRemoveWerker.UseVisualStyleBackColor = true;
            this.btnRemoveWerker.Click += new System.EventHandler(this.btnRemoveWerker_Click);
            // 
            // btnAddWerker
            // 
            this.btnAddWerker.Location = new System.Drawing.Point(18, 322);
            this.btnAddWerker.Name = "btnAddWerker";
            this.btnAddWerker.Size = new System.Drawing.Size(120, 26);
            this.btnAddWerker.TabIndex = 2;
            this.btnAddWerker.Text = "Toevoegen...";
            this.btnAddWerker.UseVisualStyleBackColor = true;
            this.btnAddWerker.Click += new System.EventHandler(this.btnAddWerker_Click);
            // 
            // gbInfoWerker
            // 
            this.gbInfoWerker.Controls.Add(this.lblNameW);
            this.gbInfoWerker.Controls.Add(this.lblGender);
            this.gbInfoWerker.Controls.Add(this.lblBirthDate);
            this.gbInfoWerker.Location = new System.Drawing.Point(18, 159);
            this.gbInfoWerker.Name = "gbInfoWerker";
            this.gbInfoWerker.Size = new System.Drawing.Size(120, 100);
            this.gbInfoWerker.TabIndex = 1;
            this.gbInfoWerker.TabStop = false;
            this.gbInfoWerker.Text = "Info";
            // 
            // lblNameW
            // 
            this.lblNameW.AutoSize = true;
            this.lblNameW.Location = new System.Drawing.Point(6, 20);
            this.lblNameW.Name = "lblNameW";
            this.lblNameW.Size = new System.Drawing.Size(38, 13);
            this.lblNameW.TabIndex = 4;
            this.lblNameW.Text = "Naam:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(6, 80);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 13);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Geslacht:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(6, 40);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(66, 13);
            this.lblBirthDate.TabIndex = 5;
            this.lblBirthDate.Text = "Geboren op:";
            // 
            // lbWerknemers
            // 
            this.lbWerknemers.FormattingEnabled = true;
            this.lbWerknemers.Location = new System.Drawing.Point(18, 19);
            this.lbWerknemers.Name = "lbWerknemers";
            this.lbWerknemers.Size = new System.Drawing.Size(120, 134);
            this.lbWerknemers.TabIndex = 0;
            this.lbWerknemers.SelectedIndexChanged += new System.EventHandler(this.lbWerknemers_SelectedIndexChanged);
            // 
            // gbAttracties
            // 
            this.gbAttracties.BackColor = System.Drawing.Color.Azure;
            this.gbAttracties.Controls.Add(this.button4);
            this.gbAttracties.Controls.Add(this.btnAddAttractie);
            this.gbAttracties.Controls.Add(this.gbInfoAttractie);
            this.gbAttracties.Controls.Add(this.lbAttracties);
            this.gbAttracties.Location = new System.Drawing.Point(181, 36);
            this.gbAttracties.Name = "gbAttracties";
            this.gbAttracties.Size = new System.Drawing.Size(226, 354);
            this.gbAttracties.TabIndex = 3;
            this.gbAttracties.TabStop = false;
            this.gbAttracties.Text = "Attracties";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 265);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 26);
            this.button4.TabIndex = 6;
            this.button4.Text = "Verwijderen";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnAddAttractie
            // 
            this.btnAddAttractie.Location = new System.Drawing.Point(18, 322);
            this.btnAddAttractie.Name = "btnAddAttractie";
            this.btnAddAttractie.Size = new System.Drawing.Size(188, 26);
            this.btnAddAttractie.TabIndex = 2;
            this.btnAddAttractie.Text = "Toevoegen...";
            this.btnAddAttractie.UseVisualStyleBackColor = true;
            this.btnAddAttractie.Click += new System.EventHandler(this.btnAddAttractie_Click);
            // 
            // gbInfoAttractie
            // 
            this.gbInfoAttractie.Controls.Add(this.lblMaxPers);
            this.gbInfoAttractie.Controls.Add(this.lblMinAge);
            this.gbInfoAttractie.Controls.Add(this.lblColor);
            this.gbInfoAttractie.Controls.Add(this.lblNameA);
            this.gbInfoAttractie.Location = new System.Drawing.Point(18, 159);
            this.gbInfoAttractie.Name = "gbInfoAttractie";
            this.gbInfoAttractie.Size = new System.Drawing.Size(188, 100);
            this.gbInfoAttractie.TabIndex = 1;
            this.gbInfoAttractie.TabStop = false;
            this.gbInfoAttractie.Text = "Info";
            // 
            // lblMaxPers
            // 
            this.lblMaxPers.AutoSize = true;
            this.lblMaxPers.Location = new System.Drawing.Point(7, 80);
            this.lblMaxPers.Name = "lblMaxPers";
            this.lblMaxPers.Size = new System.Drawing.Size(63, 13);
            this.lblMaxPers.TabIndex = 3;
            this.lblMaxPers.Text = "Max. Pers. :";
            // 
            // lblMinAge
            // 
            this.lblMinAge.AutoSize = true;
            this.lblMinAge.Location = new System.Drawing.Point(7, 60);
            this.lblMinAge.Name = "lblMinAge";
            this.lblMinAge.Size = new System.Drawing.Size(63, 13);
            this.lblMinAge.TabIndex = 2;
            this.lblMinAge.Text = "Min. leeftijd:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(7, 40);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(37, 13);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "Kleur: ";
            // 
            // lblNameA
            // 
            this.lblNameA.AutoSize = true;
            this.lblNameA.Location = new System.Drawing.Point(7, 20);
            this.lblNameA.Name = "lblNameA";
            this.lblNameA.Size = new System.Drawing.Size(38, 13);
            this.lblNameA.TabIndex = 0;
            this.lblNameA.Text = "Naam:";
            // 
            // lbAttracties
            // 
            this.lbAttracties.FormattingEnabled = true;
            this.lbAttracties.Location = new System.Drawing.Point(18, 19);
            this.lbAttracties.Name = "lbAttracties";
            this.lbAttracties.Size = new System.Drawing.Size(188, 134);
            this.lbAttracties.TabIndex = 0;
            this.lbAttracties.SelectedIndexChanged += new System.EventHandler(this.lbAttracties_SelectedIndexChanged);
            // 
            // Oefening1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(450, 431);
            this.Controls.Add(this.gbPretpark);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Oefening1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oefening1";
            this.Load += new System.EventHandler(this.Oefening1_Load);
            this.gbPretpark.ResumeLayout(false);
            this.gbWerknemers.ResumeLayout(false);
            this.gbInfoWerker.ResumeLayout(false);
            this.gbInfoWerker.PerformLayout();
            this.gbAttracties.ResumeLayout(false);
            this.gbInfoAttractie.ResumeLayout(false);
            this.gbInfoAttractie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbWerknemers;
        private System.Windows.Forms.Button btnRemoveWerker;
        private System.Windows.Forms.Button btnAddWerker;
        private System.Windows.Forms.GroupBox gbInfoWerker;
        private System.Windows.Forms.ListBox lbWerknemers;
        private System.Windows.Forms.GroupBox gbAttracties;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAddAttractie;
        private System.Windows.Forms.GroupBox gbInfoAttractie;
        private System.Windows.Forms.ListBox lbAttracties;
        private System.Windows.Forms.Label lblMaxPers;
        private System.Windows.Forms.Label lblMinAge;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblNameA;
        private System.Windows.Forms.Label lblNameW;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.GroupBox gbPretpark;
    }
}