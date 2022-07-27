using System;
using System.Collections;
using System.Collections.Generic;

namespace HW1
{
    class Program
    {
        public delegate void Message();
        public static void Main(string[] args)
        {
            Message wow = TheCartoonShrek.Print;
            List<string> characters = new List<string>();
            Console.WriteLine("Once upon a time there was a big green giant named Shrek in a fairy-tale state. He lived in proud solitude in the forest, in the swamp, which he considered his own. But one day, the evil shorty - Lord Farquad, the ruler of the magical kingdom, mercilessly drove all the fairy-tale inhabitants to Shrek's swamp ...");
            Console.WriteLine("Choose your character ?(1-4)");
            var Shrek = new Shrek();
            characters.Add(Shrek.Name);
            var Fiona = new PrincessFiona();
            characters.Add(Fiona.Name);
            var Lord = new Lord();
            characters.Add(Lord.Name);
            var Donkey = new Donkey();
            characters.Add(Donkey.Name);
            IEnumerator ShrekEnumerator = characters.GetEnumerator();
            while (ShrekEnumerator.MoveNext())
            {
                string item = Convert.ToString(ShrekEnumerator.Current);
                Console.WriteLine("☻" + item);
            }
            ShrekEnumerator.Reset();
            try
            {
                var i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Shrek.SayHi();
                        Shrek.MeetDonkey(Donkey);
                        Console.WriteLine("The Lord asks u  to save Princess Fiona! What is your answear?");
                        Console.WriteLine(" Choose: 0 - Yes,i wiil do it! \n  1 - No,Bye!");
                        var ShrekAnswear = Convert.ToInt32(Console.ReadLine());
                        if (ShrekAnswear == 0)
                        {
                            Shrek.Decision = true;
                            Shrek.ToSavePrincess(Fiona);
                            Shrek.Marry(Shrek.Name);
                            wow();
                        }
                        else
                        {
                            throw new IncorrectStoryExeption("Your swamp will be occupied! Please think again ");
                        }
                        break;
                    case 2:
                        Fiona.SayHi();
                        Console.WriteLine("The Lord proposes you to marry him. Do you agree?");
                        Console.WriteLine(" Choose: 0 - Yes,i do! \n  1 - Omg! no!");
                        var FionaAnswear = Convert.ToInt32(Console.ReadLine());
                        if (FionaAnswear == 0)
                        {
                            Fiona.Marry(Fiona.Name);
                            wow();
                        }
                        else
                        {
                            Fiona.Marry(Fiona.Name);
                            wow();
                        }
                        break;
                    case 3:
                        Lord.SayHi();
                        Console.WriteLine("Lord:Am I the  best int the World?");
                        Lord.ToAskMirror();
                        var MirorAnswear = Convert.ToInt32(Console.ReadLine());
                        if (MirorAnswear == 1)
                        {
                            Lord.AskForHelp(Shrek);
                            Shrek.ToSavePrincess(Fiona);
                            Lord.Marry(Lord.Name);
                            wow();
                        }
                        else
                        {
                            throw new IncorrectStoryExeption("You need to marry princess!");
                        }
                        break;
                    case 4:
                        Donkey.SayHi();
                        Donkey.ToBeFriend(Shrek);
                        Console.WriteLine("Do u want to help your friend?");
                        Console.WriteLine(" Choose: 0 - Yes,i do! \n  1 - Omg! no!");
                        var DonkeyAnswear = Convert.ToInt32(Console.ReadLine());
                        if (DonkeyAnswear == 0)
                        {
                            Donkey.ToSavePrincess(Fiona);
                            wow();
                        }
                        else
                        {
                            throw new IncorrectStoryExeption("You will be homeless again!");
                        }
                        break;
                    default:
                        Console.WriteLine("The End!");
                        wow();
                        break;
                }
            }
            catch (IncorrectStoryExeption ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a valid format. Please try again.");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Object reference not set to an instance of an object");
            }
        }
    }
}





