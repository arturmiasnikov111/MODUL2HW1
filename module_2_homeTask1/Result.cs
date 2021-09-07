using System;

namespace ch
{
    public class Result
    {
        private bool _status;
        private string _error;

        public Result(bool status)
        {
            _status = status;
        }

        public Result(bool status, string error)
        {
            _status = status;
            _error = error;
        }

        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public string Error
        {
            get { return _error; }
        }
    }
}