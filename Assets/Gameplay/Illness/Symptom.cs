using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum SymptomType
{
    bleeding,
    pain,
    fever,
    dizzyness,
    nausea,
    swealing,
    vomiting,
    infection,
    internalBleeding
}

[Serializable]
public class Symptom 
{
    public string name;
    public bool isCured;

    public SymptomType symptomType;
    public int strength;

    public int bloodLossValue;
    public int healthLossValue;


    public void Cure()
    {
        isCured = true;
    }
}
