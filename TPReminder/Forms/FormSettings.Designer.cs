using System.ComponentModel;

namespace TPReminder.Forms
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblHowToUse = new System.Windows.Forms.Label();
            this.iconButtonBrowse = new FontAwesome.Sharp.IconButton();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (34)))), ((int) (((byte) (33)))), ((int) (((byte) (74)))));
            this.panelHome.Controls.Add(this.label1);
            this.panelHome.Controls.Add(this.lblHowToUse);
            this.panelHome.Controls.Add(this.iconButtonBrowse);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.ForeColor = System.Drawing.Color.Black;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(682, 380);
            this.panelHome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(621, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // lblHowToUse
            // 
            this.lblHowToUse.BackColor = System.Drawing.Color.Transparent;
            this.lblHowToUse.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblHowToUse.ForeColor = System.Drawing.Color.White;
            this.lblHowToUse.Location = new System.Drawing.Point(36, 78);
            this.lblHowToUse.Name = "lblHowToUse";
            this.lblHowToUse.Size = new System.Drawing.Size(701, 188);
            this.lblHowToUse.TabIndex = 5;
            this.lblHowToUse.Text = resources.GetString("lblHowToUse.Text");
            // 
            // iconButtonBrowse
            // 
            this.iconButtonBrowse.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (253)))), ((int) (((byte) (138)))), ((int) (((byte) (114)))));
            this.iconButtonBrowse.FlatAppearance.BorderSize = 0;
            this.iconButtonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonBrowse.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonBrowse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.iconButtonBrowse.ForeColor = System.Drawing.Color.Black;
            this.iconButtonBrowse.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonBrowse.IconColor = System.Drawing.Color.Black;
            this.iconButtonBrowse.IconSize = 16;
            this.iconButtonBrowse.Location = new System.Drawing.Point(254, 289);
            this.iconButtonBrowse.Name = "iconButtonBrowse";
            this.iconButtonBrowse.Rotation = 0D;
            this.iconButtonBrowse.Size = new System.Drawing.Size(143, 46);
            this.iconButtonBrowse.TabIndex = 3;
            this.iconButtonBrowse.Text = "Examinar carpeta de tareas";
            this.iconButtonBrowse.UseVisualStyleBackColor = false;
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
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.panelHome.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private FontAwesome.Sharp.IconButton iconButtonBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHowToUse;
        private System.Windows.Forms.Panel panelHome;

        #endregion
    }
}