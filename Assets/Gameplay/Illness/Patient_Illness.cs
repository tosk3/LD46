using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Patient_Illness
{
    public string Name;
    public string Description;

    public List<Symptom> symptoms;
    public int illnessSeverity;


    public void SetUpIllness(Illness_SO illness)
    {
        Name = illness.Name;
        Description = illness.Description;
        illnessSeverity = illness.illnessSeverity;

        symptoms = illness.symptoms;
        foreach (Symptom symptom in symptoms)
        {
            symptom.strength = UnityEngine.Random.Range(Mathf.Clamp(illnessSeverity - 1, 1, illnessSeverity + 1), illnessSeverity + 4);
        }
    }

    public Symptom GetSymptomByType(SymptomType _symptomType)
    {
        return symptoms.Find(x => x.symptomType == _symptomType);
    }

    public void TreatSymptom(SymptomType _symptomType)
    {
        GetSymptomByType(_symptomType).Cure();
    }
}
