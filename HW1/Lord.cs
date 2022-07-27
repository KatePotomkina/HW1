using System;

namespace HW1
{
    public class Lord : TheCartoonShrek
    {
        public string Name => "The Lord";
        public override void SayHi()
        {
            Console.WriteLine($"Hehe! I'm {Name}");
        }
        public static void AskForHelp(Shrek shrek)
        {
            Console.WriteLine("Shrek, please  save Fiona! ");
        }
        public static void ToAskMirror()
        {
            Console.WriteLine(" Choose: 0 - Yes,you are! \n  1 - No!");
        }
    }
}
