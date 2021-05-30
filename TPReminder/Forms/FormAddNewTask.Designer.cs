using System;
using System.ComponentModel;

namespace TPReminder.Forms
{
    partial class FormAddNewTask
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
            this.panelHome = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHowToUse = new System.Windows.Forms.Label();
            this.iconButtonBrowse = new FontAwesome.Sharp.IconButton();
            this.panelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (34)))), ((int) (((byte) (33)))), ((int) (((byte) (74)))));
            this.panelHome.Controls.Add(this.dateTimePicker1);
            this.panelHome.Controls.Add(this.subjectTextBox);
            this.panelHome.Controls.Add(this.nameTextBox);
            this.panelHome.Controls.Add(this.label3);
            this.panelHome.Controls.Add(this.label2);
            this.panelHome.Controls.Add(this.label1);
            this.panelHome.Controls.Add(this.lblHowToUse);
            this.panelHome.Controls.Add(this.iconButtonBrowse);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.ForeColor = System.Drawing.Color.Black;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(800, 450);
            this.panelHome.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(278, 225);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 27);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.subjectTextBox.Location = new System.Drawing.Point(169, 153);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(179, 27);
            this.subjectTextBox.TabIndex = 11;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.nameTextBox.Location = new System.Drawing.Point(169, 77);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(179, 27);
            this.nameTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Materia:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha de entrega: ";
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
            this.label1.Text = "Crea una nueva tarea";
            // 
            // lblHowToUse
            // 
            this.lblHowToUse.BackColor = System.Drawing.Color.Transparent;
            this.lblHowToUse.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblHowToUse.ForeColor = System.Drawing.Color.White;
            this.lblHowToUse.Location = new System.Drawing.Point(36, 78);
            this.lblHowToUse.Name = "lblHowToUse";
            this.lblHowToUse.Size = new System.Drawing.Size(260, 33);
            this.lblHowToUse.TabIndex = 5;
            this.lblHowToUse.Text = "Nombre: ";
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
            this.iconButtonBrowse.Location = new System.Drawing.Point(56, 305);
            this.iconButtonBrowse.Name = "iconButtonBrowse";
            this.iconButtonBrowse.Rotation = 0D;
            this.iconButtonBrowse.Size = new System.Drawing.Size(143, 46);
            this.iconButtonBrowse.TabIndex = 3;
            this.iconButtonBrowse.Text = "Crear";
            this.iconButtonBrowse.UseVisualStyleBackColor = false;
            this.iconButtonBrowse.Click += new System.EventHandler(this.iconButtonBrowse_Click);
            // 
            // FormAddNewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelHome);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "FormAddNewTask";
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private FontAwesome.Sharp.IconButton iconButtonBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHowToUse;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.TextBox subjectTextBox;

        #endregion
    }
}