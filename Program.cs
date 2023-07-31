using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_serv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Author of This Program is Muhammed Ahmed ");
            Console.WriteLine(" Developed By Shad Arf ");
            Console.WriteLine(" Supervisored By Sarhad beaz ");
            Console.WriteLine(" Soran Univirsty ");
            int Count = 0;
            string[] Avalible_Room = new string[10] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };            
            while (true)
            {
                try
                {

                
                
                Console.WriteLine("*******************************************************");
                Console.WriteLine("** Welcome to Handren Hotel * We are in your service **");
                Console.WriteLine("*******************************************************");                   
                Console.Write(" - Please tell us how many people you are : ");
                int Number_Of_Vsitor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Visitor_Name(Number_Of_Vsitor);
                int COUNT = Empity_Room(Avalible_Room, Count);
                service();
                (int Price , int Service) = ClassService();                
                Console.Write(" - Please tell us how many room you want : ");
                int Number_Room = Convert.ToInt32(Console.ReadLine());                
                while (Number_Room >= COUNT || Number_Room < 1)
                {

                    if (Number_Room > 10)
                    {
                        Console.WriteLine("Sorry We just have 10 rooms");
                    }
                    else if (Number_Room > COUNT)
                    {
                        Console.WriteLine($"Sorry You cant choose {Number_Room} , some of Our room isnt Avalabile ");
                    }
                    else
                    {
                        Console.WriteLine("you cant Enter This Numeber");
                    }
                    Console.Write(" Please Tell us again how many room you want : ");
                    Number_Room = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write(" - How many day and night you will stay in our hotel :");
                int Numebr_Night = Convert.ToInt32(Console.ReadLine());
                RoomOfHottel(Number_Room, Avalible_Room);
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                int Bag, Calling, Park, food;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("________________________________________________________________________");
                Console.WriteLine("_______  If you have a time,Please take a look for our services  _______");
                Console.WriteLine("________________________________________________________________________");
                Console.WriteLine("** The hotel services they are all free For VIP_Plus **");
                Console.WriteLine("* 1- We can bring your bag too your room : $5 ");
                Bag = 5;
                Bag = FreeVIP(Bag , Service);
                Console.WriteLine("* 2- Call Our service  $10 ");
                Calling = 10;
                Calling = FreeVIP( Calling , Service);
                Console.WriteLine("* 3- Parking Your car : 2$  ");
                Park = 2;
                Park = FreeVIP(Park, Service);
                Console.WriteLine("* 4- bring food too your room : $2 ");
                Console.WriteLine("________________________________________________________________________");
                food = 2;
                food = FreeVIP(food, Service);
                int Total = 0 + Price;
                int a = 0, b = 0, c = 0, d = 0;
                int TypeofService;                  
                    do
                    {
                    
                        Console.Write(" Which one of the services you want | press 0 Too Exit : ");
                        TypeofService = Convert.ToInt32(Console.ReadLine());
                        switch (TypeofService)
                        {
                            case 0:
                                break;
                            case int i when a == 0 && TypeofService ==1:
                                Console.WriteLine("We Will bring your bag too your room");
                                Total += Bag;
                                a = 1;
                                break;
                        case int i when b == 0 && TypeofService == 2:
                            Console.WriteLine(" Our service in On the way ");
                                Total += Calling;
                            b = 1;
                                break;
                        case int i when c == 0 && TypeofService == 3:
                            Console.WriteLine(" We will Park Your car");
                                Total += Park;
                            c = 1;
                                break;
                        case int i when d == 0 && TypeofService == 4:
                            Console.WriteLine("Your food in on the way too your room ");
                                Total += food;
                            d = 1;
                                break;
                            default:
                            Console.WriteLine(" Please try again you might be Orderd This Order Or we dont have this service");
                                break;
                        }
                        
                    } while (TypeofService != 0 );
                    
                
                Console.WriteLine("________________________________________________________");
                    Console.WriteLine($"The total price of the service that you chose is : ${Total * Number_Of_Vsitor * Numebr_Night * Number_Room}");
                    Console.WriteLine("________________________________________________________");
                    Console.WriteLine("press Any key too Enter New Visitor ");
                    Console.ReadKey();
                    Console.Clear();

                }
                catch 
                {
                    Console.WriteLine("OPS !! Some thing went Worng please Try again");

                }


            }
                   
        }       
        static string [] Visitor_Name(int NumberOfVisitor)
        {
            string [] Visitors = new string [NumberOfVisitor];
            for (int i = 0 ; i < Visitors.Length; i++)
            {
                Console.WriteLine($"Please Enter Name of {++i} Visior : ");
                Visitors[--i] = Console.ReadLine();
            }
            return Visitors;
        }
        static string[] RoomOfHottel(int Number_Room , string[] Room)
        {
            Console.WriteLine($"You Choose {Number_Room} Rooms ");
            Console.WriteLine("But please can you tell Us which Room do you Want ? ");
            Console.WriteLine("Our Hotel have 10 Rooms You can Chose 1 utill 10 :");
            int A = 0;
            string[] Rooms = new string[10] { " it is 2 people room ", "it is 4 people room", "it is 2 people room", "it is 4 people room", " it is 5 people room ", "it is 1 persion room", "it is 4 people room", "it is 1 people room", "it is 4 people room", "it is 3 people room" };
            
            while (A < Number_Room)
            {
                Console.Write("Enter Your Room : ");
                int i = Convert.ToInt32(Console.ReadLine());                                
                if (Room[--i] == "0")
                {
                    Console.WriteLine();
                    Console.WriteLine($"You Got Room Number {++i} {Rooms[--i]}");
                    Console.Write("Who is Enter this room ? ");
                    string Name = Console.ReadLine();
                    Room[i] = Name;
                    A++;
                }
                else
                {
                    Console.WriteLine("Please Enter Another room this room isnt Empty!! Sorry !!");
                }                               
            }            
            return Room;
        }
        static int Empity_Room(string [] Room , int Count)
        {
            
            for (int i = 0; i < Room.Length; i++)
            {
                if (Room[i] == "0")
                {
                    Count++;
                }
            }
            return Count;
        }
        static void service()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Which one of class service you want ?");
            Console.WriteLine("VIP_Plus class service is by 45$");
            Console.WriteLine(" - you have free Meals  ");
            Console.WriteLine(" - you have free Time for Liblary ");
            Console.WriteLine(" - you have free gym ");
            Console.WriteLine(" - You have free Wifi ");
            Console.WriteLine(" - You have free pool ");
            Console.WriteLine(" - You have free parking ");
            Console.WriteLine("VIP class service is by 30$");
            Console.WriteLine(" - you have free breakfast ");
            Console.WriteLine(" - you have free Time for Liblary ");
            Console.WriteLine(" - You have free Wifi ");
            Console.WriteLine("Normal class service in by 20$");
            Console.WriteLine(" - You just can sleep For 1 night and stay for a day");   

        }
        static (int , int) ClassService()
        {
            string Continue = "N";
            int Class = 0;
            int Price=0;
            do
            {

                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Choose one of the class services ");
                Console.Write("Enter 1 too VIP_plus room | Enter 2 too VIP Room | Enter 3 too Normal room : ");
                 Class = Convert.ToInt32(Console.ReadLine());
                if (Class == 1)
                {
                    Price = 45;
                    Console.WriteLine("So, You will Get free meals & 2 times for massage & 2 times for Gym , in a day.");
                    Console.WriteLine("Are you Sure ? ");
                    Console.WriteLine("( Answer by true or false )");
                    Console.Write("* ");
                    Console.WriteLine("Are you Sure ? Y / N");
                    Continue = Console.ReadLine();
                }
                else if (Class == 2)
                {
                    Price = 30;
                    Console.WriteLine("So, You will get 2 meals & 1 times for massaga & 2 time for Gym , in a day.");
                    Console.WriteLine("Are You Sure ?  ");
                    Console.WriteLine("( Answer by true or false )");
                    Console.Write("* ");
                    Console.WriteLine("Are you Sure ? Y / N");
                    Continue = Console.ReadLine();
                }
                else if (Class == 3)
                {
                    Price = 20;
                    Console.WriteLine("So, You will get 3 meals & 1 time for massaga & 1 time for Gym , in a day.");
                    Console.WriteLine("Is that true ? ");
                    Console.WriteLine("( Answer by true or false )");
                    Console.Write("* ");
                    Console.WriteLine("Are you Sure ? Y / N");
                    Continue = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Sorry we don't have this kind of service ");
                }
               

            } while (Continue == "N" || Continue == "n");
            return (Price , Class);
        }
        static int FreeVIP(int Free , int Service)
        {
            if (Service == 1)
            {
                Free = 0;
            }
            else
            {
                Free = 2;
            }
            return Free;
        }
    }
    
}
