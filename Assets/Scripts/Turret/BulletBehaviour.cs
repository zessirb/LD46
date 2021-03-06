﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float speed;
    public float force = 150;

    [SerializeField]
    private Transform targetPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collider){
        if (collider.tag.Equals("Dodo")) {
            DodoManager dodoManager = collider.GetComponent<DodoManager>();
            dodoManager.PushInDirection(targetPoint.position - transform.position, force);
        }
        if (collider.GetComponent<Rigidbody2D>() != null)
            Destroy(gameObject);
    }
}
