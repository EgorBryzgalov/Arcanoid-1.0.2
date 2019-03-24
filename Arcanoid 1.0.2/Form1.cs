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
            EasyRadioButton.Checked = true;
        }

        private int speed;

        private Settings GetSettings()
        {
            Settings settings = new Settings(speed);
            return settings;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            
                Form2 GameForm = new Form2(GetSettings());
                GameForm.ShowDialog(this);
            
        }
                
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnLevelChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
           if (radioButton.Checked)
            {
                switch (radioButton.Text)
                {
                    case "Легко":
                        speed = 6;
                        break;
                    case "Средне":
                        speed = 10;
                        break;
                    case "Сложно":
                        speed = 14;
                        break;
                }
            }
        }

    }
}
