using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionScript : MonoBehaviour
{
    public GameObject fireText;
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "water" || collision.gameObject.tag == "waterFloor")
        {
            transform.position = new Vector3(-54f, 146f, 42f);
        }
        if (collision.gameObject.tag == "mountain")
        {
            transform.position = new Vector3(2.5f, 146f, 77f);
        }
        if (collision.gameObject.tag == "fog")
        {
            transform.position = new Vector3(-54f, -4f, 42f);
        }
        if (collision.gameObject.tag == "fire" || collision.gameObject.tag == "fire2" || collision.gameObject.tag == "fire3")
        {
            if(collision.gameObject.tag == "fire")
            {
                transform.position = new Vector3(2.78f, 6.6f, -17.03f);
            }
            else if(collision.gameObject.tag == "fire2")
            {
                transform.position = new Vector3(12.04f, 6.6f, -32.15f);
            }
            else
            {
                transform.position = new Vector3(-8.6f, 4.7f, -37.57f);
            }
            fireText.SetActive(true);
            Invoke("removeText", 3);
        }

        /*parkour course reset*/

        if (collision.gameObject.tag == "watercave")
        {
            transform.position = new Vector3(38f, -7f, 33f);
        }
        if (collision.gameObject.tag == "waterdream")
        {
            transform.position = new Vector3(37f, 142f, 35f);
        }
    }

    void removeText()
    {
        fireText.SetActive(false);
    }
}
