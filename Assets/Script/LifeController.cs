using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LifeController : MonoBehaviour
{
    [SerializeField] private UIDamageText damageText = null;

    private CharacterConfig config;
    protected float currentHealth;

    public virtual void Setup(CharacterConfig config)
    {
        this.config = config;
        currentHealth = this.config.Health;
    }

    public virtual void AddLife(float amount)
    {
        currentHealth += amount;

        if (currentHealth > config.Health)
            currentHealth = config.Health;
    }
    public virtual void RemoveLife(float amount)
    {
        currentHealth -= amount;
        var dText = Instantiate(damageText, transform.position + new Vector3(0f, 1f, 0f), 
            Quaternion.identity, null);
        dText.SetText(amount.ToString());
        
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            OnDeath();
        }
    }

    public virtual void OnDeath()
    {

    }
}
