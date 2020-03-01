using System;
using System.Threading.Tasks;
using System.Threading;

namespace StaticMethods
{
    class Program : Animals
    {
        static async Task Main(string[] args)
        {
            UsefulTools.PrintName();
            UsefulTools usefulTools = new UsefulTools();
            usefulTools.Count = 68;
            Console.WriteLine(usefulTools.Count +" and Also " + usefulTools.AboutMe());

            Animals p = new Program();
            p.Teeth(34);
            //usefulTools.AboutMe();
            Console.WriteLine("Fetching Data");
            await Loading();
            Console.WriteLine("Done delaying");
        }
        public static async Task Loading()
        {
            Console.WriteLine("We are delaying 3 seconds");
            Thread.Sleep(3000);
        }
        public override void Teeth(int teeth)
        {
            teeth = 28;
            Console.WriteLine($"A dog has{teeth} teeth");
        }
    }
    abstract class Animals
    {

        public abstract void Teeth( int teeth);
    }
    class UsefulTools
    {
        public int age { get; set; }
        private int count { get; set; }

        public string year { get; set; }
        
        public int Count
        {
            get { return count; }
            set { count =56; }
        }
        public static void PrintName()
        {
            
            Console.WriteLine("Oliver Kipkemei");
        }
        public string AboutMe()
        {
            Console.WriteLine("I study Mechatronics Engineering ");
            return "School";
        }
    }
}
