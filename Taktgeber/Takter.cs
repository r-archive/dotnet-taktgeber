using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Taktgeber
{
    class Takter
    {
        static MainWindow fenster;
        static TimeSpan ts;
        Timer t = new Timer(new TimerCallback(tcb), fenster, 0, ts.Milliseconds);

        public Takter(MainWindow f)
        {
            fenster = f;
        }

        public void TaktAendern(TimeSpan newTimeSpan)
        {
            fenster.zaehler.Text = newTimeSpan.Milliseconds.ToString() + "ms";
            Debug.WriteLine($"Es wurden {newTimeSpan.Milliseconds}ms Abstand verarbeitet.");
        }

        static void tcb(object o)
        {
            
        }
    }
}
