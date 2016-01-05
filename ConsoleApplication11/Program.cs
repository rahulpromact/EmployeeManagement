using ConsoleApplication11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication11
{
   
  


    class Program
    {




        static void Main(string[] args)
        {
            
            int noOfEntries, value,editOrKey,key,v,input;
            string z;
            Console.WriteLine("enter the no of entries you want to make");
            noOfEntries = Convert.ToInt32(Console.ReadLine());
           
            List<Hr> a1 = new List<Hr>();
            List<developer> a2 = new List<developer>();
            for (int i = 0; i < noOfEntries; i++)
            {
                Hr p = new Hr();
                developer e = new developer();
                
                Console.WriteLine("who are you");
                Console.WriteLine("if HR enter 1");
                Console.WriteLine("if developer enter 2");
                value = Convert.ToInt32(Console.ReadLine());
                switch (value)
                {
                    case 1:
                        p.register();
                        p.display();
                        a1.Add(p);
                        break;

                    case 2:

                        e.register();
                        e.display();
                        a2.Add(e);
                        break;
                }

               


               
                Console.WriteLine("do you want to edit any entry ");
                Console.WriteLine("if edit type 0 ");
                editOrKey = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter 1 if hr and 2 if developer");
                 key = Convert.ToInt32(Console.ReadLine());
                if (key == 1)
                {


                    if (editOrKey == 0)
                    {
                     
                        Console.WriteLine("how many entries do you want to change");
                        v = Convert.ToInt32(Console.ReadLine());
                        for (int y = 0; y < v; y++)
                        {
                           
                            Console.WriteLine("enter 1 to change id\tenter 2 to change name\tenter 3 to change street1\tenter 4 to change street2\tenter 5 to change area\tenter 6 to change city\tenter 7 to change pincode \tenter 8 to change email\tenter 9 to change contact no\tenter 10 to change link in url");
                            input = Convert.ToInt32(Console.ReadLine());
                          
                            switch (input)
                            {
                                case 1: Console.WriteLine("enter the new id no");
                                    z = Console.ReadLine();
                                    p.update(input, z);

                                    break;
                                case 2:
                                    Console.WriteLine("enter the new name");
                                    z = Console.ReadLine();
                                    p.update(input, z);
                                    break;
                                case 3: Console.WriteLine("enter the new street1");
                                    z = Console.ReadLine();
                                    p.update(input, z);
                                    break;
                                case 4: Console.WriteLine("enter the new street2");
                                    z = Console.ReadLine();
                                    p.update(input, z);
                                    break;
                                case 5: Console.WriteLine("enter the new area");
                                    z = Console.ReadLine();
                                    p.update(input, z);
                                    break;
                                case 6: Console.WriteLine("enter the new city");
                                    z = Console.ReadLine();
                                    p.update(input, z);
                                    break;
                                case 7: Console.WriteLine("enter the new pincode");
                                    z = Console.ReadLine();
                                    p.update(input, z);
                                    break;
                                case 8: Console.WriteLine("enter the new email");
                                    z = Console.ReadLine();
                                    p.update(input, z);

                                    break;
                                case 9: Console.WriteLine("enter the new contact no");
                                    z = Console.ReadLine();
                                    p.update(input, z);
                                    break;
                                case 10: Console.WriteLine("enter the new linked in url");
                                    z = Console.ReadLine();
                                    p.update(input, z);
                                    break;
                            }

                        }
                    }

                }

                else
                {
                    Console.WriteLine("do you want to edit any entry");
                    Console.WriteLine("if yes type 0");
                    editOrKey = Convert.ToInt32(Console.ReadLine());
                    if (editOrKey == 0)
                    {
                        
                        Console.WriteLine("how many entries do you want to change");
                        v = Convert.ToInt32(Console.ReadLine());
                        for (int y = v; y > 0; y--)
                        {
                            int x;
                            Console.WriteLine("enter 1 to change id\tenter 2 to change name\tenter 3 to change street1\tenter 4 to change street2\tenter 5 to change area\tenter 6 to change city\tenter 7 to change pincode \tenter 8 to change skypeadd\tenter 9 to change slackurl\tenter 10 to change facebook pages\tenter 11 to change twitter handler");
                            x = Convert.ToInt32(Console.ReadLine());
                            
                            switch (x)
                            {

                                case 1: Console.WriteLine("enter the new id no");
                                    z = Console.ReadLine();
                                    e.update(x, z);

                                    break;
                                case 2:
                                    Console.WriteLine("enter the new name");
                                    z = Console.ReadLine();
                                    e.update(x, z);
                                    break;
                                case 3: Console.WriteLine("enter the new street1");
                                    z = Console.ReadLine();
                                    e.update(x, z);
                                    break;
                                case 4: Console.WriteLine("enter the new street2");
                                    z = Console.ReadLine();
                                    e.update(x, z);
                                    break;
                                case 5: Console.WriteLine("enter the new area");
                                    z = Console.ReadLine();
                                    e.update(x, z);
                                    break;
                                case 6: Console.WriteLine("enter the new city");
                                    z = Console.ReadLine();
                                    e.update(x, z);
                                    break;
                                case 7: Console.WriteLine("enter the new pincode");
                                    z = Console.ReadLine();
                                    e.update(x, z);
                                    break;
                                case 8: Console.WriteLine("enter the new skypeadd");
                                    z = Console.ReadLine();
                                    e.update(x, z);

                                    break;
                                case 9: Console.WriteLine("enter the new slack url");
                                    z = Console.ReadLine();
                                    e.update(x, z);

                                    break;
                                case 10: Console.WriteLine("enter the new facebook pages");
                                    z = Console.ReadLine();
                                    e.update(x, z);

                                    break;
                                case 11: Console.WriteLine("enter the new twitter handler");
                                    z = Console.ReadLine();
                                    e.update(x, z);

                                    break;
                            }
                        }
                    }
                }
            }
            
                int a;
                Console.WriteLine("enter 1 if hr and enter 2 if developer to be searched");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    string w;
                    Console.WriteLine("enter the id no of the employee you want to search");
                    w = Console.ReadLine();
                    a1.OfType<Hr>();
                    foreach (Hr b in a1)
                    {
                        Console.WriteLine(a1.Count);
                        if (b.id == w)
                        {
                            Console.WriteLine(b.id);
                            Console.WriteLine(b.name);
                            Console.WriteLine(b.street1);
                            Console.WriteLine(b.street2);
                            Console.WriteLine(b.city);
                            Console.WriteLine(b.area);
                            Console.WriteLine(b.pincode);
                            Console.WriteLine(b.email);
                            Console.WriteLine(b.contactnumber);
                            Console.WriteLine(b.linkURL);


                            b.display();
                            Console.WriteLine("do you want to send message if yes type 1 else 2");
                            int c = Convert.ToInt32(Console.ReadLine());
                            if (c == 1)
                            {
                                Console.WriteLine("message has been sent to  " + b.contactnumber);
                            }
                        } Console.WriteLine();
                        Console.ReadKey();
                    }
                }

                else
                {
                    string w;
                    Console.WriteLine("enter the id no of the employee you want to search");
                    w = Console.ReadLine();
                    foreach (developer c in a2)
                    {

                        if (c.id == w)
                        {

                            c.display();
                        } Console.WriteLine();
                        Console.ReadKey();
                    }
                





                Console.ReadKey();
            }

        }



    }
}




