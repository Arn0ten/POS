﻿namespace csPOS_System_Management
{
    partial class frmMemberships
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
            lblMemberships = new Label();
            SuspendLayout();
            // 
            // lblMemberships
            // 
            lblMemberships.AutoSize = true;
            lblMemberships.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMemberships.ForeColor = SystemColors.ActiveCaptionText;
            lblMemberships.Location = new Point(237, 190);
            lblMemberships.Name = "lblMemberships";
            lblMemberships.Size = new Size(369, 65);
            lblMemberships.TabIndex = 1;
            lblMemberships.Text = "MEMBERSHIPS";
            lblMemberships.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmMemberships
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMemberships);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMemberships";
            Text = "frmMemberships";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMemberships;
    }
}