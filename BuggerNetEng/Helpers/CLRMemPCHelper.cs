using BenchmarkDotNet.Toolchains.InProcess.NoEmit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuggerNetEng.Helpers
{
    public class CLRMemPCHelper
    {
        private readonly static int PCCount = 19;
        private readonly static string ProcName = Process.GetCurrentProcess().ProcessName;
        public readonly static string[] CounterNames =
        {
            "Private Bytes",
            "Working Set",
            "# Bytes in all Heaps",
            "# GC Handles",
            "# Gen 0 Collections",
            "# Gen 1 Collections",
            "# Gen 2 Collections",
            "# Induced GC",
            "# of Pinned Objects",
            "# Total committed Bytes",
            "% Time in GC",
            "Allocated Bytes/sec",
            "Finalization Survivors",
            "Gen 0 heap size",
            "Gen 0 Promoted Bytes/Sec",
            "Gen 1 heap size",
            "Gen 1 Promoted Bytes/Sec",
            "Gen 2 heap size",
            "Large Object Heap size"
        };

        private readonly static string[] PerfObjectNames =
        {
            "Process",
            ".NET CLR Memory"
        };
       

        private readonly PerformanceCounter[] Counters = new PerformanceCounter[PCCount];


        public CLRMemPCHelper()
        {
            //
            // Process Counters
            //

            for (int i = 0; i!= 2; i++)
                Counters[i] = new PerformanceCounter(categoryName: PerfObjectNames[0], counterName: CounterNames[i], instanceName: ProcName);

            //
            // CLR Memory Counters
            //

            for (int i=2; i != PCCount; i++)
                Counters[i] = new PerformanceCounter(categoryName: PerfObjectNames[1], counterName: CounterNames[i], instanceName: ProcName);

        }

        public string[] GetNextCounterValues()
        {
            string[] result = new string[PCCount];
            for(int i = 0; i != PCCount; i++)
                result[i] = Counters[i].NextValue().ToString("n");

            return result;
        }

    }
}
