using BuggerNetEng.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace BuggerNetEng.Engine
{
    public class MemEng
    {       
        
        [MethodImpl(MethodImplOptions.NoOptimization)]
        public static void NewObject()
        {
            TestObject tobj = new TestObject();
        }

    }
}
