using System;

namespace NullableTypesCSharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer? customer;
            var res = TryGet(10, out customer);
            Console.WriteLine(res);
        }

        static bool TryGet(int key, out Customer? customer)
        {
            if (key % 2 == 0)
            {
                customer = new Customer
                {
                    key = key
                };
                return true;
            }
            else
            {
                customer = null;
                return false;
            }
                
        }
    }

    class Customer
    {
        public int key { get; set; }
    }
}


/*
 1.- You need Visual Studio 2019 version 16.3 or higher
 2.- Configure your project with C#8
        Under the new lines, the default c# version is determined by wich framework you are targeting.
        Only .Net core 3.0 and .Net Standard 2.1 get C#8, everything else start with C#7.3
        You can override this modifying the .csproj. Add <LangVersion>8.0</LangVersion> inside PropertyGroup
 3.- Enabling Nullable Reference Types
        add <Nullable>enable</Nullable> just below the language version

    Referece:
    https://www.infoq.com/articles/CSharp-8-Framework/?useSponsorshipSuggestions=true&itm_source=articles_about_development&itm_medium=link&itm_campaign=development
 */
