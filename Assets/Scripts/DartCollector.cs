using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartCollector : MonoBehaviour
{
    public GameObject collectText;
    /*public GameObject dartShoot;*/

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Dart")
        {
            collectText.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            collision.gameObject.SetActive(false);
            /*dartShoot.SetActive(true);*/
        }
    }
    
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Dart")
        {
            collectText.SetActive(false);
        }
    }
}
