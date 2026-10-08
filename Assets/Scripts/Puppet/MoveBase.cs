using UnityEngine;


[CreateAssetMenu(fileName = "Move", menuName = "Puppet/Create new move")]
public class MoveBase : ScriptableObject
{
    [SerializeField] string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] PuppetType type;
    [SerializeField] int power;
    [SerializeField] int accuracy;
    [SerializeField] int gems;

    public string Name { get { return name; } }
    public string Description { get { return description; } }
    public PuppetType Type { get { return type; } }
    public int Power { get { return power; } }
    public int Accuracy { get { return accuracy; } }
    public int Gems { get { return gems; } }



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

}
