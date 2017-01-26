using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

    public int hp = 1000;



    // Update is called once per frame
    public void Update()
    {

        if (hp <= 0)
        {
            Destroy(gameObject);
        }



    }
    public void DealDamage(int damage)
    {
        hp -= damage;
        print(hp);
    }
}