using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLifeController : LifeController
{
    public override void OnDeath()
    {
        base.OnDeath();
        Destroy(gameObject);
    }
}
