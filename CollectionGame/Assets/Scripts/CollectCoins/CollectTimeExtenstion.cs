﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectTimeExtenstion : MonoBehaviour
{
    public float despawn = 0.00f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Timer.timeLeft += 5f;
            Destroy(gameObject);
        }
    }
}
