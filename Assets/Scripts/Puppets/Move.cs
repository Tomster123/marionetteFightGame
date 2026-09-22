using UnityEngine;

public class Move
{
    public MoveBase Base { get; set; }
    public int Gems { get; set; }

    public Move(MoveBase pBase, int gems)
    {
        this.Base = pBase;
        this.Gems = gems;
    }

    
}
