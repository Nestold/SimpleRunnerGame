using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    public CharacterConfig Config { get; protected set; } = null;

    [Header("Settings")]
    [SerializeField] protected private float damageDelay = 1f;

    [Header("References")]
    public ModelController Model = null;
    [SerializeField] protected LifeController lifeController = null;

    public void GetDamage(float amount)
    {

    }

    public virtual void Setup(CharacterConfig characterConfig)
    {
        Config = characterConfig;
        Model.Setup(Config.Prefab);
        lifeController.Setup(Config);
    }
}