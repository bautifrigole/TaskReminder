using System.ComponentModel;

namespace TPReminder.Forms
{
    partial class FormAllTps
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
            this.lblTpsToDo = new System.Windows.Forms.Label();
            this.lblTpsToDoTitle = new System.Windows.Forms.Label();
            this.panelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (34)))), ((int) (((byte) (33)))),
                ((int) (((byte) (74)))));
            this.panelHome.Controls.Add(this.lblTpsToDo);
            this.panelHome.Controls.Add(this.lblTpsToDoTitle);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.ForeColor = System.Drawing.Color.Black;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(810, 458);
            this.panelHome.TabIndex = 2;
            // 
            // lblTpsToDo
            // 
            this.lblTpsToDo.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTpsToDo.ForeColor = System.Drawing.Color.White;
            this.lblTpsToDo.Location = new System.Drawing.Point(44, 87);
            this.lblTpsToDo.Name = "lblTpsToDo";
            this.lblTpsToDo.Size = new System.Drawing.Size(750, 348);
            this.lblTpsToDo.TabIndex = 4;
            // 
            // lblTpsToDoTitle
            // 
            this.lblTpsToDoTitle.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTpsToDoTitle.ForeColor = System.Drawing.Color.White;
            this.lblTpsToDoTitle.Location = new System.Drawing.Point(44, 22);
            this.lblTpsToDoTitle.Name = "lblTpsToDoTitle";
            this.lblTpsToDoTitle.Size = new System.Drawing.Size(845, 31);
            this.lblTpsToDoTitle.TabIndex = 2;
            this.lblTpsToDoTitle.Text = "Los trabajos a realizar son los siguientes:";
            // 
            // FormAllTps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 458);
            this.Controls.Add(this.panelHome);
            this.Name = "FormAllTps";
            this.Text = "FormAllTps";
            this.panelHome.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label lblTpsToDo;
        private System.Windows.Forms.Label lblTpsToDoTitle;
    }
}