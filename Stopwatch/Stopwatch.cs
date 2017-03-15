using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    class Stopwatch
    {
        private TimeSpan _startTime;
        private TimeSpan _stopTime;
        private TimeSpan _duration;
        private bool _on = false;
        public void Start()
        {
            if (_on) throw (new InvalidOperationException());
            else
            {
                this._startTime = DateTime.Now.TimeOfDay;
                _on = true;
            }             
        }
        public void Stop()
        {
            if (!_on) throw new InvalidOperationException();
            else
            {
                this._stopTime = DateTime.Now.TimeOfDay;
                _on = false;
            }
        }
        public TimeSpan Duration
        {
            get
            {   _duration = _stopTime - _startTime;
                return _duration;
            }
            private set{_duration = value;}
        }
    }
}
