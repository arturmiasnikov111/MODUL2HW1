using System;
using System.IO;

namespace ch
{
    public sealed class Logger
    {
        private static readonly Logger _instance = new Logger();

        static Logger()
        {
        }

        private Logger()
        {
            FilePath = "log.txt";
        }

        public static Logger Instance
        {
            get { return _instance; }
        }

        public string Text { get; set; }
        public string FilePath { get; }

        public void Error(string message)
        {
            WriteText("[error] " + message);
        }

        public void Info(string message)
        {
            WriteText("[info] " + message);
        }

        public void Warning(string message)
        {
            WriteText("[warning] " + message);
        }

        public void WriteText(string writeLog)
        {
            Text += $"{DateTime.Now} " + writeLog + "\n";
        }

        public void SaveToFile()
        {
            File.WriteAllText(FilePath, Text);
        }
    }
}