using System;

namespace HW1
{
    public class IncorrectStoryExeption : Exception
    {
        public IncorrectStoryExeption()
        {
        }
        public IncorrectStoryExeption(string message) : base(message)
        {

        }
    }
}
