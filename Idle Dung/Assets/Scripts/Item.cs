using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public void Equip(Character c)
    {
        c.Strength.AddModifier(new StatModifier(.1f, StatModType.PercentMulti, this));
        Debug.Log(c.Strength.Value);
    }
}
