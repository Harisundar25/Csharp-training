namespace AsyncExample
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
            this.btnProcessfile = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProcessfile
            // 
            this.btnProcessfile.Location = new System.Drawing.Point(305, 68);
            this.btnProcessfile.Name = "btnProcessfile";
            this.btnProcessfile.Size = new System.Drawing.Size(123, 35);
            this.btnProcessfile.TabIndex = 0;
            this.btnProcessfile.Text = "Process";
            this.btnProcessfile.UseVisualStyleBackColor = true;
            this.btnProcessfile.Click += new System.EventHandler(this.btnProcessfile_Click);
            // 
            // lblCount
            // 
            this.lblCount.Location = new System.Drawing.Point(244, 109);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(251, 80);
            this.lblCount.TabIndex = 1;
            this.lblCount.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnProcessfile);
            this.Name = "Form1";
            this.Text = "Count Characters in a file";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProcessfile;
        internal System.Windows.Forms.Button lblCount;
    }
}

