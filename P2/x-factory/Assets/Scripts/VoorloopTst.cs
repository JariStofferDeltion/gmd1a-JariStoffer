using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoorloopTst : MonoBehaviour {

    public List <GameObject> objects = new List <GameObject> ();
    public int toSpawn;

	// Use this for initialization
	void Start () {

        for (int i = 0; i < 10 ; i++ ) {
            toSpawn = Random.Range(0, objects.Count);
            Instantiate(objects[toSpawn], new Vector3(Random.Range(0,10), Random.Range(0,10), Random.Range(0,10)), Quaternion.identity);
        }

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("1"))
        {
            
        }


        else if (Input.GetKeyDown("2"))
        {

        }
        

        else if (Input.GetKeyDown("3"))
        {

        }
        	
	}
}
