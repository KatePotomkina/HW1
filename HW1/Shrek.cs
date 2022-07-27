using System;
using System.Threading;


namespace HW1
{
    public class Shrek : TheCartoonShrek
    {
        public event EventHandler Foo = delegate { };
        public void OnFoo()
        {
            Volatile.Read(ref Foo).Invoke(this, EventArgs.Empty);
            Console.WriteLine("Wow, what's next?!!");
        }
        public static string Name => "Shrek";
        public void MeetDonkey(Donkey donkey)
        {
            Console.WriteLine("You and Donkey are the best friend!");
            OnFoo();
        }
        protected static bool decision;
        public static bool Decision
        {
            get { return decision; }
            set => value = decision;
        }
        public override void SayHi()
        {
            Console.WriteLine($"RRRRRRR, I'm ogre  {Name}");
        }
        public static void ToSavePrincess(PrincessFiona princess)
        {
            Console.WriteLine(" Srek:The Princess is saved!");

        }
        public override void Marry(string name)
        {
            Console.WriteLine($"{name},Live long and Happy!");
        }
    }
}
