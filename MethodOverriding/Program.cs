using System;

namespace MethodOverridinng 
{  
    class baseClass  
    {  
        public virtual void Greetings()  
        {  
            Console.WriteLine("baseClass Saying Hello!");  
        }  
    }  
    class subClass : baseClass  
    {  
        public override void Greetings()  
        {  
            base.Greetings();  
            Console.WriteLine("subClass Saying Hello!");  
        }  
    }  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            baseClass daze = new subClass();  
            daze.Greetings();  
            Console.ReadLine();  
        }  
    }  
}  