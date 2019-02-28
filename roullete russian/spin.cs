using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roullete_russian
{
    class spin
    {
        public int load;
        public int shot = 0;
        public int spiner;

        public int spin_rnd(int Spin)//returns the vale of spin +1 if spin is equal to 6 then spin will be set to 1
        {

            Random rnd = new Random();
            Spin = rnd.Next(1, 7);

            return Spin;

        }
    }
}
