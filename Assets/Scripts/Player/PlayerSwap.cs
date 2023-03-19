using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwap : MonoBehaviour
{
    public string currRealm = "Dream";
    void Update()
    {
        //swaps
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (currRealm.Equals("Dream"))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - 149, transform.position.z);
                currRealm = "Nightmare";
            }
            else if (currRealm.Equals("Nightmare"))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + 151, transform.position.z);
                currRealm = "Dream";
            }
        }
    }
}
