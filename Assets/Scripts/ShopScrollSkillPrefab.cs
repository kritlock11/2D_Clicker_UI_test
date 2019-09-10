using UnityEngine;
using UnityEngine.UI;
using TMPro;
using CLICKER2D;

public class ShopScrollSkillPrefab : MonoBehaviour
{
    public int ShopSkillID;
    public Button Button;
    public Image SkillImg;
    public Image BgPriceImg;
    public TextMeshProUGUI SkillDescriptionText;
    public TextMeshProUGUI PriceText;
    public TextMeshProUGUI AvailableOrNotText;
    private ShopSkill _shopSkill;
    private ShopScrollList _shopScrollList;

    private PlayerController _playerController;






    public void SetupPanelShopSkillPrefab(ShopSkill currentItem, ShopScrollList shopScrollList)
    {
        _shopSkill = currentItem;
        _shopScrollList = shopScrollList;
        ShopSkillID = _shopSkill.ShopSkillID;
        SkillImg.sprite = _shopSkill.SkillImg;
        BgPriceImg.sprite = _shopSkill.BgPriceImg;
        SkillDescriptionText.text = _shopSkill.ItemDescription;
        PriceText.text = $"{_shopSkill.Price}";
        AvailableOrNotText.text = _shopSkill.AvailableOrNotText;
    }



    private void Start()
    {
        _playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

        switch (ShopSkillID)
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
            case 4:
                Button.onClick.AddListener(Skill4);
                break;
            case 5:
                Button.onClick.AddListener(Skill5);
                break;
        }
    }

    private void Update()
    {
        Available();
    }

    public bool Available()
    {
        if (_playerController.GoldCounter >= _shopSkill.Price)
        {
            AvailableOrNotText.text = "Available NOW!";
            return true;
        }
        else
        {
            AvailableOrNotText.text = "NOT Available NOW!";
            return false;
        }
    }

    public void Skill1()
    {
        if (Available())
        {
            _playerController.GoldCounter -= _shopSkill.Price;
            _playerController.Damage += 1;
            Debug.Log("Skill1");
        }
    }
    public void Skill2()
    {
        if (Available())
        {
            _playerController.GoldCounter -= _shopSkill.Price;
            _playerController.Damage += 2;

            Debug.Log("Skill2");
        }
    }
    public void Skill3()
    {
        if (Available())
        {
            _playerController.GoldCounter -= _shopSkill.Price;
            _playerController.Damage += 3;

            Debug.Log("Skill3");
        }
    }
    public void Skill4()
    {
        if (Available())
        {
            _playerController.GoldCounter -= _shopSkill.Price;
            _playerController.Damage += 4;

            Debug.Log("Skill4");
        }
    }
    public void Skill5()
    {
        if (Available())
        {
            _playerController.GoldCounter -= _shopSkill.Price;
            _playerController.Damage += 5;

            Debug.Log("Skill5");
        }
    }

}
