namespace ch
{
    public class Actions
    {
        public Result StartMethod()
        {
            var lg = Logger.Instance;
            lg.Info($" : Start Method: {System.Reflection.MethodBase.GetCurrentMethod().Name} ");
            return new Result(true);
        }

        public Result SkippedLogic()
        {
            var lg = Logger.Instance;
            lg.Warning($" : Skipped logic in method:  {System.Reflection.MethodBase.GetCurrentMethod().Name} ");
            return new Result(true);
        }

        public Result BrokeLogic()
        {
            var lg = Logger.Instance;
            return new Result(false, "Error occured in class RESULT");
        }
    }
}