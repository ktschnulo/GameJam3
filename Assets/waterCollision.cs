using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "water")
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
    }

    // Update is called once per frame
    void Update()
    {

    }
}
