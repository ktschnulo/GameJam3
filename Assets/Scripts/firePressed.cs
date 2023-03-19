using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firePressed : MonoBehaviour
{
    public GameObject fireObj;
    public GameObject lightObj;
    public GameObject startBtn;
    private bool active = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && !active)
        {
            lightFire();
        }
    }

    private void lightFire()
    {
        fireObj.SetActive(true);
        lightObj.SetActive(true);
        startBtn.SetActive(true);
        active = true;
    }
}
