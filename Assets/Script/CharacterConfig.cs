using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/CharacterConfig")]
public class CharacterConfig : ScriptableObject
{
    [Header("Statistics")]
    public float Health = 100;
    public float MovementSpeed = 5;
    public float ContactDamage = 5;
    [Header("Model")]
    public GameObject Prefab = null;
}