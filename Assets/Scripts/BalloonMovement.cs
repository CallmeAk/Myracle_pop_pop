using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonMovement : MonoBehaviour
{
    public float ballSpeed;

    void Update()
    {
        transform.position += new Vector3(0,ballSpeed*Time.deltaTime ,0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="TopLimit")
        {
            Destroy(this.gameObject);
        }

        else if (collision.gameObject.tag=="Dart")
        {
            Destroy(this.gameObject);
            ScoreManager.score += 5;
        }

    }
}
