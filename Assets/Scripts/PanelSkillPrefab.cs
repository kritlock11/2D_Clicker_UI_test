using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class PanelSkillPrefab : MonoBehaviour
{
    private int PanelSkillID;
    public Image SkillImg;
    public Image SkillCDImg;
    public TextMeshProUGUI SkillCDText;

    private float _timerCD;
    private float timerCD;
    private bool _skillOnCD;

    public Button Button;
    private PanelSkill _panelSkill;
    private PanelSkillList _skillPanelList;


    private void Start()
    {
        SkillCDImg.gameObject.SetActive(false);
        SkillCDText.text = "";
        timerCD = _timerCD;
        switch (PanelSkillID)
        {
            case 1:
                Button.onClick.AddListener(Skill1);
                break;
            case 2:
                Button.onClick.AddListener(Skill2);
                break;
            case 3:
                Button.onClick.AddListener(Skill3);
                break;
        }
    }

    public void SetupPanelSkillPrefab(PanelSkill currentSkill)
    {
        _panelSkill = currentSkill;
        PanelSkillID = _panelSkill.SkillID;
        SkillImg.sprite = _panelSkill.SkillImg;
        SkillCDText.text = _panelSkill.SkillCDText;
        _timerCD = _panelSkill.TimerCD;
    }
    private void Update()
    {
        SkillOnCD();
    }

    public void SkillOnCD()
    {
        if (_skillOnCD)
        {
            SkillCDImg.fillAmount -= 1 / _timerCD * Time.deltaTime;
            SkillCDText.text = $"{(int)(timerCD -= Time.deltaTime)}";
            if (SkillCDImg.fillAmount <= 0)
            {
                _skillOnCD = false;
                timerCD = _timerCD;
                SkillCDImg.gameObject.SetActive(false);
            }
        }
    }

    public bool IsSkillOnCD()
    {
        if (!_skillOnCD)
        {
            SkillCDImg.fillAmount = 1f;
            SkillCDImg.gameObject.SetActive(true);
            _skillOnCD = true;
            return true;
        }
        return false;
    }
    public void Skill1()
    {
        if (IsSkillOnCD())
        {
            Debug.Log("Skill1");
        }
    }
    public void Skill2()
    {
        if (IsSkillOnCD())
            Debug.Log("Skill2");
    }
    public void Skill3()
    {
        if (IsSkillOnCD())
            Debug.Log("Skill3");
    }

}
