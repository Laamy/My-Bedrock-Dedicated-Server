using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

class PlayerEventArgs
{
    string nameTag;
    string xuid;
}

namespace MBDS
{
    class ServerBridge
    {
        public static bool IsRunning { get; private set; } = false;
        static Process process;
        static ProcessStartInfo processInfo;

        /// <summary>
        /// Event to be called when the server sends a message
        /// </summary>
        public static EventHandler<DataReceivedEventArgs> onMessage;

        /// <summary>
        /// Event to be called when the server sends an error
        /// </summary>
        public static EventHandler<DataReceivedEventArgs> onError;

        /// <summary>
        /// Event to be called when the server is ready to accept commands
        /// </summary>
        public static EventHandler onReady;

        /// <summary>
        /// Event to be called when the server exits
        /// </summary>
        public static EventHandler onExit;

        public static EventHandler<PlayerEventArgs> onConnect;

        /*
        
        [2023-08-11 18:05:11:868 INFO] Player connected: FootlongTrero, xuid: 2535434308339572
        [2023-08-11 18:05:14:664 INFO] Player Spawned: FootlongTrero xuid: 2535434308339572
        [2023-08-11 18:07:18:447 INFO] Player disconnected: FootlongTrero, xuid: 2535434308339572
         
         */

        /// <summary>
        /// Function to be called to start the server & connections
        /// </summary>
        public static void Start()
        {
            // on ready event
            IsRunning = false;
            onMessage += delegate (object s, DataReceivedEventArgs e)
            {
                if (!IsRunning)
                {
                    IsRunning = true;

                    if (onReady != null)
                        onReady(null, null);

                    ExecuteCommand("bedrock_server.exe");
                }
            };

            // actual server start
            Task.Factory.StartNew(delegate ()
            {
                processInfo = new ProcessStartInfo("cmd.exe", "bedrock_server.exe");
                processInfo.CreateNoWindow = true;
                processInfo.UseShellExecute = false;
                processInfo.RedirectStandardError = true;
                processInfo.RedirectStandardOutput = true;
                processInfo.RedirectStandardInput = true;
                using (process = new Process())
                {
                    process.StartInfo = processInfo;
                    process.OutputDataReceived += delegate (object s, DataReceivedEventArgs _e)
                    {
                        if (onMessage != null)
                            onMessage(s, _e);
                    };

                    process.ErrorDataReceived += delegate (object s, DataReceivedEventArgs _e)
                    {
                        if (onError != null)
                            onError(s, _e);
                    };

                    if (process.Start())
                    {
                        process.EnableRaisingEvents = true;
                        process.BeginOutputReadLine();
                        process.BeginErrorReadLine();
                        process.WaitForExit();

                        if (onExit != null)
                            onExit(null, null);

                        Thread.Sleep(100);
                        process = null;
                    }
                }
                process.Close();

                // gonna trigger a restart
                Start();
                return;
            });
        }

        /// <summary>
        /// Send a command to the server via standard input stream
        /// </summary>
        /// <param name="data">The command to send</param>
        public static void ExecuteCommand(string data)
        {
            if (process != null)
            {
                process.StandardInput.WriteLine(data);
            }
        }
    }
}