using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLifeController : LifeController
{
    public override void Setup(CharacterConfig config)
    {
        base.Setup(config);
    }

    public override void AddLife(float amount = 1)
    {
        base.AddLife(amount);
    }
    public override void RemoveLife(float amount = 1)
    {
        base.RemoveLife(amount);
    }

    public override void OnDeath()
    {
        base.OnDeath();
        FindObjectOfType<GameManager>().GameOver();
    }
}