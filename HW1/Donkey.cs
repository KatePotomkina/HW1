using System;

namespace HW1
{
    public class Donkey : TheCartoonShrek
    {
        public string Name => "Donkey";
        public override void SayHi()
        {
            Console.WriteLine($"hee-haw! I'm {Name}");
        }
        public void ToBeFriend(TheCartoonShrek paramA) => Console.WriteLine("You and Shrek are the bestie!");

        public static void ToSavePrincess(PrincessFiona princess)
        {
            Console.WriteLine(" Donkey:Dragon is my concern");
        }
    }
}



