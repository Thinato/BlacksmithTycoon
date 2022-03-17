using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacksmithSimulator
{
    public class Config 
    {
        // Make so the windows are dragable 
        private bool _DetachWindows;
        public bool DetachWindows { get { return _DetachWindows; } set { _DetachWindows = value; } }

        // Allow multiple windows to be opened (needs a list of already open windows)
        private bool _AllowMultipleWindows;
        public bool AllowMultipleWindows { get { return _AllowMultipleWindows; } set { _AllowMultipleWindows = value; } }



    }
}
