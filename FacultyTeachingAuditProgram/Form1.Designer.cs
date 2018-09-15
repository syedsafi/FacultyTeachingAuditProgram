namespace FacultyTeachingAuditProgram
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
            this.btnbrowse = new System.Windows.Forms.Button();
            this.txtbrowse = new System.Windows.Forms.TextBox();
            this.lblselectfile = new System.Windows.Forms.Label();
            this.lblnamedisplay = new System.Windows.Forms.Label();
            this.btnimport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(13, 73);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(75, 23);
            this.btnbrowse.TabIndex = 0;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click_1);
            // 
            // txtbrowse
            // 
            this.txtbrowse.Location = new System.Drawing.Point(94, 73);
            this.txtbrowse.Name = "txtbrowse";
            this.txtbrowse.Size = new System.Drawing.Size(252, 22);
            this.txtbrowse.TabIndex = 1;
            // 
            // lblselectfile
            // 
            this.lblselectfile.AutoSize = true;
            this.lblselectfile.Location = new System.Drawing.Point(104, 131);
            this.lblselectfile.Name = "lblselectfile";
            this.lblselectfile.Size = new System.Drawing.Size(182, 17);
            this.lblselectfile.TabIndex = 2;
            this.lblselectfile.Text = "Name Of The Selected file :";
            this.lblselectfile.Visible = false;
            // 
            // lblnamedisplay
            // 
            this.lblnamedisplay.AutoSize = true;
            this.lblnamedisplay.ForeColor = System.Drawing.Color.Red;
            this.lblnamedisplay.Location = new System.Drawing.Point(292, 131);
            this.lblnamedisplay.Name = "lblnamedisplay";
            this.lblnamedisplay.Size = new System.Drawing.Size(46, 17);
            this.lblnamedisplay.TabIndex = 3;
            this.lblnamedisplay.Text = "label2";
            this.lblnamedisplay.Visible = false;
            // 
            // btnimport
            // 
            this.btnimport.Location = new System.Drawing.Point(150, 164);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(136, 27);
            this.btnimport.TabIndex = 4;
            this.btnimport.Text = "Import";
            this.btnimport.UseVisualStyleBackColor = true;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 372);
            this.Controls.Add(this.btnimport);
            this.Controls.Add(this.lblnamedisplay);
            this.Controls.Add(this.lblselectfile);
            this.Controls.Add(this.txtbrowse);
            this.Controls.Add(this.btnbrowse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.TextBox txtbrowse;
        private System.Windows.Forms.Label lblselectfile;
        private System.Windows.Forms.Label lblnamedisplay;
        private System.Windows.Forms.Button btnimport;
    }
}

