using System;
namespace Laba4_2Sem
{
    public class Cat : Animal
    {
        public Cat(string Name,int Speed) : base(Name,Speed) { }

        public override string Voice { get => "Mяу"; }

        public override void Move()
        {
            Console.WriteLine("Кіт біжить зі швидкістю {0}км/год",Speed);
        }

        public override void ShowSkill()
        {
            Console.WriteLine("{0}, сидіти!" + "\n{0} сидить", Name);
        }
    }
}

