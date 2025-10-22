using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Cat: Entity.Character
{
    public Cat(string name) : base(name, CharacterClass.Cat)
    {
        Health = 50;
        Strength = 6;
        Intelligence = 20;
        Agility = 9;
        Speed = 20;
        Hunger = 10;
        Special = "the cat was too stunned to speak";
    }
}