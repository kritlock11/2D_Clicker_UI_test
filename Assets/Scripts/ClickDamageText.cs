using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickDamageText : MonoBehaviour
{
    private bool move;
    private Vector2 _upVector;
    public float timer = 0.4f;

    private void Update()
    {
        if (!move) return;
        transform.Translate(_upVector*Time.deltaTime);
        if (timer<=0)
        {
            gameObject.SetActive(false);
        }
        else
        {
            timer -= Time.deltaTime;
        }
        
    }
    public void DamageText(float damage)
    {
        transform.localPosition = Vector2.zero; 
        GetComponent<TextMeshProUGUI>().text = $"{damage}";
        _upVector = Vector2.up;
        move = true;
    }

    private void OnEnable()
    {
        
    }

}
