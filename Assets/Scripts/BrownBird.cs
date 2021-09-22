using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrownBird : Bird
{
    [SerializeField] private float _explodeForce = 10;
    [SerializeField] private GameObject explosion;
    // public bool _hasExplode = false;

    public override void OnCollisionEnter2D(Collision2D col)
    {
        if(col.transform.GetComponent<Rigidbody2D>()){
            col.rigidbody.AddForce(col.transform.position * _explodeForce);
            Instantiate(explosion, col.transform);
        }
        Destroy(gameObject);
    }
}