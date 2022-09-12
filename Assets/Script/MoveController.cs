using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoveController : MonoBehaviour
{
    public bool InAir => rb.velocity.y < -.05f || rb.velocity.y > .05f;

    [SerializeField] private float addtitionalForcePower = 10f;

    protected CharacterController cc;
    protected Rigidbody rb;
    protected Vector3 move;

    private Entity entity;

    protected virtual void Awake()
    {
        cc = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
        entity = GetComponent<Entity>();
    }
    protected virtual void Move()
    {
        if(rb.velocity.magnitude < entity.Config.MovementSpeed)
        {
            rb.AddForce(move * addtitionalForcePower * (InAir ? .5f : 1f));
        }
        transform.LookAt(transform.position + move);
        entity.Model.Animator.SetFloat("Speed", rb.velocity.magnitude / 10);
        entity.Model.Animator.SetFloat("YSpeed", Mathf.Abs(rb.velocity.y));
    }

    public void Jump()
    {
        if(!InAir)
        {
            entity.Model.Animator.SetTrigger("Jump");
            rb.AddForce(transform.up * 15f, ForceMode.Impulse);
        }
    }
    public void Slide()
    {
        if (!InAir && rb.velocity.magnitude < entity.Config.MovementSpeed + .25f)
        {
            entity.Model.Animator.SetTrigger("Slide");
            rb.AddForce(transform.forward * 10f, ForceMode.Impulse);
        }
    }

    private void FixedUpdate()
    {
        Move();
    }
}