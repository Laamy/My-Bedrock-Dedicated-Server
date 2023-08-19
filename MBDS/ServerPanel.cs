using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace MBDS
{
    public partial class ServerPanel : Form
    {
        public ServerPanel()
        {
            InitializeComponent();

            // avoid tearing by using an invisible buffer then switching buffers really quickly
            this.DoubleBuffered = true;

            ServerBridge.onMessage += onMessage;
        }

        // BDS sends json packets which get recived here
        private void OnJsonPacket(dynamic packet)
        {
            // process packet from BDS here
            
            switch (packet["type"])
            {
                case "WriteAllText":
                    File.WriteAllText("Workspace\\" + packet["path"], packet["contents"]);
                    break;
                case "CreateDirectory":
                    Directory.CreateDirectory("Workspace\\" + packet["path"]);
                    break;
                case "ExecuteCommand":
                    ServerBridge.ExecuteCommand(packet["command"]);
                    break;
            }
        }

        // remove server formatting so it doesnt show weird fucked up characters cuz NIGGERS !
        private void onMessage(object sener, DataReceivedEventArgs e)
        {
            if (e.Data.Length < 1)
                return; // skip empty data packets

            int state = 0;
            string backOutputBuffer = "";
            foreach (char c in e.Data.Replace("\r", "").Replace("\n", ""))
            {
                if (c == 0x252C)
                {
                    state = 1;
                    continue;
                }

                switch (state)
                {
                    case 1:
                        state = 2;
                        continue;

                    case 2:

                        state = 0;
                        continue;
                }

                ConsoleOutput.Invoke((MethodInvoker)delegate {
                    backOutputBuffer += c;
                });
            }

            ConsoleOutput.Invoke((MethodInvoker)delegate {
                if (backOutputBuffer == "Quit correctly")
                {
                    ConsoleOutput.Clear();
                    return;
                }

                {
                    string pattern = @"\[[^\]]+\sINFO\]\s\[Scripting\]\s(.+)";
                    Match match = Regex.Match(backOutputBuffer, pattern);

                    if (match.Success)
                    {
                        string json = match.Groups[1].Value;

                        try
                        {
                            JavaScriptSerializer jss = new JavaScriptSerializer();

                            OnJsonPacket(jss.DeserializeObject(json));
                            return;
                        }
                        catch { }
                    }
                }

                ConsoleOutput.Text += backOutputBuffer + Environment.NewLine; // append it all at the same time after building it

                // select last charcter & then scroll down to it
                ConsoleOutput.SelectionStart = ConsoleOutput.Text.Length;
                ConsoleOutput.ScrollToCaret();
            });
        }

        // command the server start when the start button has been pressed
        private void BtnStart_Click(object sender, EventArgs e) => ServerBridge.Start();

        // command the server to stop when the stop button has been pressed
        private void BtnStop_Click(object sender, EventArgs e) => ServerBridge.ExecuteCommand("stop");

        // execute a server command when the send button has been pressed
        private void BtnSend_Click(object sender, EventArgs e) => ServerBridge.ExecuteCommand(ConsoleInput.Text);

        // command the server to stop when the form has been closed
        private void ServerPanel_FormClosing(object sender, FormClosingEventArgs e) => ServerBridge.ExecuteCommand("stop");
    }
}