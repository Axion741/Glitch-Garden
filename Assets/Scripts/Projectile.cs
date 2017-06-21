using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public float Speed;
    public float Damage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * Speed *  Time.deltaTime);
	}

    private void ProjectileStrike ()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D impact)
    {
        GameObject collidedobject = impact.gameObject;

        //leave method if not colliding with attacker
        if (!collidedobject.GetComponent<Attacker>())
        {
            return;
        }
        else
        {
            Health health = collidedobject.GetComponent<Health>();
            if (health)
            {
                health.DealDamage(Damage);
            }
            Destroy(gameObject);
        }                
    }

    
}

