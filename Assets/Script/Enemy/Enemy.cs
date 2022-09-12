using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
    [SerializeField] private CharacterConfig characterConfig = null;
    private void Start()
    {
        Setup(characterConfig);
    }
}