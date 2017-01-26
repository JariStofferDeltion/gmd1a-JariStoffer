using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour
{

    public Enemy vijand;
    public Animation gunRecoil;




    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Debug.DrawRay(transform.position, transform.forward * 100, Color.red);


        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(transform.position, transform.forward * 100))
            {
                vijand.hp -= 10;
            }
            gunRecoil.Play("gun recoil");
        }


    }
}



