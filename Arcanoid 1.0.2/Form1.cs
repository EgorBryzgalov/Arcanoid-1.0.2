using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arcanoid
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();                          
        }

        private int speed;
        bool LevelChosen = false;

        private Settings GetSettings()
        {
            Settings settings = new Settings(speed);
            return settings;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (LevelChosen == true)
            {
                Form2 GameForm = new Form2(GetSettings());
                GameForm.ShowDialog(this);
            }
            else { MessageBox.Show("Выберите уровень сложности!"); }
        }

        private void OnMidMode(object sender, EventArgs e)
        {
            LevelChosen = true;
            speed = 5;
        }

        private void OnHardMode(object sender, EventArgs e)
        {
            LevelChosen = true;
            speed = 7;
        }

        private void OnEasyMode(object sender, EventArgs e)
        {
            LevelChosen = true;
            speed = 3;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
