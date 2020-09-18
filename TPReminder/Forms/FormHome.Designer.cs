using System.ComponentModel;

namespace TPReminder
{
    partial class FormHome
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
            this.lblNextTp = new System.Windows.Forms.Label();
            this.lblTpToDo = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (34)))), ((int) (((byte) (33)))),
                ((int) (((byte) (74)))));
            this.panelHome.Controls.Add(this.lblNextTp);
            this.panelHome.Controls.Add(this.lblTpToDo);
            this.panelHome.Controls.Add(this.lblWelcome);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.ForeColor = System.Drawing.Color.Black;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(815, 453);
            this.panelHome.TabIndex = 0;
            // 
            // lblNextTp
            // 
            this.lblNextTp.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblNextTp.ForeColor = System.Drawing.Color.White;
            this.lblNextTp.Location = new System.Drawing.Point(44, 223);
            this.lblNextTp.Name = "lblNextTp";
            this.lblNextTp.Size = new System.Drawing.Size(724, 193);
            this.lblNextTp.TabIndex = 4;
            this.lblNextTp.Text = "Faltan  días para entregar el trabajo: \n";
            // 
            // lblTpToDo
            // 
            this.lblTpToDo.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTpToDo.ForeColor = System.Drawing.Color.White;
            this.lblTpToDo.Location = new System.Drawing.Point(44, 121);
            this.lblTpToDo.Name = "lblTpToDo";
            this.lblTpToDo.Size = new System.Drawing.Size(617, 31);
            this.lblTpToDo.TabIndex = 3;
            this.lblTpToDo.Text = "Tienes  tareas por entregar";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(44, 22);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(599, 31);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Bienvenido,";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 453);
            this.Controls.Add(this.panelHome);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.panelHome.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblTpToDo;
        private System.Windows.Forms.Label lblNextTp;
    }
}