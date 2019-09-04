using System;
using System.Collections.Generic;
using AnimalFarmProject.Sounds;

namespace AnimalFarmProject {

    class Program {

        static void Main(string[] args) {

            var cow = new Cow(new Moo());
            var cat = new Cat(new Meow());

            var animals = new List<ISpeak>();
            animals.Add(cat);
            animals.Add(cow);

            foreach(var animal in animals) {
                animal.Speak();
            }
        }
    }
}
