using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName ="New Illness",menuName = "NegativeObjects/illness")]
public class Illness_SO : ScriptableObject
{
    public string Name;
    public string Description;

    public List<Symptom> symptoms;
    public int illnessSeverity;
}

