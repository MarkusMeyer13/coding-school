using System;
using System.Collections.Generic;
using System.Text;

namespace oop_cars
{
    public class Engine
    {
        private int _ps;

        public int PS
        {
            get { return _ps; }
            set { _ps = value; }
        }
        private Engine() { }

        public Engine(int ps)
        {
            this._ps = ps;
        }

    }
}
