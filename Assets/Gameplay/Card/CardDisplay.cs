using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    public Card cardInfo;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI actionCostText;
    public Image cardArtwork;
    
    public void SetUpCardDisplay()
    {
        if(cardInfo != null)
        {
            nameText.text = cardInfo.name;
            descriptionText.text = cardInfo.description;
            actionCostText.text = cardInfo.actionCost.ToString();
            cardArtwork.sprite = cardInfo.artwork;
        } 
    }

    public void SetUpCardDisplay(Card _cardInfo)
    {
        if (_cardInfo != null)
        {
            nameText.text = _cardInfo.name;
            descriptionText.text = _cardInfo.description;
            actionCostText.text = _cardInfo.actionCost.ToString();
            cardArtwork.sprite = _cardInfo.artwork;
        }
    }

    public void ClearCardData()
    {
        nameText.text = null;
        descriptionText.text = null;
        actionCostText.text = null;
        cardArtwork = null;
    }

    public void ToggleActive()
    {
        if (gameObject.activeSelf)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
}
