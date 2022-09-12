using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MoveController
{
    public float minDistance = .25f;

    private Player target;

    protected override void Move()
    {
        if (target == null)
            target = FindObjectOfType<Player>();

        if (!GameManager.Pause && (target.transform.position - transform.position).magnitude > minDistance)
        {
            move = (target.transform.position - transform.position).normalized;
        }
        else
        {
            move = Vector3.zero;
        }

        base.Move();
    }
}
