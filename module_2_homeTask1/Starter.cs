using System;

namespace ch
{
    public class Starter
    {
        public void Run()
        {
            Actions act = new Actions();
            Random rnd = new Random();
            var lg = Logger.Instance;

            for (int i = 0; i < 100; i++)
            {
                int rand_number = rnd.Next(1, 4);
                switch (rand_number)
                {
                    case 1:
                        act.StartMethod();
                        break;
                    case 2:
                        act.SkippedLogic();
                        break;
                    case 3:
                        Result r = act.BrokeLogic();
                        if (r.Status == false)
                        {
                            lg.WriteText($"{Logger.Instance.Error} Action failed by a reason: {r.Error}");
                            break;
                        }

                        break;
                }
            }

            lg.SaveToFile();
        }
    }
}