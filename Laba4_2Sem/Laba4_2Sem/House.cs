using System;
namespace Laba4_2Sem
{
    public class House
    {
        public House()
        {

        }

        List<Animal> Animals = new List<Animal>();

        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
        }

        //public void Print()
        //{
        //    foreach (var n in Animals)
        //        Console.WriteLine(n.Name,n.GetType());
        //}

        public void GetVoice()
        {
            foreach (var n in Animals)
                Console.WriteLine(n.Voice);
        }

        public void ShowSkill()
        {
            foreach (var n in Animals)
                n.ShowSkill();
        }

        public void MoveAnimals()
        {
            foreach (var n in Animals)
                n.Move();
        }
    }
}

