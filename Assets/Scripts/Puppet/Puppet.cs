using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
public class Puppet
{
    public PuppetBase Base { get; set; }
    public int Level { get; set; }

    public int HP { get; set; }
    public List<Move> Moves { get; set; }

    public Puppet(PuppetBase pBase, int pLevel)
    {
        Base = pBase;
        Level = pLevel;
        HP = MaxHp;

        Moves = new List<Move>();
        //generate moves
        foreach(var move in Base.LearnableMoves)
        {
            if(move.Level <= Level)
                Moves.Add(new Move(move.Base));
            if (Moves.Count >= 4)
                break;
        }

    }

    public int Attack
    {
        get { return Mathf.FloorToInt(Base.Attack * Mathf.Pow(1.8f, Level - 1)); }
    }
    public int Defense
    {
        get { return Mathf.FloorToInt(Base.Defense * Mathf.Pow(1.8f, Level - 1)); }
    }
    public int ApAttack
    {
        get { return Mathf.FloorToInt(Base.ApAttack * Mathf.Pow(1.8f, Level - 1)); }
    }
    public int ApDefense
    {
        get { return Mathf.FloorToInt(Base.ApDefense * Mathf.Pow(1.8f, Level - 1)); }
    }
    public int Speed
    {
        get { return Mathf.FloorToInt(Base.Speed * Mathf.Pow(1.8f, Level - 1)); }
    }
    public int MaxHp
    {
        get { return Mathf.FloorToInt(Base.MaxHp * Mathf.Pow(1.8f, Level - 1)); }
    }
}
