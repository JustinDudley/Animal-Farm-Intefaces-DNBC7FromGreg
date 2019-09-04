using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarmProject.Sounds {
    
    class Meow : ISpeak {
    
        public void Speak() {
            Console.WriteLine("Meow!");
        }
    }
}
