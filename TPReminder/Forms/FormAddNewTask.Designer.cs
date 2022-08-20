using System.ComponentModel;

namespace TaskReminder.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddNewTask));
            this.panelHome = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHowToUse = new System.Windows.Forms.Label();
            this.saveButton = new FontAwesome.Sharp.IconButton();
            this.panelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelHome.Controls.Add(this.dateTimePicker1);
            this.panelHome.Controls.Add(this.subjectTextBox);
            this.panelHome.Controls.Add(this.nameTextBox);
            this.panelHome.Controls.Add(this.label3);
            this.panelHome.Controls.Add(this.label2);
            this.panelHome.Controls.Add(this.label1);
            this.panelHome.Controls.Add(this.lblHowToUse);
            this.panelHome.Controls.Add(this.saveButton);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.ForeColor = System.Drawing.Color.Black;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(800, 450);
            this.panelHome.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Product Sans", 16F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(278, 225);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 33);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Font = new System.Drawing.Font("Product Sans", 16F);
            this.subjectTextBox.Location = new System.Drawing.Point(169, 153);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(179, 33);
            this.subjectTextBox.TabIndex = 11;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Product Sans", 16F);
            this.nameTextBox.Location = new System.Drawing.Point(169, 77);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(179, 33);
            this.nameTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Product Sans", 16F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Product Sans", 16F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Due date:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Product Sans", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(621, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add a new task";
            // 
            // lblHowToUse
            // 
            this.lblHowToUse.BackColor = System.Drawing.Color.Transparent;
            this.lblHowToUse.Font = new System.Drawing.Font("Product Sans", 16F);
            this.lblHowToUse.ForeColor = System.Drawing.Color.White;
            this.lblHowToUse.Location = new System.Drawing.Point(36, 78);
            this.lblHowToUse.Name = "lblHowToUse";
            this.lblHowToUse.Size = new System.Drawing.Size(260, 33);
            this.lblHowToUse.TabIndex = 5;
            this.lblHowToUse.Text = "Name:";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.saveButton.Font = new System.Drawing.Font("Product Sans", 16F);
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.saveButton.IconColor = System.Drawing.Color.Black;
            this.saveButton.IconSize = 16;
            this.saveButton.Location = new System.Drawing.Point(56, 305);
            this.saveButton.Name = "saveButton";
            this.saveButton.Rotation = 0D;
            this.saveButton.Size = new System.Drawing.Size(143, 46);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Add";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // FormAddNewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "FormAddNewTask";
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.ResumeLayout(false);
        }

        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public FontAwesome.Sharp.IconButton saveButton;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHowToUse;
        public System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Panel panelHome;
        public System.Windows.Forms.TextBox subjectTextBox;

        #endregion
    }
}