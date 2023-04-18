using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backButton : MonoBehaviour
{
    public GameObject camera;

    // Update is called once per frame
    public void zoomOutCam()
    {
        while (camera.transform.position.x < 10 || camera.transform.position.y < 212)
        {
            if (camera.transform.position.x < 10)
            {
                camera.transform.position = new Vector3(camera.transform.position.x + .01f, camera.transform.position.y, camera.transform.position.z);
            }
            if (camera.transform.position.y < 212)
            {
                camera.transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y + .01f, camera.transform.position.z);
            }
        }
    }
}
