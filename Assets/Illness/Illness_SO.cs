using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public enum SymptomType
{
    bleeding,
    pain,
    fever,
    dizzyness,
    nausea,
    swealing,
    vomiting,
}

[Serializable]
public class Symptom
{
    public bool isCured;
    public SymptomType symptomType;
    public int strength;
}
[CreateAssetMenu(fileName ="New Illness",menuName = "NegativeObjects/illness")]
public class Illness_SO : ScriptableObject
{
    public string Name;
    public string Description;

    public List<Symptom> symptoms;
    public int illnessSeverity;
}

