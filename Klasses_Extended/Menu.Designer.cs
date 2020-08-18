namespace Klasses_Extended
{
    partial class Menu
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
            this.btnOef1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOef2 = new System.Windows.Forms.Button();
            this.btnOef3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOef1
            // 
            this.btnOef1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOef1.Location = new System.Drawing.Point(19, 51);
            this.btnOef1.Name = "btnOef1";
            this.btnOef1.Size = new System.Drawing.Size(200, 60);
            this.btnOef1.TabIndex = 0;
            this.btnOef1.Text = "Oefening 1";
            this.btnOef1.UseVisualStyleBackColor = true;
            this.btnOef1.Click += new System.EventHandler(this.btnOef1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Klasses Extended";
            // 
            // btnOef2
            // 
            this.btnOef2.Location = new System.Drawing.Point(19, 126);
            this.btnOef2.Name = "btnOef2";
            this.btnOef2.Size = new System.Drawing.Size(200, 60);
            this.btnOef2.TabIndex = 2;
            this.btnOef2.Text = "Oefening 2";
            this.btnOef2.UseVisualStyleBackColor = true;
            this.btnOef2.Click += new System.EventHandler(this.btnOef2_Click);
            // 
            // btnOef3
            // 
            this.btnOef3.Location = new System.Drawing.Point(19, 202);
            this.btnOef3.Name = "btnOef3";
            this.btnOef3.Size = new System.Drawing.Size(200, 60);
            this.btnOef3.TabIndex = 3;
            this.btnOef3.Text = "Oefening 3";
            this.btnOef3.UseVisualStyleBackColor = true;
            this.btnOef3.Click += new System.EventHandler(this.btnOef3_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(243, 280);
            this.Controls.Add(this.btnOef3);
            this.Controls.Add(this.btnOef2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOef1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOef1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOef2;
        private System.Windows.Forms.Button btnOef3;
    }
}

