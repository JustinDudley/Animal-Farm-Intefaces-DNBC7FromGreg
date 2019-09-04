using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarmProject {

    class Cow : ISpeak {

        ISpeak speak;

        public void Speak() {
            Console.Write("The cow says ");
            speak.Speak();
        }

        public Cow(ISpeak speak) {
            this.speak = speak;
        }
    }
}
