using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//MUST also have Attacker component
[RequireComponent(typeof(Attacker))]

public class AttLizard : MonoBehaviour
{

    private Animator anim;
    private Attacker attacker;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        attacker = GetComponent<Attacker>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject collidedobject = collider.gameObject;

        //leave method if not colliding with defender
        if (!collidedobject.GetComponent<Defender>())
        {
            return;
        }
        else
        {
            anim.SetBool("isAttacking", true);
            attacker.Attack(collidedobject);
        }

        Debug.Log("fox collided with " + collider);
    }
}
