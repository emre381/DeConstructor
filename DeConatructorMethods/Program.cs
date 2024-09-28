using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeConatructorMethods
{
     class Program
    {
        //class Human
        //{
        //    private  static int humanCount = 0;
        //    public int yas;
        //    public const double PI = 3.14;
        //    public Human()
        //    {
        //        humanCount ++;
        //    }
        //    public static int TellHumanCount()
        //    {
        //        return humanCount;
        //    }


        ////    string name;
        ////    int age;
        ////    public Human()
        ////    {
        ////        Console.WriteLine("new object create ");

        ////    }

        ////    ~Human() 
        ////    {
        ////        Console.WriteLine("obje yok oldu..");
        ////    }

        //    public void nameTell()
        //    {
        //        Console.WriteLine("Emre Çınar");
        //    }
          
          
           
        //}

        class Coordinate
        {
            public static int X {  get; set; }
            public static int Y { get; set; }
            static Coordinate() 
            {
            X = 10;
                Y = 20;
            }
        }
        
        static void Main(string[] args)
        {
            Coordinate coordinate = new Coordinate();
            Console.WriteLine(Coordinate.X+" "+Coordinate.Y);
            //Human human = new Human();
            //Human human2 = new Human();
            //Human human3 = new Human();
            //Human human4 = new Human();
            //Human human5 = new Human();
            //Human human6 = new Human();
            //human.yas = 23;
            //human2.yas = 45;
            //Console.WriteLine(human.yas+" "+human2.yas);
            //Console.WriteLine(Human.TellHumanCount());
            //Console.WriteLine(Human.PI);

            //CreatObject();
            //GC.Collect();
            Console.ReadLine();
              
            }
        //static void CreatObject()
        //{
        //    Human human = new Human();
        //    Human human1 = new Human();

        //}
    }
}
