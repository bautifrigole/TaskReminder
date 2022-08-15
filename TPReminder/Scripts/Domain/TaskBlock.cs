using System;
using System.Windows.Forms;
using FontAwesome.Sharp;
using TPReminder.Forms;
using TPReminder.Scripts.Controllers;

namespace TPReminder.Scripts.Domain
{
    public class TaskBlock
    {
        public Panel panel;
        
        private Task _task;
        private IconButton _deleteButton;
        private IconButton _editButton;

        public TaskBlock(Task task, Control parent, int id)
        {
            _task = task;
            panel = new Panel()
            {
                Location = new System.Drawing.Point(50, 68),
                Dock = DockStyle.Top,
                Name = "taskPanel"+id,
                Size = new System.Drawing.Size(500, 80),
                TabIndex = 6,
                Parent = parent
            };
            
            var label = new Label
            {
                Font = new System.Drawing.Font("Century Gothic", 14F, 
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0))),
                ForeColor = System.Drawing.Color.Transparent,
                Location = new System.Drawing.Point(38, 75),
                Dock = DockStyle.Top,
                AutoSize = true,
                Visible = true,
                Parent = panel,
                Name = "lblTask"+id,
                Size = new System.Drawing.Size(643, 72),
                TabIndex = 4,
                Text = task.GetTaskInfo()
            };;
            _deleteButton = new IconButton()
            {
                FlatStyle = FlatStyle.Flat,
                Flip = FlipOrientation.Normal,
                ForeColor = System.Drawing.Color.Transparent,
                IconChar = IconChar.Trash,
                FlatAppearance = { BorderSize = 0},
                IconColor = System.Drawing.Color.Gray,
                IconSize = 20,
                ImageAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Location = new System.Drawing.Point(300, 0),
                Name = "deleteTaskButton"+id,
                RightToLeft = RightToLeft.No,
                Rotation = 0D,
                Size = new System.Drawing.Size(20, 20),
                TabIndex = 2,
                UseVisualStyleBackColor = false,
                Parent = panel,
            };
            _deleteButton.Click += DeleteButtonHandler;
            _editButton = new IconButton()
            {
                FlatStyle = FlatStyle.Flat,
                Flip = FlipOrientation.Normal,
                ForeColor = System.Drawing.Color.Transparent,
                IconChar = IconChar.PencilAlt,
                FlatAppearance = { BorderSize = 0},
                IconColor = System.Drawing.Color.White,
                IconSize = 20,
                ImageAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Location = new System.Drawing.Point(300, 30),
                Name = "editTaskButton"+id,
                RightToLeft = RightToLeft.No,
                Rotation = 0D,
                Size = new System.Drawing.Size(20, 20),
                TabIndex = 2,
                UseVisualStyleBackColor = false,
                Parent = panel,
            };
            _editButton.Click += EditButtonHandler;
        }
        
        private void DeleteButtonHandler(object sender, EventArgs e)
        {
            ProgramController.DeleteTask(_task);
            ProgramController.FormAllTps.UpdateTasksText();
        }
        
        private void EditButtonHandler(object sender, EventArgs e)
        {
            var editForm = new FormEditTask(_task);
            editForm.Show();
        }
    }
}