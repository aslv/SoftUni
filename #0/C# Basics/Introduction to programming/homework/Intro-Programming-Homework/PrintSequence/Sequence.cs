using System;

namespace PrintSequence
{
    class Sequence
    {
        static void Main()
        {
            int firstMember = 2;
            for (int i = firstMember, limit = -(firstMember + 10); i != limit && i != -limit; i += Math.Sign(i), i = -i)
            {
                Console.WriteLine(i);
            }
        }
    }
}
