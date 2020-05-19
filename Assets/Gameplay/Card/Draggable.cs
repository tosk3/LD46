using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    Transform parentToReturnTo = null;
    public Transform placeholderParent = null;
    public GameObject placeHolder = null;

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");

        placeHolder = new GameObject();
        placeHolder.transform.SetParent(this.transform.parent); 
        LayoutElement le = placeHolder.AddComponent<LayoutElement>();
        le.preferredWidth = this.GetComponent<LayoutElement>().preferredWidth;
        le.preferredHeight = this.GetComponent<LayoutElement>().preferredHeight;
        placeHolder.GetComponent<RectTransform>().sizeDelta = new Vector2(this.GetComponent<LayoutElement>().preferredWidth, this.GetComponent<LayoutElement>().preferredHeight);
        placeHolder.transform.SetSiblingIndex(this.transform.GetSiblingIndex());

        ChangeParentToReturnTo(transform.parent);
        placeholderParent = parentToReturnTo;
        this.transform.SetParent(transform.parent.parent);
        GetComponent<CanvasGroup>().blocksRaycasts = false;


        //you can check tyhe distance from the centre of the card to the mouse to offset it so it doesnt go to the middle !
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Drag");
        this.transform.position = eventData.position;

        if (placeHolder.transform.parent != placeholderParent)
            placeHolder.transform.SetParent(placeholderParent);

        int newSiblingIndex = placeholderParent.childCount;

        for (int i = 0; i < placeholderParent.childCount; i++)
        {
            if(placeholderParent.childCount > 1)
            {
                if (this.transform.position.x < placeholderParent.GetChild(i).transform.position.x)
                {
                    newSiblingIndex = i;
                    if (placeHolder.transform.GetSiblingIndex() < newSiblingIndex)
                        newSiblingIndex--;

                    break;
                }
            }
            else
            {
                break;
            }      
        }
        placeHolder.transform.SetSiblingIndex(newSiblingIndex);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.SetParent(parentToReturnTo);
        this.transform.SetSiblingIndex(placeHolder.transform.GetSiblingIndex());
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        Destroy(placeHolder);
    }

    public void ChangeParentToReturnTo(Transform parent)
    {
        parentToReturnTo = parent;
    }

    public Transform GetParentToReturnTo()
    {
        return parentToReturnTo;
    }
}
