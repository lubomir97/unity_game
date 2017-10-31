using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{

    private float maxspeed = 30f;

    public Vector2 direction;

    void Update()
    {
        transform.Translate(direction * maxspeed * Time.deltaTime);
    }
}