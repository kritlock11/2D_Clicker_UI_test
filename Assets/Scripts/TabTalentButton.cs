using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TabTalentButton : MonoBehaviour, IPointerClickHandler
{
    public TabTalentGroup TabGroup;
    public Image background;
    public bool isSelected;
    public int TabID;

    private void Start()
    {
        background = GetComponent<Image>();
        TabGroup.Subscribe(this);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        TabGroup.OnTabSelected(this);
    }
}
