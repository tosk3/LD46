using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CardAction : ScriptableObject
{
    public new string name;
    public SymptomType symptomType;
    public int value;
    public float modifier;

    public abstract void DoAction();
}
