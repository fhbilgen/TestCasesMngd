using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BuggerNetEng.Engine
{
    public enum ResourceDefinition
    {
        MIN = 20,
        MAX = 50
    }

    public class ResourcePool
    {
        public const int POOL_MIN_SIZE = 20;
        public const int POOL_MAX_SIZE = 50;
        public Thread m_thread;

        public static bool IsInitialized { get; set; }
        public static List<int> AvailableResources { get; set; }
        public ResourcePool()
        {
            AvailableResources = new List<int>();
        }

        public void Initialize()
        {
            IsInitialized = true;
        }

        public void StartPoolManagerFunc(int duration)
        {

            m_thread = new Thread(PoolManagerFunc);
            m_thread.Start(duration);

            //m_thread.Join();
        }

        public static void PoolManagerFunc(object duration)
        {
            int interval;
            interval = (int)duration;
            while (IsInitialized)
            {
                if (AvailableResources.Count <= POOL_MIN_SIZE)
                {
                    AvailableResources.Add(1);
                    Thread.Sleep(interval);
                }
            }
        }


    }
}
