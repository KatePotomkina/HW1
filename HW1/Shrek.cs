using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static HW1.TheCartoonShrek;


namespace HW1 
{
     public  class Shrek : TheCartoonShrek
    {
        public event EventHandler Foo = delegate { };


public void OnFoo()
        {
            // Foo will never be null
            Volatile.Read(ref Foo).Invoke(this, EventArgs.Empty);
            Console.WriteLine("Wow, what's next?!!");
        }

        public   static string Name => "Shrek";
       public  void MeetDonkey(Donkey donkey)
        {
            Console.WriteLine("You and Donkey are the best friend!");
            OnFoo();
         
                }
        protected static bool decision;
        public static  bool Decision
        {
            get { return decision; }
            set => value = decision;
        }

        public  override void SayHi()
        {
            Console.WriteLine($"RRRRRRR, I'm ogre  {Name}");
        }

         
        public static  void ToSavePrincess(PrincessFiona princess)
        {
                Console.WriteLine(" Srek:The Princess is saved!");
           
        }
        public override void Marry( string name)
        {
            Console.WriteLine($"{name},Live long and Happy!");
        }



    }
}
