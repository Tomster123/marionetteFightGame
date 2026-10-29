using UnityEngine;

public class battleUnit : MonoBehaviour
{
    [SerializeField] PuppetBase _base;
    [SerializeField] int level;

    public void Setup()
    {
        new Puppet(_base, level);
    }

}
