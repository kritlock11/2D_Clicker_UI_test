using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PanelShopButtonsPrefab : MonoBehaviour
{
    public int ShopButtonID;
    public Image ShopButtonImg;
    public TextMeshProUGUI ShopButtonText;
    public Button Button;
    public bool BTN_On;
    public Animator BTN_Anim;



    private ShopButton _shopButton;
    private PanelShopButtonsList _panelShopButtonsList;

    public void SetupPanelShopButtonsPrefab(ShopButton currentButton, PanelShopButtonsList panelShopButtonsList)
    {
        _shopButton = currentButton;
        _panelShopButtonsList = panelShopButtonsList;
        ShopButtonID = _shopButton.ShopButtonID;
        ShopButtonImg.sprite = _shopButton.ShopButtonImg;
        ShopButtonText.text = _shopButton.ShopButtonText;
        Button = _shopButton.Button;
        BTN_On = _shopButton.BTN_On;
        BTN_Anim = _shopButton.BTN_Anim;

    }

}















#region Working Prefab
//using TMPro;
//using UnityEngine;
//using UnityEngine.UI;

//public class PanelShopButtonsPrefab : MonoBehaviour
//{
//    public int ShopButtonID;
//    public Image ShopButtonImg;
//    public TextMeshProUGUI ShopButtonText;
//    public Button Button;
//    public bool BTN_On;
//    public Animator BTN_Anim;



//    private ShopButton _shopButton;
//    private PanelShopButtonsList _panelShopButtonsList;

//    public void SetupPanelShopButtonsPrefab(ShopButton currentButton, PanelShopButtonsList panelShopButtonsList)
//    {
//        _shopButton = currentButton;
//        _panelShopButtonsList = panelShopButtonsList;
//        ShopButtonID = _shopButton.ShopButtonID;
//        ShopButtonImg.sprite = _shopButton.ShopButtonImg;
//        ShopButtonText.text = _shopButton.ShopButtonText;
//        Button = _shopButton.Button;
//        BTN_On = _shopButton.BTN_On;
//        BTN_Anim = _shopButton.BTN_Anim;

//    }

//}
#endregion
