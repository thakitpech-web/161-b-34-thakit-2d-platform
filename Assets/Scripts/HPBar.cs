using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Slider HpBar;
    public Character character;

    void Start()
    {
        HpBar.maxValue = character.Heath;
    }

    // Update is called once per frame
    void Update()
    {
        HpBar.value = character.Heath;
        HpBar.maxValue = character.maxHp;
    }
}
