using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class PatientManager : MonoBehaviour
{
    public IllnessManager illnessManager;
    public Patient currentPatient;

    void Start()
    {
        SetUpPatientCard();
    }

    private void SetUpPatientCard()
    {
        currentPatient = new Patient();
        currentPatient.SetUpPatient(illnessManager.GetRandomIllness());
    }

    public Patient GetPatient()
    {
        return currentPatient;
    }
}
