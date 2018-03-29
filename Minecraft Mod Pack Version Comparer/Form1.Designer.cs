namespace Minecraft_MJRLegends_Version_Checker
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
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnOLDFolder = new System.Windows.Forms.Button();
            this.txtOLDFolder = new System.Windows.Forms.TextBox();
            this.txtNewFolder = new System.Windows.Forms.TextBox();
            this.btnNewFolder = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(8, 128);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(476, 427);
            this.txtOutput.TabIndex = 0;
            // 
            // btnOLDFolder
            // 
            this.btnOLDFolder.Location = new System.Drawing.Point(366, 7);
            this.btnOLDFolder.Name = "btnOLDFolder";
            this.btnOLDFolder.Size = new System.Drawing.Size(35, 24);
            this.btnOLDFolder.TabIndex = 1;
            this.btnOLDFolder.Text = "...";
            this.btnOLDFolder.UseVisualStyleBackColor = true;
            this.btnOLDFolder.Click += new System.EventHandler(this.btnOLDFolder_Click);
            // 
            // txtOLDFolder
            // 
            this.txtOLDFolder.Location = new System.Drawing.Point(115, 10);
            this.txtOLDFolder.Name = "txtOLDFolder";
            this.txtOLDFolder.ReadOnly = true;
            this.txtOLDFolder.Size = new System.Drawing.Size(245, 20);
            this.txtOLDFolder.TabIndex = 2;
            // 
            // txtNewFolder
            // 
            this.txtNewFolder.Location = new System.Drawing.Point(115, 47);
            this.txtNewFolder.Name = "txtNewFolder";
            this.txtNewFolder.ReadOnly = true;
            this.txtNewFolder.Size = new System.Drawing.Size(245, 20);
            this.txtNewFolder.TabIndex = 4;
            // 
            // btnNewFolder
            // 
            this.btnNewFolder.Location = new System.Drawing.Point(366, 44);
            this.btnNewFolder.Name = "btnNewFolder";
            this.btnNewFolder.Size = new System.Drawing.Size(35, 24);
            this.btnNewFolder.TabIndex = 3;
            this.btnNewFolder.Text = "...";
            this.btnNewFolder.UseVisualStyleBackColor = true;
            this.btnNewFolder.Click += new System.EventHandler(this.btnNewFolder_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(89, 74);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(312, 46);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Old:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "New:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 559);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtNewFolder);
            this.Controls.Add(this.btnNewFolder);
            this.Controls.Add(this.txtOLDFolder);
            this.Controls.Add(this.btnOLDFolder);
            this.Controls.Add(this.txtOutput);
            this.Name = "Form1";
            this.Text = "Minecraft Mod Pack Version Comparer v1.0.0 - By MJRLegends";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnOLDFolder;
        private System.Windows.Forms.TextBox txtOLDFolder;
        private System.Windows.Forms.TextBox txtNewFolder;
        private System.Windows.Forms.Button btnNewFolder;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

