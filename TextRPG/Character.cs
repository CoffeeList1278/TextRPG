using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    interface Character
    {
        string Name { get; }
        int Hp { get; }
        int Dmg { get; }

        void Meelee();
        void Ranged();
        void Block();

        void Equip(int plusDmg);
    }
}
