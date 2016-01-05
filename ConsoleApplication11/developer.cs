using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    public class developer : Employee
    {
        public string id, name, street1, street2, city, area, pincode, skype, slack, face, twitter;

        public override void register()
        {


            Console.WriteLine("enter the id no");
            id = Console.ReadLine();

            Console.WriteLine("enter the name");
            name = Console.ReadLine();

            Console.WriteLine("enter the street1");
            street1 = Console.ReadLine();

            Console.WriteLine("enter the street2");
            street2 = Console.ReadLine();

            Console.WriteLine("enter the area");
            area = Console.ReadLine();

            Console.WriteLine("enter the city");
            city = Console.ReadLine();

            Console.WriteLine("enter the pincode");
            pincode = Console.ReadLine();

            Console.WriteLine("enter your skypeadd");
            skype = Console.ReadLine();

            Console.WriteLine("enter your slackURL");
            slack = Console.ReadLine();

            Console.WriteLine("enter your facebook_pages");
            face = Console.ReadLine();

            Console.WriteLine("enter your twitter_handle");
            twitter = Console.ReadLine();
        }
        public void display()
        {


            Console.WriteLine("id=" + id);
            Console.WriteLine("name=" + name);
            Console.WriteLine("street1=" + street1);
            Console.WriteLine("street2=" + street2);
            Console.WriteLine("area=" + area);
            Console.WriteLine("city=" + city);
            Console.WriteLine("pincode=" + pincode);
            Console.WriteLine("skypeadd=" + skype);
            Console.WriteLine("slackurl=" + slack);
            Console.WriteLine("facebook pages=" + face);
            Console.WriteLine("twitter handle=" + twitter);
        }
        public void update(int n, string v)
        {

            if (n == 1) { id = v; }
            if (n == 2) { name = v; }
            if (n == 3) { street1 = v; }
            if (n == 4) { street2 = v; }
            if (n == 5) { area = v; }
            if (n == 6) { city = v; }
            if (n == 7)
            {
                pincode = v;
                if (n == 8) { skype = v; }
                if (n == 9) { slack = v; }
                if (n == 10) { face = v; }
                if (n == 11) { twitter = v; }



            }
        }
    }
}


