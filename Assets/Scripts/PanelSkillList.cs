using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PanelSkill
{
    public int SkillID;
    public Sprite SkillImg;
    public string SkillCDText;
    public float TimerCD;
}
public class PanelSkillList : MonoBehaviour
{
    public List<PanelSkill> SkillList;
    public Transform ParentPanel;
    public GameObject SkillPrefab;
    void Start()
    {
        AddButtons();
    }
    private void AddButtons()
    {
        for (int i = 0; i < SkillList.Count; i++)
        {
            PanelSkill item = SkillList[i];
            GameObject newPanelSkill = Instantiate(SkillPrefab, ParentPanel);
            PanelSkillPrefab panelShopSkillPrefab = newPanelSkill.GetComponent<PanelSkillPrefab>();
            panelShopSkillPrefab.SetupPanelSkillPrefab(item);
        }
    }
}
