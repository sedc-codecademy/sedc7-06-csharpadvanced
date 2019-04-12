using System.Collections.Generic;
using LinqExercise.Models;

namespace LinqExercise.Services
{
    public static class DogService
    {
        public static List<Dog> GetAllDogs()
        {
            return new List<Dog>()
            {
                new Dog("Charlie", Color.Black, 3, Race.Collie),
                new Dog("Buddy", Color.Brown, 1, Race.Doberman),
                new Dog("Max", Color.Olive, 1, Race.Plott),
                new Dog("Archie", Color.Black, 2, Race.Doberman),
                new Dog("Oscar", Color.Mix, 1, Race.Mudi),
                new Dog("Toby", Color.Silver, 3, Race.Bulldog),
                new Dog("Ollie", Color.Golden, 4, Race.Husky),
                new Dog("Bailey", Color.White, 4, Race.Pointer),
                new Dog("Frankie", Color.Olive, 2, Race.Retriever),
                new Dog("Jack", Color.Black, 5, Race.Dalmatian),
                new Dog("Chanel", Color.White, 1, Race.Pug),
                new Dog("Henry", Color.Black, 7, Race.Plott),
                new Dog("Bo", Color.Maroon, 3, Race.Boxer),
                new Dog("Scout", Color.Mix, 2, Race.Boxer),
                new Dog("Ellie", Color.Brown, 6, Race.Doberman),
                new Dog("Hank", Color.Silver, 2, Race.Collie),
                new Dog("Shadow", Color.Brown, 3, Race.Mudi),
                new Dog("Diesel", Color.Golden, 1, Race.Bulldog),
                new Dog("Abby", Color.Mix, 1, Race.Dalmatian),
                new Dog("Trixie", Color.Maroon, 6, Race.Mudi),
                new Dog("Alfi", Color.Black, 3, Race.Chihuahua),
                new Dog("Benji", Color.Brown, 2, Race.Cocker),
                new Dog("Ava", Color.Golden, 4, Race.Bulldog),
                new Dog("Chet", Color.Olive, 1, Race.Boxer),
                new Dog("Rigby", Color.Mix, 5, Race.Collie),
                new Dog("Sam", Color.Silver, 1, Race.Inu),
                new Dog("Tilly", Color.White, 3, Race.Retriever),
                new Dog("Yumi", Color.White, 4, Race.Retriever),
                new Dog("Zoe", Color.Brown, 9, Race.Husky),
                new Dog("Gonzo", Color.Mix, 1, Race.Doberman),
            };
        }
    }
}
