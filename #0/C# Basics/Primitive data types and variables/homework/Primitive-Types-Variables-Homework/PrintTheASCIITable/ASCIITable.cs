using System;
using System.Text;

namespace PrintTheASCIITable
{
    class ASCIITable
    {
        static void Main()
        {
            Console.Write("Decimal".PadRight(10));
            Console.Write("ASCII".PadRight(10));
            Console.WriteLine("Hex".PadRight(10));
            Console.WriteLine();

            byte min = 0;
            byte max = 128;

            string display;
            char c;

            for (byte i = min; i < max; i++)
            {
                // Get ascii character.
                c = Encoding.ASCII.GetChars(new byte[] { i })[0];

                // Get display string.
                display = string.Empty;
                if (char.IsWhiteSpace(c))
                {
                    switch (c)
                    {
                        case '\t':
                            display = "\\t";
                            break;
                        case '\n':
                            display = "\\n";
                            break;
                        case ' ':
                            display = "\' \'";
                            break;
                        case '\r':
                            display = "\\r";
                            break;
                        case '\v':
                            display = "\\v";
                            break;
                        case '\f':
                            display = "\\f";
                            break;
                    }
                }
                else if (char.IsControl(c))
                {
                    display = "control";
                }
                else
                {
                    display = "\'" + c.ToString() + "\'";
                }
                // Write table row.
                Console.Write("{0}       ", i.ToString().PadLeft(3));
                Console.Write(display.PadRight(10));
                Console.WriteLine(i.ToString("X2"));
            }
        }
    }
}
