using UnityEngine;
using UnityEngine.UI;

public class battleHud : MonoBehaviour
{
    [SerializeField] Text nameText;
    [SerializeField] Text levelText;
    [SerializeField] hpBar aHPBar;

    public void SetData(Puppet puppet)
    {
        nameText.text = puppet.Base.Name;
        aHPBar.setHP((float) puppet.HP / puppet.MaxHp);
    }
}
