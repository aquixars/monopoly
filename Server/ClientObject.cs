using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Server
{
    public class ClientObject
    {
        private readonly TcpClient Client;
        private readonly ServerObject server;
        private string userName;
        public ClientObject(TcpClient tcpClient, ServerObject serverObject)
        {
            Id = Guid.NewGuid().ToString();
            Client = tcpClient;
            server = serverObject;
            serverObject.AddConnection(this);
        }
        protected internal string Id { get; }
        protected internal NetworkStream Stream { get; private set; }
        public void Process()
        {
            try
            {
                Stream = Client.GetStream();
                while (true)
                {
                    var message = GetMessage();
                    switch (message)
                    {
                        case "Both players has connected":
                            {
                                server.SendMessageToEveryone(message, Id);
                                Program.f.tbLog.Invoke((MethodInvoker)delegate
                                {
                                    Program.f.tbLog.Text += "[" + DateTime.Now + "] " + message + Environment.NewLine;
                                });
                                break;
                            }
                        case "Red":
                            {
                                Taken.Red = true;
                                userName = message;
                                Program.f.tbLog.Invoke((MethodInvoker)delegate
                                {
                                    Program.f.tbLog.Text += "[" + DateTime.Now + "] " + userName + " has connected" + Environment.NewLine;
                                });
                                server.SendMessageToOpponentClient(userName + " has connected", Id);
                                break;
                            }
                        case "Blue":
                            {
                                Taken.Blue = true;
                                userName = message;
                                Program.f.tbLog.Invoke((MethodInvoker)delegate
                                {
                                    Program.f.tbLog.Text += "[" + DateTime.Now + "] " + userName + " has connected" + Environment.NewLine;
                                });
                                server.SendMessageToOpponentClient(userName + " has connected", Id);
                                break;
                            }
                        case "Someone has connected":
                            {
                                Program.f.tbLog.Invoke((MethodInvoker)delegate
                                {
                                    Program.f.tbLog.Text += "[" + DateTime.Now + "] " + message + Environment.NewLine;
                                });
                                if (Taken.Red) server.SendMessageToSender("Red pawn is already selected", Id);
                                if (Taken.Blue) server.SendMessageToSender("Blue pawn is already selected", Id);
                                break;
                            }
                        case "Red pawn is already selected":
                            {
                                server.SendMessageToOpponentClient(message, Id);
                                Program.f.tbLog.Invoke((MethodInvoker)delegate
                                {
                                    Program.f.tbLog.Text += "[" + DateTime.Now + "] " + message + Environment.NewLine;
                                });
                                break;
                            }
                        case "Blue pawn is already selected":
                            {
                                server.SendMessageToOpponentClient(message, Id);
                                Program.f.tbLog.Invoke((MethodInvoker)delegate
                                {
                                    Program.f.tbLog.Text += "[" + DateTime.Now + "] " + message + Environment.NewLine;
                                });
                                break;
                            }
                        case "Red has left" when userName is "Red":
                            {
                                Program.f.tbLog.Invoke((MethodInvoker)delegate
                                {
                                    Program.f.tbLog.Text += "[" + DateTime.Now + "] " + message + Environment.NewLine;
                                });
                                server.RemoveConnection(this.Id);
                                break;
                            }
                        case "Blue has left" when userName is "Blue":
                            {
                                Program.f.tbLog.Invoke((MethodInvoker)delegate
                                {
                                    Program.f.tbLog.Text += "[" + DateTime.Now + "] " + message + Environment.NewLine;
                                });
                                server.RemoveConnection(this.Id);
                                break;
                            }
                    }
                    if (message.Contains("Red player's turn results"))
                    {
                        Program.f.tbLog.Invoke((MethodInvoker)delegate
                        {
                            Program.f.tbLog.Text += "[" + DateTime.Now + "] " + "Red player has finished his turn" + Environment.NewLine;
                            Program.f.tbLog.Text += "[" + DateTime.Now + "] " + "Blue player's turn" + Environment.NewLine;
                        });
                        server.SendMessageToOpponentClient(message, Id);
                    }
                    if (message.Contains("Blue player's turn results"))
                    {
                        Program.f.tbLog.Invoke((MethodInvoker)delegate
                        {
                            Program.f.tbLog.Text += "[" + DateTime.Now + "] " + "Blue player has finished his turn" + Environment.NewLine;
                            Program.f.tbLog.Text += "[" + DateTime.Now + "] " + "Red player's turn" + Environment.NewLine;
                        });
                        server.SendMessageToOpponentClient(message, Id);
                    }
                    if (message.Contains("Rent"))
                    {
                        Program.f.tbLog.Invoke((MethodInvoker)delegate
                        {
                            Program.f.tbLog.Text += "[" + DateTime.Now + "] " + message + Environment.NewLine;
                        });
                        server.SendMessageToOpponentClient(message, Id);
                    }
                }
            }
            catch (Exception e)
            {
                Program.f.tbLog.Invoke((MethodInvoker)delegate
                {
                    Program.f.tbLog.Text += "[" + DateTime.Now + "] " + e.Message + Environment.NewLine;
                });
            }
        }
        private string GetMessage()
        {
            var data = new byte[256];
            var builder = new StringBuilder();
            do
            {
                builder.Append(Encoding.Unicode.GetString(data, 0,
                    Stream.Read(data, 0, data.Length)));
            } while (Stream.DataAvailable);
            return builder.ToString();
        }
        protected internal void Close()
        {
            Stream.Close();
            Client.Close();
        }
    }
}



