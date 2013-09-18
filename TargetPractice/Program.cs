using System;
using TargetPractice.Bubbles;
using TargetPractice.TargetBuilder;

namespace TargetPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets make some bubbles!\r\n");

            //TEMPLATE METHOD DESIGN PATTERN USAGE
            Console.WriteLine("These will be made using the Template Method");
            Console.WriteLine("----------------------------------------\r\n");
            BlueBubble BlueBubble = new BlueBubble();
            GreenBubble GreenBubble = new GreenBubble();
            RedBubble RedBubble = new RedBubble();

            //FACTORY METHOD DESIGN PATTERN USAGE
            Console.WriteLine("\r\nNow let's use the Factory Method!");
            Console.WriteLine("----------------------------------------\r\n");
            BubbleFactory BubblesInc = new BubbleFactory();
            BubblesInc.CreateBubble(1);
            BubblesInc.CreateBubble(2);
            BubblesInc.CreateBubble(3);


            //BUILDER DESIGN PATTERN
            Console.WriteLine("\r\nNow let's use the Builder Design Pattern!");
            Console.WriteLine("----------------------------------------\r\n");
            ObjectDirector ObjDirector = new ObjectDirector();
            ObjDirector.MakeBubble(1);      //red
            ObjDirector.MakeBubble(2);      //green
            ObjDirector.MakeBubble(3);      //blue

            ObjDirector.MakeStarburst(1);   //black
            ObjDirector.MakeStarburst(2);   //yellow

            Console.ReadKey();
        }
    }
}