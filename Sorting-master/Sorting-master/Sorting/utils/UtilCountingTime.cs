using System.Diagnostics;

namespace Sorting.utils
{
    class UtilCountingTime
    {
        Stopwatch stopwatch = new Stopwatch();

        public void Init()
        {
            stopwatch.Start();
        }

        public void Stop()
        {
            stopwatch.Stop();
        }


    }
}
