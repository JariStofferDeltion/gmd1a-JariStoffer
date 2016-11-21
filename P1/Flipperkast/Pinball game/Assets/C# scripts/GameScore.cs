using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{

    public void OnCollisionEnter(Collision collision)
    {
        if (gameObject.tag == "Bumper")
        {
            GameScore2.scoreGainUp += 10;
        }
    }
}
