using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day19homework
{
    internal class Player
    {
        List<UsableItem> Inventory= new List<UsableItem>();
        List<Weapon> _weapons = new List<Weapon>();
        bool _isPay;
        public bool isPay
        {
            get { return _isPay; }
            set { _isPay = value; }
        }
        public void AddItem(UsableItem item)
        {
            if (_isPay)
            {
                Inventory.Add(item);
            }
            else
            {
                if (Inventory.Count >= 30)
                {
                    Console.WriteLine("인벤토리가 가득 찼습니다.");

                }
                else
                {
                    Inventory.Add(item);
                }
            }
        }
        public void AddItem(Weapon weapon)
        {
            if (_isPay)
            {
                _weapons.Add(weapon);
            }
            else
            {
                if (Inventory.Count >= 5)
                {
                    Console.WriteLine("무기가 가득 찼습니다.");

                }
                else
                {
                    _weapons.Add(weapon);
                }
            }
        }
        public void ShowInven()
        {
            for (int i = 0; i < Inventory.Count; i++) 
            {
                Console.WriteLine($"이름:\t{Inventory[i].Name}");
                Console.WriteLine($"가격:\t{Inventory[i].Price}");
                Console.WriteLine($"보유수량:\t{Inventory[i].Quantity}");
               
            }


        }
        public void UseMyItem()
        {
            Console.WriteLine("무기목록을 보려면 1번, 사용 가능 아이템 목록을 보려면 2번 기입");
            var keyInput = Console.ReadKey();
            if (keyInput.KeyChar == '1')
            {
                Console.WriteLine("무기 목록은 다음과 같습니다");
                for(int i = 0; i < _weapons.Count; i++)
                {
                    Console.WriteLine($"이름:\t{_weapons[i].Name}");
                    Console.WriteLine($"공격력:\t{_weapons[i].atk}");
                }

            }else if (keyInput.KeyChar == '2')
            {
                Console.WriteLine("사용가능 아이템 목록은 다음과 같습니다");
                for (int i = 0; i < Inventory.Count; i++)
                {
                    Console.WriteLine($"이름:\t{Inventory[i].Name}");
                    Console.WriteLine($"가격:\t{Inventory[i].Price}");
                    Console.WriteLine($"보유수량:\t{Inventory[i].Quantity}");

                }
            }



        }




    }//end
}
