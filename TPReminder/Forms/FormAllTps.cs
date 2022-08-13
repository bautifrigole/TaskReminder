using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using TPReminder.Scripts.Controllers;
using TPReminder.Scripts.Domain;

namespace TPReminder.Forms
{
    public partial class FormAllTps : Form
    {
        private List<TaskBlock> _taskBlocks = new List<TaskBlock>();
        
        public FormAllTps()
        {
            InitializeComponent();
            UpdateTasksText();
        }

        public void UpdateTasksText()
        {
            if (ProgramController.GetTasks() == null) return;
            var tasksAmount = ProgramController.GetTasks().Count;

            if (tasksAmount > 1)
            {
                lblTpsToDoTitle.Text = "Los trabajos a realizar son los siguientes:";
            }
            else if (tasksAmount == 1)
            {
                lblTpsToDoTitle.Text = "El trabajo a realizar es el siguiente:";
            }
            else if (tasksAmount == 0)
            {
                lblTpsToDoTitle.Text = "¡No tienes ninguna tarea por entregar! ¡Puedes descansar!";
            }
            
            var count = 0;
            if (_taskBlocks.Count > 0)
                foreach (var block in _taskBlocks)
                {
                    block.panel.Dispose();
                }
            
            foreach (var task in ProgramController.GetTasks())
            {
                count++;
                var taskBlock = new TaskBlock(task, lblTpsToDo, count, this);
                _taskBlocks.Add(taskBlock);
            }
        }
    }
}