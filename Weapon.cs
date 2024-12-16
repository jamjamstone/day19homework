using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day19homework
{
    internal class Weapon
    {
        string _name;
        int _atk;
        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }
        
        public int atk
        {
            get { return _atk; }
            set { _atk = value; }
        }

        public void AtkWithWeapon()
        {
            Console.WriteLine($"{_name}으로 공격! {_atk}데미지!");
        }

    }
}
