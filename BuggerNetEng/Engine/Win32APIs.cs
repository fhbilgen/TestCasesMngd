using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BuggerNetEng.Engine
{
    public class Win32APIs
    {

        [DllImport("kernel32.dll")]
        public static extern Int32 GetCurrentThreadId();
    }
}
