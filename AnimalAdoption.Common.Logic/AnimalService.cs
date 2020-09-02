using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAdoption.Common.Logic
{
    public class AnimalService
    {
        public Animal[] ListAnimals => new Animal[] {
            new Animal { Id = 1, Name = "Bengal Tiger", Age = 25, Description = "Also known as Indian Tiger" },
            new Animal { Id = 2, Name = "Siberian Tiger", Age = 20, Description = "Also known as Amur/Manchurian Tiger" },
            new Animal { Id = 3, Name = "South China tiger", Age = 15, Description = "Found in central and eastern China" },
        };
    }
}
