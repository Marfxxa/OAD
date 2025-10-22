using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Loli : Entity.Character
{
    public Loli(string name) : base(name, CharacterClass.Loli)
    {
        Health = 85;
        Strength = 3;
        Intelligence = 9;
        Agility = 20;
        Special = "Onigiri Japan";
    }
}