using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class ShopButton
{
    public int ShopButtonID;
    public Sprite ShopButtonImg;
    public string ShopButtonText;
    public Button Button;
    public bool BTN_On;
    public Animator BTN_Anim;


}
public class PanelShopButtonsList : MonoBehaviour
{
    public List<ShopButton> ShopButtonList;
    public Transform ParentPanel;
    public GameObject ShopButtonPrefab;
    PanelShopButtonsPrefab panelShopSkillPrefab;
    ShopButton item;
    void Start()
    {
        AddButtons();
    }
    private void AddButtons()
    {
        for (int i = 0; i < ShopButtonList.Count; i++)
        {
            item = ShopButtonList[i];
            GameObject newShopButton = Instantiate(ShopButtonPrefab, ParentPanel);
            panelShopSkillPrefab = newShopButton.GetComponent<PanelShopButtonsPrefab>();
            panelShopSkillPrefab.SetupPanelShopButtonsPrefab(item, this);
        }
    }
}