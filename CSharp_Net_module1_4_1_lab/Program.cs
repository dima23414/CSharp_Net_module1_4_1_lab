using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_4_1_lab
{
    class Program
    {
        static void Main(string[] args)
        {

            OnlineShop onlineShop = new OnlineShop();

            Customer customer1 = new Customer("Покупатель 1");
            Customer customer2 = new Customer("Покупатель 2");

            onlineShop.GoodsInfoEvent += customer1.GotNewGoods;
            onlineShop.GoodsInfoEvent += customer2.GotNewGoods;

            onlineShop.NewGoods("Новый товар");

            Console.ReadKey();


            // 9) declare object of OnlineShop 

            // 10) declare several objects of Customer

            // 11) subscribe method GotNewGoods() of every Customer instance 
            // to event NewGoodsInfo of object of OnlineShop

            // 12) invoke method NewGoods() of object of OnlineShop
            // discuss results

        }
    }
}
