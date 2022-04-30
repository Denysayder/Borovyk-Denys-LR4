using System;
namespace Laba4_2Sem
{
    public abstract class Animal
    {
        public abstract string Voice { get;}
        public int Speed { get;}
        public string Name { get; }
        public Animal(string Name,int Speed)
        {
            this.Speed = Speed;
            this.Name = Name;
        }
        public abstract void Move();
        public abstract void ShowSkill();
    }
}

