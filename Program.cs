using System;

namespace Transformacja_wartosci_typu_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert input:");
            string userInput = Console.ReadLine();

            //Substring(userInput);
            //Replace(userInput);
            //Remove(userInput);
            //Trim(userInput);
            //AlterTextCase(userInput);
            //Split(userInput);
            // StartsEndsWith(userInput);

            bool containStr = userInput.Contains("text", StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine("Is contain: " + containStr);

            #region METHODS CALLS - MS docs
            // -------------------------------------------------------------------
            // SUBSTRINGS examples from www.docs.microsoft.com documentation of C#

            String[] pairs = { "Color1=red", "Color2=green", "Color3=blue", "Title=Code Repostory" };
            String[] info = { "Name: Felica Walker", "Title: Mz.", "Age: 47", "Location: Paris", "Gender: F" };
            String str = "aaaaabbbcccccccccdd";
            String xmlElement = "<term>extant<definition>still in existence</definition></term>";

            //Substring_key_value(pairs);
            //Substring_only_value_info(info);
            //Substring_try_catch_ex(myString);
            //Searching_sequence_in_string(str);
            //Substring_multiple_characters(xmlElement); 
            #endregion
        }

        private static void StartsEndsWith(string userInput)
        {
            bool txtFile = userInput.EndsWith(".txt");
            bool docFile = userInput.EndsWith(".doc");
            bool ReadmeFile = userInput.StartsWith("Readme");

            Console.WriteLine($"Text file: {txtFile}\n" +
                              $"Doc file: {docFile}\n" +
                              $"Readme file: {ReadmeFile}");
        }

        private static void Split(string userInput)
        {
            string[] splitStr = userInput.Split(' ');
            foreach (string s in splitStr)
            {
                Console.WriteLine(s);
            }
            string firstName = splitStr[0];
            string lastName = splitStr[splitStr.Length - 1];

            Console.WriteLine($"Hello, {firstName} {lastName}");
        }

        private static void AlterTextCase(string userInput)
        {
            string lowerStr = userInput.ToLower();
            string upperStr = userInput.ToUpper();

            Console.WriteLine(lowerStr);
            Console.WriteLine(upperStr);
        }

        private static void Trim(string userInput)
        {
            string insertedStr = userInput.Insert(5, "INSERT");
            Console.WriteLine(insertedStr);

            char[] charArray = { '*', ' ', '.' };

            string trimmedStr = userInput.Trim(charArray);
            Console.WriteLine(trimmedStr);
        }

        private static void Remove(string userInput)
        {
            string removedStr1 = userInput.Remove(5);
            Console.WriteLine(removedStr1);
            string removedStr2 = userInput.Remove(5, 3);
            Console.WriteLine(removedStr2);

            // Substring() method is opposite to Remove();

            string substringStr = userInput.Substring(5);
            Console.WriteLine(substringStr);
        }

        private static void Replace(string userInput)
        {
            string template = "Hello {name}, how are you?";
            string greeting = template.Replace("{name}", userInput);

            Console.WriteLine(greeting);
        }

        private static void Substring(string userInput)
        {
            if (userInput.Length > 10)
            {
                string startSubstring = userInput.Substring(0, 10);
                string endSubstring = userInput.Substring(userInput.Length - 10);
                Console.WriteLine($"{startSubstring}..., ...{endSubstring}");
                Console.WriteLine(userInput);
            }
        }

        #region SUBSTRING methods examples from www.docs.microsoft.com documentation of C#
        private static void Substring_multiple_characters(string xmlElement)
        {
            String searchString = "<definition>";
            int startIndex = xmlElement.IndexOf(searchString);
            searchString = "</" + searchString.Substring(1);
            int endIndex = xmlElement.IndexOf(searchString);
            string substring = xmlElement.Substring(startIndex, endIndex + searchString.Length - startIndex);

            Console.WriteLine("The original string is: " + xmlElement);
            Console.WriteLine("The substring is: " + substring);
        }

        private static void Searching_sequence_in_string(string s)
        {
            char charRange = 'b';
            int startIndex = s.IndexOf(charRange);
            int endIndex = s.LastIndexOf(charRange);
            int length = endIndex - startIndex + 1;

            Console.WriteLine("{0}.Substring({1}, {2}) = {3}",
                                s, startIndex, length,
                                s.Substring(startIndex, length));
        }

        private static void Substring_try_catch_ex(string myString)
        {
            bool test1 = myString.Substring(2, 1).Equals("c");
            Console.WriteLine(test1);
            bool test2 = String.IsNullOrEmpty(myString.Substring(3, 0));
            Console.WriteLine(test2);

            try
            {
                string str3 = myString.Substring(3, 1);
                Console.WriteLine(str3);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void Substring_only_value_info(string[] info)
        {
            int found = 0;

            Console.WriteLine("The initial value in the array are:");
            foreach (string s in info)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\nWe want to retrieve only the key information. That is:");
            foreach (string s in info)
            {
                found = s.IndexOf(": ");
                Console.WriteLine("\t{0}", s.Substring(found + 2));
            }
        }

        private static void Substring_key_value(string[] pairs)
        {
            foreach (var pair in pairs)
            {
                int position = pair.IndexOf("=");
                if (position < 0)
                    continue;
                Console.WriteLine("KEY: {0}, VALUE: '{1}'", pair.Substring(0, position), pair.Substring(position + 1));
            }
        } 
        #endregion
    }
}
