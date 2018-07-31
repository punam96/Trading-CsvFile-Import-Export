namespace Revision90
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
            this.txtboxpath = new System.Windows.Forms.TextBox();
            this.browsebtn = new System.Windows.Forms.Button();
            this.calculatebtn = new System.Windows.Forms.Button();
            this.csvgenerator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxpath
            // 
            this.txtboxpath.Location = new System.Drawing.Point(97, 36);
            this.txtboxpath.Name = "txtboxpath";
            this.txtboxpath.Size = new System.Drawing.Size(893, 26);
            this.txtboxpath.TabIndex = 0;
            // 
            // browsebtn
            // 
            this.browsebtn.Location = new System.Drawing.Point(996, 30);
            this.browsebtn.Name = "browsebtn";
            this.browsebtn.Size = new System.Drawing.Size(100, 39);
            this.browsebtn.TabIndex = 1;
            this.browsebtn.Text = "Browse";
            this.browsebtn.UseVisualStyleBackColor = true;
            this.browsebtn.Click += new System.EventHandler(this.browsebtn_Click);
            // 
            // calculatebtn
            // 
            this.calculatebtn.Location = new System.Drawing.Point(443, 86);
            this.calculatebtn.Name = "calculatebtn";
            this.calculatebtn.Size = new System.Drawing.Size(312, 56);
            this.calculatebtn.TabIndex = 5;
            this.calculatebtn.Text = "Calculate";
            this.calculatebtn.UseVisualStyleBackColor = true;
            this.calculatebtn.Click += new System.EventHandler(this.calculatebtn_Click);
            // 
            // csvgenerator
            // 
            this.csvgenerator.Location = new System.Drawing.Point(430, 160);
            this.csvgenerator.Name = "csvgenerator";
            this.csvgenerator.Size = new System.Drawing.Size(344, 67);
            this.csvgenerator.TabIndex = 6;
            this.csvgenerator.Text = "Generate csv";
            this.csvgenerator.UseVisualStyleBackColor = true;
            this.csvgenerator.Click += new System.EventHandler(this.csvgenerator_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1360, 499);
            this.Controls.Add(this.csvgenerator);
            this.Controls.Add(this.calculatebtn);
            this.Controls.Add(this.browsebtn);
            this.Controls.Add(this.txtboxpath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxpath;
        private System.Windows.Forms.Button browsebtn;
        private System.Windows.Forms.Button calculatebtn;
        private System.Windows.Forms.Button csvgenerator;
    }
}

