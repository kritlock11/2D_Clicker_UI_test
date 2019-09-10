using CLICKER2D;
using System.Collections.Generic;
using UnityEngine;

public class TabTalentGroup : MonoBehaviour
{
    public List<TabTalentButton> TabTalentButton;
    public Sprite tabIdle;
    public Sprite tabActive;
    private TabTalentButton selectedTab;
    private EnemyController _enemyController;
    private PlayerController _playerController;
     
    void Start()
    {
        _enemyController = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyController>();
        _playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    public void Subscribe(TabTalentButton button)
    {
        if (TabTalentButton == null)
        {
            TabTalentButton = new List<TabTalentButton>();
            TabTalentButton.Add(button);
        }
    }

    public void OnTabSelected(TabTalentButton button)
    {
        selectedTab = button;
        selectedTab.isSelected = !selectedTab.isSelected;
        Debug.Log($"{selectedTab.isSelected}");

        ResetTabs();
        ReturnID();
        button.background.sprite = tabActive;
       
    }

    public void ResetTabs()
    {
        foreach (TabTalentButton button in TabTalentButton)
        {
            if (selectedTab != null && button == selectedTab)
            {
                continue;
            }
            button.background.sprite = tabIdle;
            button.isSelected = false;
        }
    }

    public void ReturnID()
    {
        foreach (TabTalentButton button in TabTalentButton)
        {
            if (button.isSelected)
            {

                TalentButtonAction(button.TabID) ;
            }
        }
    }

    public void TalentButtonAction(int ID)
    {
        switch (ID)
        {
            case 1: Debug.Log($"{ID}");   
                break;
            case 2:
                Debug.Log($"{ID}");
                break;
            case 3:
                Debug.Log($"{ID}");
                break;
            case 4:
                Debug.Log($"{ID}");
                break;
            case 5:
                Debug.Log($"{ID}");
                break;
            case 6:
                Debug.Log($"{ID}");
                break;
            case 7:
                Debug.Log($"{ID}");
                break;
            case 8:
                Debug.Log($"{ID}");
                break;
            case 9:
                Debug.Log($"{ID}");
                break;
            case 10:
                Debug.Log($"{ID}");
                break;
            case 11:
                Debug.Log($"{ID}");
                break;
            case 12:
                Debug.Log($"{ID}");
                break;
            case 13:
                Debug.Log($"{ID}");
                break;
            case 14:
                Debug.Log($"{ID}");
                break;
            case 15:
                Debug.Log($"{ID}");
                break;
            case 16:
                Debug.Log($"{ID}");
                break;
            case 17:
                Debug.Log($"{ID}");
                break;
            case 18:
                Debug.Log($"{ID}");
                break;
            case 19:
                Debug.Log($"{ID}");
                break;
            case 20:
                Debug.Log($"{ID}");
                break;
            case 21:
                Debug.Log($"{ID}");
                break;
        }
    }
}
