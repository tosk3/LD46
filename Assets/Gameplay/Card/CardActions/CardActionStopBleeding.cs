using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardActionStopBleeding : CardAction
{
    public new string name = "Stop Bleeding";
    public new SymptomType symptomType = SymptomType.bleeding;

    public override void DoAction()
    {
        throw new System.NotImplementedException();
    }
}
