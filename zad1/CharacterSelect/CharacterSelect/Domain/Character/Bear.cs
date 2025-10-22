using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Bear : Entity.Character
{
    public Bear(string name) : base(name, CharacterClass.Bear)
    {
        Health = 100;
        Strength = 10;
        Intelligence = 2;
        Agility = 12;
        Speed = 20;
        Hunger = 20;
        Special = "shoocked";
    }
}