using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace CLICKER2D
{
    public class EnemyController : BaseUnit
    {
        private PlayerController _playerController;
        public Slider HpSlider;
        public TextMeshProUGUI DamageText;
        public TextMeshProUGUI CurrentMaxSliderText;
        public TextMeshProUGUI TotalMoneyText;
        private Animator _animator;

        public GameObject TextParent;
        public GameObject TextDamage;
        private ClickDamageText[] clickTextPool = new ClickDamageText[7];
        private int _clickNum;

        public int DeadMonsterCounter;

        void Start()
        {
            Damage = 1;
            CurrentHealth = MaxHealth;
            _playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
            _animator = GetComponent<Animator>();

            for (int i = 0; i < clickTextPool.Length; i++)
            {
                clickTextPool[i] = Instantiate(TextDamage, TextParent.transform).GetComponent<ClickDamageText>();
                clickTextPool[i].gameObject.SetActive(false);
            }

        }

        void Update()
        {
            CurrentMaxSliderText.text = $"Enemy HP: {(int)CurrentHealth}/{(int)MaxHealth}";
            TotalMoneyText.text = $"Total Gold: {(int)_playerController.GoldCounter}";
        }
        public override void Die()
        {
            GetComponent<Image>().color = new Color(
                                                                 Random.Range(0, 1f),
                                                                 Random.Range(0, 1f),
                                                                 Random.Range(0, 1f) );
            DeadMonsterCounter++;
            MaxHealth += Mathf.RoundToInt(MaxHealth * 1.07f- MaxHealth);
            CurrentHealth = MaxHealth;
            _playerController.GoldCounter += Mathf.RoundToInt( MaxHealth / 10);
            HpSlider.maxValue = MaxHealth;
            _playerController.AddExp();

        }



        public override void TakeDamage(float damage)
        {
            _animator.SetTrigger("attacked");
            CurrentHealth -= damage;
            _clickNum = _clickNum == clickTextPool.Length - 1 ? 0 : _clickNum + 1;
            clickTextPool[_clickNum].gameObject.SetActive(true);
            clickTextPool[_clickNum].DamageText(damage);
            clickTextPool[_clickNum].timer = 0.4f;

        }
    }
}

