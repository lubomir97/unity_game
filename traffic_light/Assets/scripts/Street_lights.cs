using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Street_lights : MonoBehaviour {

    public GameObject[] obj;

    public GameObject light1;
    public GameObject light2;



    // Use this for initialization
    void Start()
    {

        StartCoroutine(SpawnLights());
        /*light2.transform.localPosition = new Vector2(12, 11);
        light2.transform.localRotation = Quaternion.Euler(0, 0, 90);   
        */
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator SpawnLights()
    {
        bool repeat = true;

        while (repeat)
        {
            light1 = Instantiate(obj[0], obj[0].transform.position, Quaternion.identity) as GameObject;

            light2 = Instantiate(obj[2], obj[2].transform.position, Quaternion.identity) as GameObject;
            light2.transform.localPosition = new Vector2(12, 11);
            light2.transform.localRotation = Quaternion.Euler(0, 0, 90);

            yield return new WaitForSeconds(20);
            Destroy(light1);
            Destroy(light2);

            light1 = Instantiate(obj[1], obj[1].transform.position, Quaternion.identity) as GameObject;

            light2 = Instantiate(obj[1], obj[1].transform.position, Quaternion.identity) as GameObject;
            light2.transform.localPosition = new Vector2(12, 11);
            light2.transform.localRotation = Quaternion.Euler(0, 0, 90);

            yield return new WaitForSeconds(5);
            Destroy(light1);
            Destroy(light2);

            light1 = Instantiate(obj[2], obj[2].transform.position, Quaternion.identity) as GameObject;

            light2 = Instantiate(obj[0], obj[0].transform.position, Quaternion.identity) as GameObject;
            light2.transform.localPosition = new Vector2(12, 11);
            light2.transform.localRotation = Quaternion.Euler(0, 0, 90);

            yield return new WaitForSeconds(30);
            Destroy(light1);
            Destroy(light2);

            light1 = Instantiate(obj[1], obj[1].transform.position, Quaternion.identity) as GameObject;

            light2 = Instantiate(obj[1], obj[1].transform.position, Quaternion.identity) as GameObject;
            light2.transform.localPosition = new Vector2(12, 11);
            light2.transform.localRotation = Quaternion.Euler(0, 0, 90);

            yield return new WaitForSeconds(5);
            Destroy(light1);
            Destroy(light2);
        }
    }
}
