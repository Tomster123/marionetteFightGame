using UnityEngine;

public class Puppet
{
    PuppetBase _base;
    int level;

    public Puppet(PuppetBase pBase, int pLevel)
    {
        _base = pBase;
        level = pLevel;
    }

    public int Attack
    {
        get { return Mathf.FloorToInt(_base.Attack * Mathf.Pow(1.8f, level - 1)); }
    }
    public int Defense
    {
        get { return Mathf.FloorToInt(_base.Attack * Mathf.Pow(1.8f, level - 1)); }
    }
    public int SpAttack
    {
        get { return Mathf.FloorToInt(_base.Attack * Mathf.Pow(1.8f, level - 1)); }
    }
    public int SpDefense
    {
        get { return Mathf.FloorToInt(_base.Attack * Mathf.Pow(1.8f, level - 1)); }
    }
    public int Speed
    {
        get { return Mathf.FloorToInt(_base.Attack * Mathf.Pow(1.8f, level - 1)); }
    }
    public int MaxHp
    {
        get { return Mathf.FloorToInt(_base.Attack * Mathf.Pow(1.8f, level - 1)); }
    }
}
