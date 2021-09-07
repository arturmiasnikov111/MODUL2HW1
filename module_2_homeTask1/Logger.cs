using System;
using System.IO;

namespace ch
{
    public sealed class Logger
    {
        private static readonly Logger _instance = new Logger();
        private readonly string _error = "[error]";
        private readonly string _info = "[info]";
        private readonly string _warning = "[warning]";

        static Logger()
        {
        }

        private Logger()
        {
            FilePath = "log.txt";
        }

        public string Text { get; set; }
        public string FilePath { get; }

        public string Error
        {
            get { return _error; }
        }

        public string Info
        {
            get { return _info; }
        }

        public string Warning
        {
            get { return _warning; }
        }

        public static Logger Instance
        {
            get { return _instance; }
        }

        public void WriteText(string writeLog)
        {
            Text += $"{DateTime.Now.ToString()} " + writeLog + "\n";
        }

        public void SaveToFile()
        {
            File.WriteAllText(FilePath, Text);
        }
    }
}