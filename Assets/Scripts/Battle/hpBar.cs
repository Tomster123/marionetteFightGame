using UnityEngine;

public class hpBar : MonoBehaviour
{

    [SerializeField] GameObject health;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health.transform.localScale = new Vector3(0.5f, 1f);
    }

    public void setHP(float hp)
    {
        health.transform.localScale = new Vector3(hp, 1f);
    }
}
