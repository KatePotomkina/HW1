using System;

namespace HW1
{
    public abstract class TheCartoonShrek
    {
        public virtual string Name { get; set; }
        public virtual void SayHi()
        {
            Console.WriteLine($"Hi,I'm{Name}");
        }
        public virtual void Marry(string Name)
        {
            Console.WriteLine($"{Name},Congratulation! this is your Wedding day  !");
        }
        public static void Print() => Console.WriteLine("Wow!");
    }
}
