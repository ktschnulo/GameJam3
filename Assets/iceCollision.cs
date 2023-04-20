using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iceCollision : MonoBehaviour
{
    bool iceCol = false;
    bool barCol = false;
    Vector3 moveDirection;
    public Transform orientation;


    public void Update()
    {
        if (!iceCol)
        {
            if (Math.Abs(orientation.forward.x) > Math.Abs(orientation.forward.z))
            {
                if (orientation.forward.x < 0)
                {
                    moveDirection = new Vector3(-1, 0, 0);
                }
                else
                {
                    moveDirection = new Vector3(1, 0, 0);

                }
            }
            else
            {
                if (orientation.forward.z < 0)
                {
                    moveDirection = new Vector3(0, 0, -1);
                }
                else
                {
                    moveDirection = new Vector3(0, 0, 1);

                }
            }
            if (Input.GetAxisRaw("Vertical") == 1 && barCol)
            {
                this.GetComponent<Rigidbody>().velocity = moveDirection * 10;
            }
        }
        else
        {
            this.GetComponent<Rigidbody>().velocity = moveDirection * 10;
        }
        Debug.Log(this.GetComponent<Rigidbody>().velocity);
    }

    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "ice")
        {
            iceCol = true;
            barCol = false;
            this.GetComponent<movement>().enabled = false;
            //this.GetComponent<PlayerSwap>().enabled = false;
            Debug.Log("ice");
        }
        if (collision.gameObject.tag == "iceBarrier")
        {
            barCol = true;
            this.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
            iceCol = false;
            Debug.Log("iceBarrier");
        }
        if (collision.gameObject.tag == "land")
        {
            barCol = false;
            iceCol = false;
            this.GetComponent<movement>().enabled = true;
            //this.GetComponent<PlayerSwap>().enabled = true;
            Debug.Log("land");
        }
    }
}
