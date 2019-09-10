using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using CLICKER2D;

[System.Serializable]
public class ShopSkill
{
    public int ShopSkillID;
    public Sprite SkillImg;
    public Sprite BgPriceImg;
    public string ItemDescription;
    public float Price;
    public string AvailableOrNotText;
}
public class ShopScrollList : MonoBehaviour
{
    public List<ShopSkill> ItemsList;
    public GameObject Prefab;
    public Transform ParentPanel;
    public TextMeshProUGUI MyGold;
    void Start()
    {
        AddButtons();
    }
    private void AddButtons()
    {
        for (int i = 0; i < ItemsList.Count; i++)
        {
            ShopSkill item = ItemsList[i];
            GameObject newPanel = Instantiate(Prefab, ParentPanel);
            ShopScrollSkillPrefab panelShopSkillPrefab = newPanel.GetComponent<ShopScrollSkillPrefab>();
            panelShopSkillPrefab.SetupPanelShopSkillPrefab(item,this);
        }
    }

}
