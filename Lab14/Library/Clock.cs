using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Library
{
    public class Clock: StillClock
    {
        private bool suspended;
        public Clock()
        {
            Thread setTime = new Thread(new ThreadStart(tikTak));
            setTime.Start();
            suspended = false;
        }

        public void tikTak()
        {
            while (true)
            {
                if (IsHandleCreated)
                {
                    setCurrentTime();
                    Refresh();
                    Thread.Sleep(1000);
                    lock (this)
                    {
                        while (this.suspended)
                        {
                            Monitor.Wait(this);
                        }}
                }
            }
        }

        public void Resume()
        {
            lock (this)
            {
                suspended = false;
                Monitor.Pulse(this);
            }
        }

        public void Suspend()
        {
            suspended = true;
        }
    }
}
