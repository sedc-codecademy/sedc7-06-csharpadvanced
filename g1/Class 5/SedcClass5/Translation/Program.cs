using System;

namespace Translation
{
    class Program
    {
        public delegate void TranslationDelegate(string word);

        static void Main(string[] args)
        {
            TranslationDelegate baseDelegate = new TranslationDelegate(NativeMacedonian);
            TranslationDelegate enTranslation = new TranslationDelegate(EnglishTranslation);
            TranslationDelegate esTranslation = new TranslationDelegate(SpanishTranslation);
            TranslationDelegate deTranslation = new TranslationDelegate(GermanTranslation);

            //baseDelegate("Zdravo");
            //enTranslation("Zdravo");
            //esTranslation("Zdravo");
            //deTranslation("Zdravo");

            baseDelegate("Zdravo");

            baseDelegate += enTranslation;
            baseDelegate += esTranslation;
            baseDelegate += deTranslation;

            baseDelegate -= enTranslation;

            baseDelegate("Zdravo");
            Console.Read();
        }

        public static void NativeMacedonian(string word)
        {
            Console.WriteLine($"Makedonski: {word}");
        }

        public static void EnglishTranslation(string word)
        {
            string translation;
            switch (word)
            {
                case "Zdravo":
                    translation = "Hello";
                    break;
                default:
                    translation = "Ne postoi ovoj zbor vo nasiot angliskiot recnik";
                    break;
            }

            Console.WriteLine($"In english: {translation}");
        }

        public static void SpanishTranslation(string word)
        {
            string translation;
            switch (word)
            {
                case "Zdravo":
                    translation = "Hola";
                    break;
                default:
                    translation = "Ne postoi ovoj zbor vo nasiot shpanski recnik";
                    break;
            }

            Console.WriteLine($"En espanol: {translation}");
        }

        public static void GermanTranslation(string word)
        {
            string translation;
            switch (word)
            {
                case "Zdravo":
                    translation = "Hallo";
                    break;
                default:
                    translation = "Ne postoi ovoj zbor vo nasiot germanski recnik";
                    break;
            }

            Console.WriteLine($"Na germanski: {translation}");
        }
    }
}
