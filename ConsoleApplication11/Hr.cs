using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    public class Hr : Employee
   {
      public string  id,name,street1,street2,city,area,pincode,email,contactNumber,linkURL;
    
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
           
           Console.WriteLine("enter your email");
           email = Console.ReadLine();
       
           Console.WriteLine("enter your contactno");
           contactNumber = Console.ReadLine();
        
            Console.WriteLine("enter your linkedinURL");
           linkURL = Console.ReadLine();

          
        }
             public void display()
       {
            Console.WriteLine("id="+id);
            Console.WriteLine("name="+name);
            Console.WriteLine("street1="+street1);
            Console.WriteLine("street2="+street2);
            Console.WriteLine("area="+area);
            Console.WriteLine("city="+city);
            Console.WriteLine("pincode="+pincode);
            Console.WriteLine("email="+email);
            Console.WriteLine("contact no="+contactNumber);
            Console.WriteLine("linked in URL="+linkURL);
        }
       public void update(int n,string v)
             {
                 if (n == 1) { id =v ;}
                 if (n == 2) {name = v; }
                 if (n == 3) {street1 = v; }
                 if (n == 4) { street2 = v; }
                 if (n == 5) { area = v; }
                 if (n == 6) { city = v; }
                 if (n == 7) { pincode = v; }
                 if (n == 8) { email = v; }
                 if (n == 9) { contactNumber = v; }
                 if (n == 10) {linkURL= v; }


             }

       }
    }

