using System;

namespace MaskSensitiveInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masking Sensitive Information");
            Console.WriteLine("Enter a secret...");
            var userSecret = Console.ReadLine();

            if (userSecret.Length > 4)
            {
                var charsNumToCover = userSecret.Length - 4;
                var maskedString = userSecret.Substring(charsNumToCover).PadLeft(charsNumToCover, '*');
                Console.WriteLine(maskedString);
            }
            else
            {
                Console.WriteLine(userSecret);
            }

            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
