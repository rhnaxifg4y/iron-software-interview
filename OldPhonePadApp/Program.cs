using System;
using OldPhonePadApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Old Phone Pad Converter");
        Console.WriteLine("=======================");

        // Example from the prompt
        string input1 = "33#";
        string output1 = OldPhonePadConverter.OldPhonePad(input1);
        Console.WriteLine($"Input: \"{input1}\", Output: \"{output1}\"");

        string input2 = "227*#";
        string output2 = OldPhonePadConverter.OldPhonePad(input2);
        Console.WriteLine($"Input: \"{input2}\", Output: \"{output2}\"");

        string input3 = "4433555 555666#";
        string output3 = OldPhonePadConverter.OldPhonePad(input3);
        Console.WriteLine($"Input: \"{input3}\", Output: \"{output3}\"");

        string input4 = "8 88777444666*664#";
        string output4 = OldPhonePadConverter.OldPhonePad(input4);
        Console.WriteLine($"Input: \"{input4}\", Output: \"{output4}\"");

        string input5 = "222 2 22#";
        string output5 = OldPhonePadConverter.OldPhonePad(input5);
        Console.WriteLine($"Input: \"{input5}\", Output: \"{output5}\"");
    }
}
