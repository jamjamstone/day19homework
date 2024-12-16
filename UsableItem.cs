using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day19homework
{
    internal class UsableItem
    {
        string _name;
        int _price;
        int _quantity;
        public string Name
        {
            get { return _name; } set { _name = value; } 
        }
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public void ItemUse()
        {
            _quantity--;
            Console.WriteLine($"{_name}사용! 남은 수량{_quantity}");
        }


    }
}
