using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour {

    public float speed = 30f;
    public bool shouldMove = true;
    Street_lights str;

    public Vector2 direction;

    void Update()
    {
        if (shouldMove)
        {
            MoveCar();
        }

    }

    void MoveCar()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}

