using System;
using System.Collections.Generic;
using System.Text;

namespace HW1
{
    public class PrincessFiona:TheCartoonShrek
    {
        public string Name => "Fiona";
        public   override  void SayHi()
        {
            Console.WriteLine($"Hi, I'm {Name}");
        }
        public override void Marry(string Name)
        {
            Console.WriteLine("You marry Shrek!");  }


    }
}
