using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    public class ServerObject
    {
        private static TcpListener tcpListener;
        private readonly List<ClientObject> clients = new List<ClientObject>();
        protected internal void AddConnection(ClientObject clientObject)
        {
            clients.Add(clientObject);
        }
        protected internal void RemoveConnection(string id)
        {
            var client = clients.FirstOrDefault(c => c.Id == id);
            if (client != null) clients.Remove(client);
        }
        protected internal void Listen()
        {
            try
            {
                tcpListener = new TcpListener(IPAddress.Any, 8888);
                tcpListener.Start();
                Program.f.tbLog.Invoke((MethodInvoker)delegate
                {
                    Program.f.tbLog.Text += "[" + DateTime.Now + "] " 
                                            + "Waiting for players..." 
                                            + Environment.NewLine;
                });
                while (true)
                {
                    var tcpClient = tcpListener.AcceptTcpClient();
                    var clientObject = new ClientObject(tcpClient, this);
                    var clientThread = new Thread(clientObject.Process);
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                Program.f.tbLog.Invoke((MethodInvoker)delegate
                {
                    Program.f.tbLog.Text += "[" + DateTime.Now + "] " + 
                                            ex.Message + 
                                            Environment.NewLine;
                });
                CloseAndExit();
            }
        }
        protected internal void SendMessageToOpponentClient(string message, string id)
        {
            foreach (var t in clients.Where(t => t.Id != id))
                t.Stream.Write(Encoding.Unicode.GetBytes(message), 0, 
                    Encoding.Unicode.GetBytes(message).Length);
        }
        protected internal void SendMessageToSender(string message, string id)
        {
            foreach (var t in clients.Where(t => t.Id == id))
                t.Stream.Write(Encoding.Unicode.GetBytes(message), 0, 
                    Encoding.Unicode.GetBytes(message).Length);
        }
        protected internal void SendMessageToEveryone(string message, string id)
        {
            foreach (var t in clients.Where(t => t.Id != id))
                t.Stream.Write(Encoding.Unicode.GetBytes(message), 0, 
                    Encoding.Unicode.GetBytes(message).Length);
            foreach (var t in clients.Where(t => t.Id == id))
                t.Stream.Write(Encoding.Unicode.GetBytes(message), 0, 
                    Encoding.Unicode.GetBytes(message).Length);
        }
        protected internal void CloseAndExit()
        {
            tcpListener?.Stop();
            foreach (var t in clients) t.Close();
            Environment.Exit(0);
        }
    }
}