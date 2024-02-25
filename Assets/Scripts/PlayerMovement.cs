using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float normalspeed = 3f;
    public float sprintspeed = 6f;
    public float currentspeed;
    public bool isSprinting;

    Vector3 velocity;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            isSprinting = true;
        }
        else
        {
            isSprinting = false;
        }

        if (isSprinting == true)
        {
            currentspeed = sprintspeed;
        }
        else
        {
            currentspeed = normalspeed;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * currentspeed * Time.deltaTime);

        


    }
}
