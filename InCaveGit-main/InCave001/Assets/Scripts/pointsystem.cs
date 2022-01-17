using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointsystem : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ScoreGenerator.yildizpuani_int += 1;
            Destroy(this.gameObject);

        }

    }
}