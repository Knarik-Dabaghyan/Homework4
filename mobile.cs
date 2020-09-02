using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mob
{
    public abstract class Mobile
    {
        public abstract void SendMessage();
        public abstract void WIFIConnection();
        public abstract void Os();
    }
        public abstract class Iphone : Mobile
     {
        public abstract void AppStore();
        public override void Os()
            {
                Console.WriteLine("IOS");
            }
        }

        public abstract class Xiaomi : Mobile
    { 
        public abstract void PlayMarket();
        
            public override void Os()
            {
                Console.WriteLine("Android");
            }
        }
        public abstract class Nokia : Mobile
    { 
        public abstract void NokiaLearn();
        
            public override void Os()
            {
                Console.WriteLine("Android");
            }
        }
        public class Iphon9 : Iphone
        {
            public override void SendMessage()
            {
                Console.WriteLine("Message sent from Iphon 9 ");
            }
        public override void AppStore()
        {
            Console.WriteLine("App Store for iphon 9 ");
        }
        public override void WIFIConnection()
            {
                Console.WriteLine("WIFI connected to Iphon 9");
            }
            
        }
        public class RedmiNote9S : Xiaomi
        {
        public override void PlayMarket()
        {
            Console.WriteLine("Play Market for Xiaomi ");
        }
        public override void SendMessage()
            {
                Console.WriteLine("Message sent from Redmi Note 9S ");

            }
            public override void WIFIConnection()
            {
                Console.WriteLine("WIFI connected to Redmi Note 9S");
            }
        }
        public class NokiaX6 : Nokia
    {
        public override void NokiaLearn()
        {
            Console.WriteLine(" Nokia Learn for Nokia X6");
        }
        public override void SendMessage()
            {
                Console.WriteLine("Message sent from  Nokia X6 ");
            }
             public override void WIFIConnection()
            {
                Console.WriteLine("WIFI connected to  Nokia X6 ");
            }

        }
    }
