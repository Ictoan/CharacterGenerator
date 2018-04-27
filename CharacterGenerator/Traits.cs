using System;

namespace CharacterGenerator
{
    public static class Traits
    {
        public enum Colors
        {
            Blue = 1,

            Purple = 2,

            Orange = 3
        }



        public enum FirstNames
        {
            Tyler = 1,

            Robert = 2,

            James = 3


        }

        public enum LastNames
        {
            Shortley = 1,

            Basinger = 2,

            Snyder = 3


        }

        public enum Music
        {
            Rap = 1,

            Country = 2,

            Techno = 3


        }

        public enum Sports
        {
            Basketball = 1,

            Hockey = 2,

            Football = 3

        }





        public static void Genorate()
        {

            var random = new Random();

            var firstName = random.Next(1, 3);
            Console.WriteLine((FirstNames)firstName);

            
            var lastName = random.Next(1, 3);
            Console.WriteLine((LastNames)lastName);

            var favColor = random.Next(1, 3);
            Console.WriteLine((Colors)favColor);

           
            var favMusic = random.Next(1, 3);
            Console.WriteLine((Music)favMusic);

            
            var favSport = random.Next(1, 3);
            Console.WriteLine((Sports)favSport);

            
        }
    

    }






}
