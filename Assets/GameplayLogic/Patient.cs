using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class Patient
{
    public Patient_Illness illness;
    public int bloodLevel;
    public int bloodLoss;
    public int health;
    public int healthLoss;
    public bool isConcious;

    public void SetUpPatient(Illness_SO _illness)
    {
        illness = new Patient_Illness();
        illness.SetUpIllness(_illness);
        SetUpPatientStats();
    }

    private void SetUpPatientStats()
    {
        if(illness.GetSymptomByType(SymptomType.bleeding) != null)
        {
            Debug.Log("CheckingBlood");
            int bloodLossStrength = illness.GetSymptomByType(SymptomType.bleeding).strength;
            bloodLevel = 100 - (10 + (bloodLossStrength * (UnityEngine.Random.Range(Mathf.Clamp(bloodLossStrength - 1, 0, bloodLossStrength - 1), bloodLossStrength + 1))));
            bloodLoss = bloodLossStrength * illness.illnessSeverity;
        }
        else
        {
            bloodLevel = 100;
            bloodLoss = 0;
        }
       
        health = 100 - (100-bloodLevel) / 2;

        foreach (Symptom symptom in illness.symptoms)
        {
            if(symptom.healthLossValue > 0)
            {
                healthLoss += symptom.healthLossValue;
            }
        }

        isConcious = 50 > health ? true : false;
    }

}
