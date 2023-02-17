using System;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    public partial class ServerForm : Form
    {
        private static ServerObject server;
        private static Thread listenThread;
        public ServerForm()
        {
            InitializeComponent();
            Program.f = this;
            Text = "Server. State: off";
            btnTurnOff.Text = "Close";
        }
        private void btnTurnOff_Click(object sender, EventArgs e)
        {
            switch (Text)
            {
                case "Server. State: off":
                    switch (MessageBox.Show("Close server form?", 
                                "Closing", MessageBoxButtons.YesNo))
                    {
                        case DialogResult.Yes:
                            Close();
                            break;
                        case DialogResult.No:
                            break;
                    }
                    break;
                case "Server. State: on":
                    switch (MessageBox.Show("Turn off the server?" + Environment.NewLine + "Current game will be closed.", 
                                "Turning off", MessageBoxButtons.YesNo))
                    {
                        case DialogResult.Yes:
                            server?.CloseAndExit();
                            break;
                        case DialogResult.No:
                            break;
                    }
                    break;
            }
        }
        private void btnTurnOn_Click(object sender, EventArgs e)
        {
            try
            {
                btnTurnOn.Enabled = false;
                btnTurnOff.Enabled = true;
                server = new ServerObject();
                listenThread = new Thread(server.Listen);
                listenThread.Start();
                Text = "Server. State: on";
                btnTurnOff.Text = "Turn off";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while turning the server on:" + ex.Message);
                server?.CloseAndExit();
            }
        }
    }
}