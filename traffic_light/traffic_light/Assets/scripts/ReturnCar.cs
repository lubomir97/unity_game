using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnCar : MonoBehaviour {

	// Use this for initialization

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "car")

            Destroy(other.gameObject);
        }
    }

