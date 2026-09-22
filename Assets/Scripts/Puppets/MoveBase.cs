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


}
