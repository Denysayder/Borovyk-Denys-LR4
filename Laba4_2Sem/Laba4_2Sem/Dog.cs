using System;
namespace Laba4_2Sem
{
    public class Dog : Animal
    {
        public Dog(string Name, int Speed) : base(Name, Speed) { }

        public override string Voice { get => "Гав"; }

        public override void Move()
        {
            Console.WriteLine("Собака біжить зі швидкістю {0}км/год", Speed);
        }

        public override void ShowSkill()
        {
            Console.WriteLine("{0}, дай лапу!" + "\n{0} дав лапу", Name);
        }
    }
}

