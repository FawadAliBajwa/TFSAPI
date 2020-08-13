namespace TFSAPI
{
    partial class TFSAPI
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chkIterationPath = new System.Windows.Forms.CheckBox();
            this.lbliteration = new System.Windows.Forms.Label();
            this.txtiteration = new System.Windows.Forms.TextBox();
            this.lblassignedto = new System.Windows.Forms.Label();
            this.txtassignedTo = new System.Windows.Forms.TextBox();
            this.chkAssignedTo = new System.Windows.Forms.CheckBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rchtxtbox = new System.Windows.Forms.RichTextBox();
            this.chkrhtxtbox = new System.Windows.Forms.CheckBox();
            this.lblAreapath = new System.Windows.Forms.Label();
            this.txtarepath = new System.Windows.Forms.TextBox();
            this.chkareapath = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(124, 453);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(292, 48);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(124, 33);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(292, 20);
            this.txtPath.TabIndex = 1;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(12, 36);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(51, 13);
            this.lblPath.TabIndex = 2;
            this.lblPath.Text = "File Path:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 551);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Stopped";
            // 
            // chkIterationPath
            // 
            this.chkIterationPath.AutoSize = true;
            this.chkIterationPath.Location = new System.Drawing.Point(422, 70);
            this.chkIterationPath.Name = "chkIterationPath";
            this.chkIterationPath.Size = new System.Drawing.Size(151, 17);
            this.chkIterationPath.TabIndex = 4;
            this.chkIterationPath.Text = "Update Only Iteration Path";
            this.chkIterationPath.UseVisualStyleBackColor = true;
            // 
            // lbliteration
            // 
            this.lbliteration.AutoSize = true;
            this.lbliteration.Location = new System.Drawing.Point(12, 74);
            this.lbliteration.Name = "lbliteration";
            this.lbliteration.Size = new System.Drawing.Size(73, 13);
            this.lbliteration.TabIndex = 5;
            this.lbliteration.Text = "Iteration Path:";
            // 
            // txtiteration
            // 
            this.txtiteration.Location = new System.Drawing.Point(124, 67);
            this.txtiteration.Name = "txtiteration";
            this.txtiteration.Size = new System.Drawing.Size(292, 20);
            this.txtiteration.TabIndex = 6;
            // 
            // lblassignedto
            // 
            this.lblassignedto.AutoSize = true;
            this.lblassignedto.Location = new System.Drawing.Point(12, 138);
            this.lblassignedto.Name = "lblassignedto";
            this.lblassignedto.Size = new System.Drawing.Size(88, 13);
            this.lblassignedto.TabIndex = 7;
            this.lblassignedto.Text = "Set Assigned To:";
            // 
            // txtassignedTo
            // 
            this.txtassignedTo.Location = new System.Drawing.Point(124, 131);
            this.txtassignedTo.Name = "txtassignedTo";
            this.txtassignedTo.Size = new System.Drawing.Size(292, 20);
            this.txtassignedTo.TabIndex = 8;
            // 
            // chkAssignedTo
            // 
            this.chkAssignedTo.AutoSize = true;
            this.chkAssignedTo.Location = new System.Drawing.Point(422, 137);
            this.chkAssignedTo.Name = "chkAssignedTo";
            this.chkAssignedTo.Size = new System.Drawing.Size(147, 17);
            this.chkAssignedTo.TabIndex = 9;
            this.chkAssignedTo.Text = "Update Only Assigned To";
            this.chkAssignedTo.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 244);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(103, 13);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Append Description:";
            // 
            // rchtxtbox
            // 
            this.rchtxtbox.Location = new System.Drawing.Point(124, 241);
            this.rchtxtbox.Name = "rchtxtbox";
            this.rchtxtbox.Size = new System.Drawing.Size(292, 170);
            this.rchtxtbox.TabIndex = 11;
            this.rchtxtbox.Text = "";
            // 
            // chkrhtxtbox
            // 
            this.chkrhtxtbox.AutoSize = true;
            this.chkrhtxtbox.Location = new System.Drawing.Point(422, 244);
            this.chkrhtxtbox.Name = "chkrhtxtbox";
            this.chkrhtxtbox.Size = new System.Drawing.Size(143, 17);
            this.chkrhtxtbox.TabIndex = 12;
            this.chkrhtxtbox.Text = "Append Only Description";
            this.chkrhtxtbox.UseVisualStyleBackColor = true;
            // 
            // lblAreapath
            // 
            this.lblAreapath.AutoSize = true;
            this.lblAreapath.Location = new System.Drawing.Point(12, 189);
            this.lblAreapath.Name = "lblAreapath";
            this.lblAreapath.Size = new System.Drawing.Size(73, 13);
            this.lblAreapath.TabIndex = 13;
            this.lblAreapath.Text = "Set AreaPath:";
            // 
            // txtarepath
            // 
            this.txtarepath.Location = new System.Drawing.Point(124, 189);
            this.txtarepath.Name = "txtarepath";
            this.txtarepath.Size = new System.Drawing.Size(292, 20);
            this.txtarepath.TabIndex = 14;
            // 
            // chkareapath
            // 
            this.chkareapath.AutoSize = true;
            this.chkareapath.Location = new System.Drawing.Point(422, 188);
            this.chkareapath.Name = "chkareapath";
            this.chkareapath.Size = new System.Drawing.Size(132, 17);
            this.chkareapath.TabIndex = 15;
            this.chkareapath.Text = "Update Only AreaPath";
            this.chkareapath.UseVisualStyleBackColor = true;
            // 
            // TFSAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 590);
            this.Controls.Add(this.chkareapath);
            this.Controls.Add(this.txtarepath);
            this.Controls.Add(this.lblAreapath);
            this.Controls.Add(this.chkrhtxtbox);
            this.Controls.Add(this.rchtxtbox);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.chkAssignedTo);
            this.Controls.Add(this.txtassignedTo);
            this.Controls.Add(this.lblassignedto);
            this.Controls.Add(this.txtiteration);
            this.Controls.Add(this.lbliteration);
            this.Controls.Add(this.chkIterationPath);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnStart);
            this.Name = "TFSAPI";
            this.Text = "TFSAPI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chkIterationPath;
        private System.Windows.Forms.Label lbliteration;
        private System.Windows.Forms.TextBox txtiteration;
        private System.Windows.Forms.Label lblassignedto;
        private System.Windows.Forms.TextBox txtassignedTo;
        private System.Windows.Forms.CheckBox chkAssignedTo;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rchtxtbox;
        private System.Windows.Forms.CheckBox chkrhtxtbox;
        private System.Windows.Forms.Label lblAreapath;
        private System.Windows.Forms.TextBox txtarepath;
        private System.Windows.Forms.CheckBox chkareapath;
    }
}