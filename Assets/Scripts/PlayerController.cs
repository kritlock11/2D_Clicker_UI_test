using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CLICKER2D
{
    public class PlayerController : BaseUnit
    {
        public int currLevel;
        public int maxLevel;
        private float goldCounter;
        public float currExp;
        public float[] NextLvlExp;
        private EnemyController _enemyController;

        public Slider slider;
        public TextMeshProUGUI EXPText;


        public float GoldCounter
        {
            get => goldCounter;
            set
            {
                goldCounter = value;
                if (goldCounter<=0)
                {
                    goldCounter = 0;
                }
            }
        }

        void Start()
        {
            NextLvlExp = new float[maxLevel];
            NextLvlExp[0] = 20;
            for (int i = 1; i < maxLevel; i++)
            {
                NextLvlExp[i] = NextLvlExp[i - 1] * 1.2f;
            }
            goldCounter = 0;
            Damage = 1;
            currLevel = 1;
            slider.maxValue = NextLvlExp[currLevel];
            slider.value = currExp;
            CurrentHealth = MaxHealth;
            EXPText.text = $"LVL:{currLevel}      {(int)currExp}/{(int)NextLvlExp[currLevel]}";


            _enemyController = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyController>();

        }

        public void AddExp()
        {
            currExp += _enemyController.MaxHealth/5;
            if (currExp >= NextLvlExp[currLevel])
            {
                LevelUp();
            }
            slider.maxValue = NextLvlExp[currLevel];
            slider.value = currExp;
            EXPText.text = $"LVL:{currLevel}      {(int)currExp}/{(int)NextLvlExp[currLevel]}";
        }

        private void LevelUp()
        {
            currExp -= NextLvlExp[currLevel];
            currLevel++;
        }

        void Update()
        {

        }
        public override void Die()
        {
        }



        public override void TakeDamage(float damage)
        {
        }
    }
}
