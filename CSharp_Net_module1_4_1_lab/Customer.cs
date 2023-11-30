using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_4_1_lab
{
    class Customer
    {

        string name;

        public void GotNewGoods(object obj, GoodsInfoEventArgs e)
        {
            Console.WriteLine($"{name} получил новый товар: {e.GoodsName}");
        }

        public Customer(string Name)
        {
            name = Name;
        }
        // 6) declare private field name


        // 7) declare constructor to initialize name


        // 8) declare method GotNewGoods with 2 parameters:
        // 1 - object type
        // 2 - GoodsInfoEventArgs type

    }
}
