using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "Puppet", menuName = "Puppet/Create new Puppet")]

public class PuppetBase : ScriptableObject
{
    [SerializeField] new string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] Sprite leftSprite;
    [SerializeField] Sprite rightSprite;

    [SerializeField] PuppetType type1;
    [SerializeField] PuppetType type2;

    // Base Stats
    [SerializeField] int maxHp;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int apAttack;
    [SerializeField] int apDefense;
    [SerializeField] int speed;

    public string Name {
        get { return name; }
    }
    public string Description {
        get { return description; }
    }
    public Sprite LeftSprite {
        get { return leftSprite; }
    }
    public Sprite RightSprite {
        get { return rightSprite; }
    }
    public PuppetType Type1 {
        get { return type1; }
    }
    public PuppetType Type2 {
        get { return type2; }
    }
    public int MaxHp {
        get { return maxHp; }
    }
    public int Attack {
        get { return attack; }
    }
    public int Defense {
        get { return defense; }
    }
    public int ApAttack {
        get { return apAttack; }
    }
    public int ApDefense {
        get { return apDefense; }
    }
    public int Speed {
        get { return speed; }
    }

}

//Puppet Types and roles
public enum PuppetType
{
    Sock,
    Gnome,
    Muppet,
    Porcelain,
    ventriloquist,
    Fighter,
    Archer,
    Mage,
    Tank

}