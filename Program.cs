using System;

class GenPassword
{
    public static void Main(String[] args)
    {
        Random rand = new Random();

        string Lowercase = "abcdefghijklmnopqrstuvwxyz";
        string Uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        int charsize = 3;
        string Number = "1234567890";
        string SpeChar = "!@#$%^&*()";
        int size = 1;
        string randpasss = "";
        
        for(int i = 0; i < charsize; i++)
        {
            int small = rand.Next(Lowercase.Length);
            int caps = rand.Next(Uppercase.Length);
            randpasss += Lowercase[small];
            randpasss += Uppercase[caps];

        }

        for(int i=0;i<size;i++)
        {
            
            int num =rand.Next(Number.Length);
            int spechar = rand.Next(SpeChar.Length);
            
            randpasss += Number[num];
            randpasss += SpeChar[spechar];

        }
        Console.WriteLine(randpasss);
    }
}