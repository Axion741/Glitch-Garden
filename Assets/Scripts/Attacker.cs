﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour {
    private Animator anim;
   
    private float currentSpeed;
    private GameObject currentTarget;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        
        transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
        if (!currentTarget)
        {
            anim.SetBool("isAttacking", false);
        }
	}

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
        //Debug.Log(name + " trigger enter");
    //}

    public void SetSpeed (float speed)
    {
        currentSpeed = speed;
    }

    //called from animator at attack
    public void StrikeCurrentTarget (float damage)
    {
        if (currentTarget)
        {
            Health health = currentTarget.GetComponent<Health>();
            if (health)
            {
                health.DealDamage(damage);
            }
        }
        
    }


    public void Attack (GameObject obj)
    {
        currentTarget = obj;
    }
}
