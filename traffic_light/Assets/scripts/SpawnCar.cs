﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCar : MonoBehaviour {

    public GameObject car;
    public GameObject create;
    public float spawn_time;
     
	void Start () {

        InvokeRepeating("Spawn_timer", spawn_time, spawn_time);
	}

    void Spawn_timer()
    {
        GameObject obj = Instantiate(car, create.transform.position, Quaternion.identity) as GameObject;

    }
}