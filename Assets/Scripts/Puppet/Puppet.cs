using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
public class Puppet
{
    PuppetBase _base;
    int level;

    public int HP { get; set; }
    public List<Move> Moves { get; set; }

    public Puppet(PuppetBase pBase, int pLevel)
    {
        _base = pBase;
        level = pLevel;
        HP = _base.MaxHp;

        Moves = new List<Move>();
        //generate moves
        foreach(var move in _base.LearnableMoves)
        {
            if(move.Level <= level)
                Moves.Add(new Move(move.Base));
            if (Moves.Count >= 4)
                break;
        }

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
