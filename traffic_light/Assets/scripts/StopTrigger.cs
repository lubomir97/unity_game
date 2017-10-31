using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTrigger : MonoBehaviour {

    Street_lights str;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "car" && str.light2.tag == "red")
        {
            other.transform.Translate(Vector2.zero);
        }
    }
}
