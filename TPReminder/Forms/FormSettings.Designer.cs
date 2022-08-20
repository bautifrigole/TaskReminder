using System.ComponentModel;

namespace TaskReminder.Forms
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.panelHome = new System.Windows.Forms.Panel();
            this.notificationsCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startupCheckBox = new System.Windows.Forms.CheckBox();
            this.lblHowToUse = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelHome.Controls.Add(this.notificationsCheckBox);
            this.panelHome.Controls.Add(this.label1);
            this.panelHome.Controls.Add(this.startupCheckBox);
            this.panelHome.Controls.Add(this.lblHowToUse);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.ForeColor = System.Drawing.Color.Black;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(682, 380);
            this.panelHome.TabIndex = 1;
            // 
            // notificationsCheckBox
            // 
            this.notificationsCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.notificationsCheckBox.Checked = true;
            this.notificationsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.notificationsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationsCheckBox.Location = new System.Drawing.Point(257, 103);
            this.notificationsCheckBox.Name = "notificationsCheckBox";
            this.notificationsCheckBox.Size = new System.Drawing.Size(30, 30);
            this.notificationsCheckBox.TabIndex = 6;
            this.notificationsCheckBox.UseVisualStyleBackColor = true;
            this.notificationsCheckBox.CheckedChanged += new System.EventHandler(this.notificationsCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Product Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 43);
            this.label1.TabIndex = 7;
            this.label1.Text = "Receive notifications";
            // 
            // startupCheckBox
            // 
            this.startupCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startupCheckBox.Checked = true;
            this.startupCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.startupCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startupCheckBox.Location = new System.Drawing.Point(257, 50);
            this.startupCheckBox.Name = "startupCheckBox";
            this.startupCheckBox.Size = new System.Drawing.Size(30, 30);
            this.startupCheckBox.TabIndex = 0;
            this.startupCheckBox.UseVisualStyleBackColor = true;
            this.startupCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblHowToUse
            // 
            this.lblHowToUse.BackColor = System.Drawing.Color.Transparent;
            this.lblHowToUse.Font = new System.Drawing.Font("Product Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHowToUse.ForeColor = System.Drawing.Color.White;
            this.lblHowToUse.Location = new System.Drawing.Point(21, 52);
            this.lblHowToUse.Name = "lblHowToUse";
            this.lblHowToUse.Size = new System.Drawing.Size(240, 43);
            this.lblHowToUse.TabIndex = 5;
            this.lblHowToUse.Text = "Set in windows startup";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Carpeta de tareas";
            this.folderBrowserDialog.Tag = "Carpeta de tareas";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 380);
            this.Controls.Add(this.panelHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.panelHome.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.CheckBox notificationsCheckBox;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label lblHowToUse;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.CheckBox startupCheckBox;

        #endregion
    }
}