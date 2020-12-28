using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private Image      _healthBar;
    [SerializeField] private Text       _healthText;
    
    private float _health = 0f;
    private float _maxHealth = 100f;

    public float health

    {
        get => _health;
    }

    // Start is called before the first frame update
    protected void Start()
    {
        _health = _maxHealth;
       
    }

    public void UpdateHealthBar()
    {
        float fill = _health / _maxHealth;
        if(_healthBar != null)
        {
            _healthBar.fillAmount = fill;
        }
    }    
    
    public void UpdateHealthText()
    {
        if(_healthText != null)
        {
            _healthText.text = _health.ToString();
        }
    }

    public void Heal(float healAmount)
    {
        _health = Mathf.Min(_health + healAmount, 100f);
        UpdateHealthBar();
        UpdateHealthText();
    }

    public void TakeDamage(float damage)
    {
        _health = Mathf.Max(_health - damage, 0f);
        UpdateHealthBar();
        UpdateHealthText();
    }
}
