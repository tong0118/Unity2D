﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 10f;
    private ProjectileManager projectileMG_;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
    }

    public void SetMyManager(ProjectileManager projectileMG) {
        projectileMG_ = projectileMG;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(projectileMG_ != null)
        {
            projectileMG_.DecrementProjectileCount();
        }
        else 
        {
            Debug.LogError("No Projectile Manager");
        }
        Destroy(gameObject);
    }
}
