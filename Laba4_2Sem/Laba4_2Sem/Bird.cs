using System;
namespace Laba4_2Sem
{
    public abstract class Bird : Animal
    {
        protected Bird(string Name, int Speed) : base(Name, Speed) { }
    }

    public class Parrot : Bird
    {
        public Parrot(string Name, int Speed) : base(Name, Speed) { }

        public override string Voice { get => "Цвіріньк"; }

        public override void Move()
        {
            Console.WriteLine("Пташка летить зі швидкістю {0} км/год", Speed);
        }

        public override void ShowSkill()
        {
            Console.WriteLine("{0}, як справи?" + "\nДобре!", Name);
        }
    }
}

