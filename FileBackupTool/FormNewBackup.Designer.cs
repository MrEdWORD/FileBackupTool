﻿namespace FileBackupTool
{
    partial class FormNewBackup
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
            this.lblBackupFrom = new System.Windows.Forms.Label();
            this.lblBackupTo = new System.Windows.Forms.Label();
            this.txtBoxBackupFrom = new System.Windows.Forms.TextBox();
            this.txtBoxBackupTo = new System.Windows.Forms.TextBox();
            this.btnBackupFrom = new System.Windows.Forms.Button();
            this.btnBackupTo = new System.Windows.Forms.Button();
            this.btnStartBackup = new System.Windows.Forms.Button();
            this.lblFiles = new System.Windows.Forms.Label();
            this.radioButtonEverything = new System.Windows.Forms.RadioButton();
            this.radioButtonSelectFiles = new System.Windows.Forms.RadioButton();
            this.lblBackupFromValidate = new System.Windows.Forms.Label();
            this.lblBackupToValidate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBackupFrom
            // 
            this.lblBackupFrom.AutoSize = true;
            this.lblBackupFrom.Location = new System.Drawing.Point(11, 15);
            this.lblBackupFrom.Name = "lblBackupFrom";
            this.lblBackupFrom.Size = new System.Drawing.Size(70, 13);
            this.lblBackupFrom.TabIndex = 0;
            this.lblBackupFrom.Text = "Backup from:";
            // 
            // lblBackupTo
            // 
            this.lblBackupTo.AutoSize = true;
            this.lblBackupTo.Location = new System.Drawing.Point(22, 41);
            this.lblBackupTo.Name = "lblBackupTo";
            this.lblBackupTo.Size = new System.Drawing.Size(59, 13);
            this.lblBackupTo.TabIndex = 1;
            this.lblBackupTo.Text = "Backup to:";
            // 
            // txtBoxBackupFrom
            // 
            this.txtBoxBackupFrom.Location = new System.Drawing.Point(87, 12);
            this.txtBoxBackupFrom.Name = "txtBoxBackupFrom";
            this.txtBoxBackupFrom.Size = new System.Drawing.Size(185, 20);
            this.txtBoxBackupFrom.TabIndex = 2;
            // 
            // txtBoxBackupTo
            // 
            this.txtBoxBackupTo.Location = new System.Drawing.Point(87, 38);
            this.txtBoxBackupTo.Name = "txtBoxBackupTo";
            this.txtBoxBackupTo.Size = new System.Drawing.Size(185, 20);
            this.txtBoxBackupTo.TabIndex = 3;
            // 
            // btnBackupFrom
            // 
            this.btnBackupFrom.Location = new System.Drawing.Point(291, 10);
            this.btnBackupFrom.Name = "btnBackupFrom";
            this.btnBackupFrom.Size = new System.Drawing.Size(75, 23);
            this.btnBackupFrom.TabIndex = 4;
            this.btnBackupFrom.Text = "Browse...";
            this.btnBackupFrom.UseVisualStyleBackColor = true;
            // 
            // btnBackupTo
            // 
            this.btnBackupTo.Location = new System.Drawing.Point(291, 36);
            this.btnBackupTo.Name = "btnBackupTo";
            this.btnBackupTo.Size = new System.Drawing.Size(75, 23);
            this.btnBackupTo.TabIndex = 5;
            this.btnBackupTo.Text = "Browse...";
            this.btnBackupTo.UseVisualStyleBackColor = true;
            // 
            // btnStartBackup
            // 
            this.btnStartBackup.BackColor = System.Drawing.Color.Green;
            this.btnStartBackup.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnStartBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartBackup.ForeColor = System.Drawing.Color.White;
            this.btnStartBackup.Location = new System.Drawing.Point(291, 64);
            this.btnStartBackup.Name = "btnStartBackup";
            this.btnStartBackup.Size = new System.Drawing.Size(75, 23);
            this.btnStartBackup.TabIndex = 7;
            this.btnStartBackup.Text = "Backup!";
            this.btnStartBackup.UseVisualStyleBackColor = false;
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Location = new System.Drawing.Point(50, 64);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(31, 13);
            this.lblFiles.TabIndex = 11;
            this.lblFiles.Text = "Files:";
            // 
            // radioButtonEverything
            // 
            this.radioButtonEverything.AutoSize = true;
            this.radioButtonEverything.Location = new System.Drawing.Point(87, 64);
            this.radioButtonEverything.Name = "radioButtonEverything";
            this.radioButtonEverything.Size = new System.Drawing.Size(75, 17);
            this.radioButtonEverything.TabIndex = 12;
            this.radioButtonEverything.TabStop = true;
            this.radioButtonEverything.Text = "Everything";
            this.radioButtonEverything.UseVisualStyleBackColor = true;
            // 
            // radioButtonSelectFiles
            // 
            this.radioButtonSelectFiles.AutoSize = true;
            this.radioButtonSelectFiles.Location = new System.Drawing.Point(180, 64);
            this.radioButtonSelectFiles.Name = "radioButtonSelectFiles";
            this.radioButtonSelectFiles.Size = new System.Drawing.Size(79, 17);
            this.radioButtonSelectFiles.TabIndex = 13;
            this.radioButtonSelectFiles.TabStop = true;
            this.radioButtonSelectFiles.Text = "Select Files";
            this.radioButtonSelectFiles.UseVisualStyleBackColor = true;
            // 
            // lblBackupFromValidate
            // 
            this.lblBackupFromValidate.AutoSize = true;
            this.lblBackupFromValidate.Location = new System.Drawing.Point(274, 15);
            this.lblBackupFromValidate.Name = "lblBackupFromValidate";
            this.lblBackupFromValidate.Size = new System.Drawing.Size(0, 13);
            this.lblBackupFromValidate.TabIndex = 14;
            // 
            // lblBackupToValidate
            // 
            this.lblBackupToValidate.AutoSize = true;
            this.lblBackupToValidate.Location = new System.Drawing.Point(274, 41);
            this.lblBackupToValidate.Name = "lblBackupToValidate";
            this.lblBackupToValidate.Size = new System.Drawing.Size(0, 13);
            this.lblBackupToValidate.TabIndex = 15;
            // 
            // FormNewBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 105);
            this.Controls.Add(this.lblBackupToValidate);
            this.Controls.Add(this.lblBackupFromValidate);
            this.Controls.Add(this.radioButtonSelectFiles);
            this.Controls.Add(this.radioButtonEverything);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.btnStartBackup);
            this.Controls.Add(this.btnBackupTo);
            this.Controls.Add(this.btnBackupFrom);
            this.Controls.Add(this.txtBoxBackupTo);
            this.Controls.Add(this.txtBoxBackupFrom);
            this.Controls.Add(this.lblBackupTo);
            this.Controls.Add(this.lblBackupFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormNewBackup";
            this.Text = "New Backup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBackupFrom;
        private System.Windows.Forms.Label lblBackupTo;
        private System.Windows.Forms.TextBox txtBoxBackupFrom;
        private System.Windows.Forms.TextBox txtBoxBackupTo;
        private System.Windows.Forms.Button btnBackupFrom;
        private System.Windows.Forms.Button btnBackupTo;
        private System.Windows.Forms.Button btnStartBackup;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.RadioButton radioButtonEverything;
        private System.Windows.Forms.RadioButton radioButtonSelectFiles;
        private System.Windows.Forms.Label lblBackupFromValidate;
        private System.Windows.Forms.Label lblBackupToValidate;
    }
}

