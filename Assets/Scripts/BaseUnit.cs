using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CLICKER2D
{
    public abstract class BaseUnit : MonoBehaviour
    {
        [SerializeField] private float _damage;
        [SerializeField] private float _maxHealth;
         public float Damage { get => _damage; set => _damage = value; }
         public float MaxHealth { get => _maxHealth; set => _maxHealth = value; }


        private float _currentHealth;
        public float CurrentHealth
        {
            get { return _currentHealth; }
            set
            {
                _currentHealth = value;
                if (_currentHealth <= 0)
                {
                    Die();
                }
                else if (_currentHealth > _maxHealth)
                {
                    _currentHealth= _maxHealth;
                }
            }
        }


        public abstract void Die();
        public abstract void TakeDamage(float damage);









    }
}
