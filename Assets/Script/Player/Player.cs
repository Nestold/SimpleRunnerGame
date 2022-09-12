using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    public override void Setup(CharacterConfig characterConfig)
    {
        base.Setup(characterConfig);
        GetComponent<PlayerController>().RestartPosition();
    }
}