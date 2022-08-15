using System;
using FontAwesome.Sharp;

namespace TPReminder.Forms
{
  partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.settingsButton = new FontAwesome.Sharp.IconButton();
            this.addTaskButton = new FontAwesome.Sharp.IconButton();
            this.allTpButton = new FontAwesome.Sharp.IconButton();
            this.mainMenuButton = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureTitle = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTitle)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.settingsButton);
            this.panelMenu.Controls.Add(this.addTaskButton);
            this.panelMenu.Controls.Add(this.allTpButton);
            this.panelMenu.Controls.Add(this.mainMenuButton);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 519);
            this.panelMenu.TabIndex = 0;
            // 
            // settingsButton
            // 
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.settingsButton.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.settingsButton.IconColor = System.Drawing.Color.White;
            this.settingsButton.IconSize = 40;
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Location = new System.Drawing.Point(0, 408);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Rotation = 0D;
            this.settingsButton.Size = new System.Drawing.Size(220, 100);
            this.settingsButton.TabIndex = 6;
            this.settingsButton.Text = "Configuración";
            this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // addTaskButton
            // 
            this.addTaskButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addTaskButton.FlatAppearance.BorderSize = 0;
            this.addTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTaskButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.addTaskButton.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTaskButton.ForeColor = System.Drawing.Color.White;
            this.addTaskButton.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            this.addTaskButton.IconColor = System.Drawing.Color.White;
            this.addTaskButton.IconSize = 40;
            this.addTaskButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addTaskButton.Location = new System.Drawing.Point(0, 308);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Rotation = 0D;
            this.addTaskButton.Size = new System.Drawing.Size(220, 100);
            this.addTaskButton.TabIndex = 5;
            this.addTaskButton.Text = "Crear tarea";
            this.addTaskButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // allTpButton
            // 
            this.allTpButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.allTpButton.FlatAppearance.BorderSize = 0;
            this.allTpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allTpButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.allTpButton.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allTpButton.ForeColor = System.Drawing.Color.White;
            this.allTpButton.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.allTpButton.IconColor = System.Drawing.Color.White;
            this.allTpButton.IconSize = 40;
            this.allTpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allTpButton.Location = new System.Drawing.Point(0, 208);
            this.allTpButton.Name = "allTpButton";
            this.allTpButton.Rotation = 0D;
            this.allTpButton.Size = new System.Drawing.Size(220, 100);
            this.allTpButton.TabIndex = 3;
            this.allTpButton.Text = "Todas tus tareas";
            this.allTpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.allTpButton.UseVisualStyleBackColor = true;
            this.allTpButton.Click += new System.EventHandler(this.allTpButton_Click);
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainMenuButton.FlatAppearance.BorderSize = 0;
            this.mainMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainMenuButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.mainMenuButton.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuButton.ForeColor = System.Drawing.Color.White;
            this.mainMenuButton.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.mainMenuButton.IconColor = System.Drawing.Color.White;
            this.mainMenuButton.IconSize = 40;
            this.mainMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainMenuButton.Location = new System.Drawing.Point(0, 108);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainMenuButton.Rotation = 0D;
            this.mainMenuButton.Size = new System.Drawing.Size(220, 100);
            this.mainMenuButton.TabIndex = 2;
            this.mainMenuButton.Text = "Inicio";
            this.mainMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogo.Controls.Add(this.pictureTitle);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 108);
            this.panelLogo.TabIndex = 1;
            // 
            // pictureTitle
            // 
            this.pictureTitle.Image = ((System.Drawing.Image)(resources.GetObject("pictureTitle.Image")));
            this.pictureTitle.Location = new System.Drawing.Point(12, 12);
            this.pictureTitle.Name = "pictureTitle";
            this.pictureTitle.Size = new System.Drawing.Size(190, 90);
            this.pictureTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTitle.TabIndex = 0;
            this.pictureTitle.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(784, 75);
            this.panelTitleBar.TabIndex = 1;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconSize = 34;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(25, 22);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(40, 34);
            this.iconCurrentChildForm.TabIndex = 1;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(83, 22);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(244, 31);
            this.lblTitleChildForm.TabIndex = 0;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 75);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(784, 444);
            this.panelDesktop.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1004, 519);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP Reminder";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTitle)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);
        }

        private FontAwesome.Sharp.IconButton addTaskButton;
        private FontAwesome.Sharp.IconButton allTpButton;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconButton mainMenuButton;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox pictureTitle;
        private FontAwesome.Sharp.IconButton settingsButton;

        #endregion
    }
}