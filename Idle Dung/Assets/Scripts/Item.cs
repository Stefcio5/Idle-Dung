using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Item : ScriptableObject
{
    public string ItemName;
    public Sprite Icon;
    public void Equip(Character c)
    {
        c.Strength.AddModifier(new StatModifier(.1f, StatModType.PercentMulti, this));
        Debug.Log(c.Strength.Value);
        
    }
}
