class Program
{
    static void Main(string[] args)
    {
        //StreamReader variable for getting a file.
        StreamReader textFile;

        //file that is used to read the letters
        textFile = File.OpenText(@"C:\Users\yonit\Desktop\CST-150\Activity12\Activity12.txt");
        


        //string to read the file content
        string line = textFile.ReadLine();

        //int variavle to count the words
        int charCount = 0;

        //While loop to read all the file as long as file is not null
        while (line != null)
        {
            //
            string[] words = line.Split(' ');

            //logic that checks each owrd
            foreach (string word in words) // for each word
            {
                //If statement that checks if the words eand with e ot t
                if (word.EndsWith("t") || word.EndsWith("e")) 
                {
                    //logic to increment the count
                    charCount += 1; 
                }
            }
            line = textFile.ReadLine(); 
        }

        // close the file
        textFile.Close();

        // Printout the results
        Console.WriteLine("There are " + charCount + " words that end in t or e.");

        Console.ReadLine();
    }
}
