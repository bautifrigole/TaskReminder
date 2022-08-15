using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;
using TPReminder.Scripts.Controllers;

namespace TPReminder.Forms
{
    public partial class MainForm : Form
    {
        private IconButton _currentBtn;
        private Panel _leftBorderBtn;
        private Form _currentChildForm;
        
        public MainForm()
        {
            InitializeComponent();

            _leftBorderBtn = new Panel {Size = new Size(7, 100)};
            panelMenu.Controls.Add(_leftBorderBtn);
            
            ActivateButton(mainMenuButton, RgbColors.color1);
            ProgramController.FormHome = new FormHome();
            OpenChildForm(ProgramController.FormHome);
        }

        public void GetPath()
        {
            ActivateButton(settingsButton, RgbColors.color3);
            ProgramController.FormSettings = new FormSettings();
            OpenChildForm(ProgramController.FormSettings);
        }

        private struct RgbColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        
        public void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                
                _currentBtn = (IconButton)senderBtn;
                _currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                _currentBtn.ForeColor = color;
                
                _currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                _currentBtn.IconColor = color;
                _currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                _currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                _leftBorderBtn.BackColor = color;
                _leftBorderBtn.Location = new Point(0, _currentBtn.Location.Y);
                _leftBorderBtn.Visible = true;
                _leftBorderBtn.BringToFront();

                iconCurrentChildForm.IconChar = _currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (_currentBtn != null)
            {
                _currentBtn.BackColor = Color.FromArgb(30, 31, 68);
                _currentBtn.ForeColor = Color.White;
                
                _currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                _currentBtn.IconColor = Color.White;
                _currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                _currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public void OpenChildForm(Form childForm)
        {
            if (_currentChildForm != null)
            {
                _currentChildForm.Close();
            }

            _currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = _currentBtn.Text;
        }

        private void Reset()
        {
            DisableButton();
            _leftBorderBtn.Visible = false;
            
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Inicio";
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RgbColors.color1);
            ProgramController.FormHome = new FormHome();
            OpenChildForm(ProgramController.FormHome);
        }

        private void allTpButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RgbColors.color2);
            ProgramController.FormAllTps = new FormAllTps();
            OpenChildForm(ProgramController.FormAllTps);
        }
        
        private void addTaskButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RgbColors.color3);
            ProgramController.FormAddNewTask = new FormAddNewTask();
            OpenChildForm(ProgramController.FormAddNewTask);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RgbColors.color4);
            ProgramController.FormSettings = new FormSettings();
            OpenChildForm(ProgramController.FormSettings);
        }
    }
}