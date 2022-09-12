using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MoveController
{
    [SerializeField] private VariableJoystick joystick = null;
    [SerializeField] private float heightChangeSpeed = 2f;

    private float targetHeight;
    private CapsuleCollider capsuleCollider;

    protected override void Awake()
    {
        base.Awake();
        capsuleCollider = GetComponent<CapsuleCollider>();
        targetHeight = capsuleCollider.height;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            Slide();
        }

        if(capsuleCollider.height > targetHeight)
        {
            capsuleCollider.height -= Time.deltaTime * heightChangeSpeed;
        }
        else if(capsuleCollider.height < targetHeight)
        {
            capsuleCollider.height += Time.deltaTime * heightChangeSpeed;
        }
    }

    protected override void Move()
    {
        if(!GameManager.Pause)
        {
            move = new Vector3(
                joystick.Direction.x,
                0f,
                joystick.Direction.y);

            if(move == Vector3.zero)
            {
                move = new Vector3(Input.GetAxis("Horizontal"),
                    0f,
                    Input.GetAxis("Vertical"));
            }
        }
        else
        {
            move = Vector3.zero;
        }

        base.Move();
    }

    public void SetHeight(float height)
    {
        targetHeight = height;
    }
    public void RestartPosition()
    {
        transform.position = new Vector3(0f, .5f, 0f);
        transform.rotation = Quaternion.Euler(0f, 45f, 0f);
    }
}