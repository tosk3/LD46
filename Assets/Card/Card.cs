using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : ScriptableObject
{
    public string name;
    public string description;

    public Sprite artwork;

    public int actionCost;

    public CardAction action;

}
