﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDestroyer : MonoBehaviour
{
     private void OnTriggerEnter2D(Collider2D other)
    {  
        if (other.gameObject.GetComponent<Projectile>())
        {
            Destroy(other.gameObject);
        }
           
    }
}
