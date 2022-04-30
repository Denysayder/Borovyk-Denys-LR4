// See https://aka.ms/new-console-template for more information
using Laba4_2Sem;
Console.WriteLine("Скільки тварин ви хочете завести?");
int Number = Int32.Parse(Console.ReadLine());
House house = new House();
int AnimalCount = 0;
while (AnimalCount < Number)
{
    string Name = "";
    int Speed = 0;

    Console.WriteLine("Назвіть нового котика");
    Name = Console.ReadLine();
    Console.WriteLine("Введіть його швидкість");
    Speed = Int32.Parse(Console.ReadLine());
    house.AddAnimal(new Cat(Name, Speed));
    AnimalCount++;
    if (AnimalCount == Number)
        break;

    Console.WriteLine("Назвіть нового собаку");
    Name = Console.ReadLine();
    Console.WriteLine("Введіть його швидкість");
    Speed = Int32.Parse(Console.ReadLine());
    house.AddAnimal(new Dog(Name, Speed));
    AnimalCount++;
    if (AnimalCount == Number)
        break;

    Console.WriteLine("Назвіть нового папугу");
    Name = Console.ReadLine();
    Console.WriteLine("Введіть його швидкість");
    Speed = Int32.Parse(Console.ReadLine());
    house.AddAnimal(new Parrot(Name, Speed));
    AnimalCount++;
}

Console.Clear();
Console.WriteLine("Показати вміння");
house.ShowSkill();
Console.WriteLine("\nРухатися");
house.MoveAnimals();
Console.WriteLine("\nГолос!");
house.GetVoice();