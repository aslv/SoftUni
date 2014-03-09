using System;

namespace PrintSequence
{
    class LongSequence
    {
        static void Main()
        {
            int firstMember = 2, memberCount = 1000;
            for (int i = firstMember, limit = -(firstMember + memberCount); i != limit && i != -limit; i += Math.Sign(i), i = -i)
            {
                Console.WriteLine(i);
            }
        }
    }
}
