using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBSGenerator
{
    class BBSGenerator
    {
        private long _p;
        private long _q;
        private long _n;
        private long _x;
        private long _x0;

        public BBSGenerator(long p, long q, long x)
        {
            if(p == 0 || q == 0)
            {
                throw new System.Exception();
            }
            if(p % 4 != 3 || q % 4 != 3)
            {
                throw new System.Exception();
            }

            this._p = p;
            this._q = q;
            this._x = x;
            this._n = p * q;
            this._x0 = (_x * _x) % _n;

            Console.WriteLine("Wartosc poczatkowa x0: " + _x0);
        }
        public long getRandomNumber()
        {
            long randNum = (_x0 * _x0) % _n;
            _x0 = randNum;
            return randNum;
        }
        public long getRandomBit()
        {
            return getRandomNumber() % 2;
        }
    }
}
