using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSnake
{
    public class MSTimer
    {
        private int interval = 1000;
        private Action func = () => { };
        private Action<MSException> errorFunc = e => { };
        private bool paused = false;
        private bool inProgress = false;
        private int initialSleep = 0;

        private void call()
        {
            Thread.Sleep(initialSleep);

            while (inProgress)
            {
                if (!paused)
                {
                    try
                    {
                        func();
                    }
                    catch (MSException e)
                    {
                        paused = true;
                        errorFunc(e);
                    }

                    Thread.Sleep(interval);
                }
            }
        }

        public MSTimer()
        {
        }

        public MSTimer(Action f)
        {
            func = f;
        }

        public MSTimer(int i)
        {
            interval = i;
        }

        public MSTimer(Action f, int i)
        {
            func = f;
            interval = i;
        }

        public void setInterval(int i)
        {
            interval = i;
        }

        public void setFunction(Action f)
        {
            func = f;
        }

        public void setErrorFunction(Action<MSException> f)
        {
            errorFunc = f;
        }

        public int getInterval()
        {
            return interval;
        }

        public Action getFunction()
        {
            return func;
        }

        public Action<MSException> getErrorFunction()
        {
            return errorFunc;
        }

        public bool isInProgress()
        {
            return inProgress;
        }

        public bool isPaused()
        {
            return paused;
        }

        public void start(int s)
        {
            inProgress = true;
            initialSleep = s;

            Thread t = new Thread(call);
            t.Start();
        }

        public void stop()
        {
            inProgress = false;
        }

        public void pause()
        {
            paused = true;
        }

        public void resume()
        {
            paused = false;
        }
    }
}
