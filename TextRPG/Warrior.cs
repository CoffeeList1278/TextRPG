using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class Warrior : Character
    {
        public string Name { private set; get; }

        public int Hp { private set; get; }

        public int Dmg => throw new NotImplementedException();

        public void Block()
        {
            throw new NotImplementedException();
        }

        public void Equip(int plusDmg)
        {
            throw new NotImplementedException();
        }

        public void Meelee()
        {
            throw new NotImplementedException();
        }

        public void Ranged()
        {
            throw new NotImplementedException();
        }
    }
}
