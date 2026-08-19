using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPWeek1
{
    public class Dogs
    {
        private int age;
        private string breed;
        private string color;
        private string name;

        public Dogs(int age, string breed, string color, string name)
        {
            this.age = age;
            this.breed = breed;
            this.color = color;
            this.name = name;
        }

        public int GetAge()
        {
            return age;
        }

        public string GetBreed()
        {
            return breed;
        }

        public string GetColor()
        {
            return color;
        }

        public string GetName()
        {
            return name;
        }

        public string GetInfor()
        {
            return "DogName: " + name + ", Breed: " + breed + ", Color: " + color + ", Age: " + age;
        }
    }
}