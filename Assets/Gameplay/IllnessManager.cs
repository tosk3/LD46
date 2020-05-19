using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IllnessManager : MonoBehaviour
{
    public List<Illness_SO> allIllnessses;

    public Illness_SO GetRandomIllness()
    {
        return allIllnessses[Random.Range(0, allIllnessses.Count)];
    }
}
