using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

//[RequireComponent(typeof(Image))]
public class TabButton : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public TabGroup TabGroup;
    public Image background;

    public UnityEvent onTabSelected;
    public UnityEvent onTabDeselected;
    public bool isSelected;

    private void Start()
    {
        background = GetComponent<Image>();
        TabGroup.Subscribe(this);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        TabGroup.OnTabSelected(this);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        TabGroup.OnTabEnter(this);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        TabGroup.OnTabExit(this);
    }

    public void Select()
    {
        if (onTabSelected!=null)
        {
            onTabSelected.Invoke();
        }
    }

    public void DeSelect()
    {
        if (onTabDeselected != null)
        {
            onTabDeselected.Invoke();
        }
    }













}
