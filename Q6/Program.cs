using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines(@"dogOwners.txt");
        int amount = 0;

        foreach (string line in lines)
        {
            //Nellie Hopkins:[ZARAH:Blue,BEYLA:Yellow,MCLOVIN:Red,MAGIC:Blue,RYA JAYNE:Purple]


            //ZARAH:Blue,BEYLA:Yellow,MCLOVIN:Red,MAGIC:Blue,RYA JAYNE:Purple         and now values is the full list of dogs colour and name 
            string[] values = line.Split(new char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);

            ////ZARAH:Blue    BEYLA:Yellow  MCLOVIN:Red   MAGIC:Blue   RYA JAYNE:Purple 
            ///
            string[] dogColour = values[1].Split(new char[] { ',', ':' }, StringSplitOptions.RemoveEmptyEntries); //splitting the dog 

            int redCollarCount = 0;

            //Why are you going through the values array?
            //Values remains as: //ZARAH:Blue,BEYLA:Yellow,MCLOVIN:Red,MAGIC:Blue,RYA JAYNE:Purple
            //You need to get an array with just colours
            //Take the dogColour array and split by ':' (Put this in a new array or change the dogColour array to split by ',' and ':') This will leave an array containing: 'ZARAH' 'Blue' 'BEYLA' 'Yellow' 'MCLOVIN' 'Red' 'MAGIC' 'Blue' 'RYA JAYNE' 'Purple' 
            //Then loop through that array checking only the second options, which would be: 'Blue' 'Yellow' 'Red' 'Blue' 'Purple'
            for (int i = 1; i < dogColour.Length; i += 2)
            {
                string collarColor = dogColour[i].Trim();

                if (collarColor == "Red")
                {
                    redCollarCount++;
                }
            }

            if (redCollarCount >= 2)
            {
                Console.WriteLine(line);
                amount++;
            }
            Console.WriteLine(amount);
        }
    }
}

