using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optionsButton : MonoBehaviour
{
    public GameObject camera;

    // Update is called once per frame
    public void zoomCam()
    {
        while (camera.transform.position.x > 5 || camera.transform.position.y > 206)
        {
            if (camera.transform.position.x > 5)
            {
                camera.transform.position = new Vector3(camera.transform.position.x - .01f, camera.transform.position.y, camera.transform.position.z);
            }
            if (camera.transform.position.y > 206)
            {
                camera.transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y - .01f, camera.transform.position.z);
            }
        }
    }
}
