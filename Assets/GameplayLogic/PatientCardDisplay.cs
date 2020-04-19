using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PatientCardDisplay : MonoBehaviour
{
    public PatientManager patientManager;
    public Patient currentPatient;

    public GameObject symptomObject;
    public List<GameObject> symptoms;

    public TextMeshProUGUI illnessNameText;
    public TextMeshProUGUI illnessDescriptionText;
    public TextMeshProUGUI illnessSeverityText;
    public TextMeshProUGUI bloodLossText;
    public TextMeshProUGUI healthLossText;

  

    private void Update()
    {
        currentPatient = patientManager.currentPatient;
        UpdateCardText();
    }

    private void UpdateCardText()
    {
        illnessNameText.text = currentPatient.illness.Name;
        illnessDescriptionText.text = currentPatient.illness.Description;
        illnessSeverityText.text = currentPatient.illness.illnessSeverity.ToString();
        bloodLossText.text = currentPatient.bloodLevel.ToString() + " /- " + currentPatient.bloodLoss + "p/s";
        healthLossText.text = currentPatient.health.ToString() + " /- " + currentPatient.healthLoss + "p/s";

        if (symptoms.Count < currentPatient.illness.symptoms.Count)
        {
            foreach (Symptom symptom in currentPatient.illness.symptoms)
            {
                GameObject anotherSymptom = Instantiate(symptomObject, symptomObject.transform.parent);
                anotherSymptom.GetComponent<TextMeshProUGUI>().text = symptom.symptomType.ToString();
                anotherSymptom.SetActive(true);
                symptoms.Add(anotherSymptom);
            }
        }
       
    }
}
