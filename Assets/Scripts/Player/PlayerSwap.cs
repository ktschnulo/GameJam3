using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwap : MonoBehaviour
{
    void Update()
    {
        //swaps
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.position = new Vector3(transform.position.x * -1, transform.position.y, transform.position.z);
        }
    }
}
