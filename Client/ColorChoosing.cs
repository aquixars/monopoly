using System;
using System.Windows.Forms;

namespace Client
{
    public partial class ColorChoosing : Form
    {
        public ColorChoosing()
        {
            Program.colorChoosing = this;
            InitializeComponent();
            tbColor.Text = "Not chosen";
            if (ConnectionOptions.NameRedIsTaken) chooseRedPlayerBtn.Enabled = false;
            if (ConnectionOptions.NameBlueIsTaken) chooseBluePlayerBtn.Enabled = false;
        }
        private void connect_button_Click(object sender, EventArgs e)
        {
            switch (tbColor.Text)
            {
                case "Red":
                    ConnectionOptions.PlayerName = "Red";
                    Close();
                    DialogResult = DialogResult.OK;
                    break;
                case "Blue":
                    ConnectionOptions.PlayerName = "Blue";
                    Close();
                    DialogResult = DialogResult.OK;
                    break;
                case "Not chosen":
                    MessageBox.Show("Choose color!");
                    break;
            }
        }
        private void returnBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void chooseRedPlayerBtn_Click(object sender, EventArgs e)
        {
            tbColor.Text = "Red";
        }
        private void chooseBluePlayerBtn_Click(object sender, EventArgs e)
        {
            tbColor.Text = "Blue";
        }
    }
}
