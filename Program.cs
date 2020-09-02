using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Mob
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobile ip = new Iphon9();
            ip.Os();
            ip.SendMessage();
            ip.WIFIConnection();
           
            Iphone i = new Iphon9();
            i.AppStore();
            WriteLine();
            Mobile x = new RedmiNote9S();
                x.Os();
            x.SendMessage();
            x.WIFIConnection();
            Xiaomi xi = new RedmiNote9S();
            xi.PlayMarket();
            WriteLine();
            Mobile n = new NokiaX6();       
            n.Os();
            n.SendMessage();
            n.WIFIConnection();
            Nokia no = new NokiaX6();
            no.NokiaLearn();


        }
    }
}
