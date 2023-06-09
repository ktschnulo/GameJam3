using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwap : MonoBehaviour
{
    public string currRealm = "Dream";
    public GameObject escMenu;

    //audio 
    public AudioSource nmMusic;
    public AudioSource drMusic;

    //pos
    public float xpos;
    public float ypos;
    public float zpos;

    //puzzle 5
    public bool onRestrictedPath;
    public GameObject restrictInteractText;

/*
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "restrict")
        {
            onRestrictedPath = true;
            restrictInteractText.SetActive(true);
        }

    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "restrict")
        {
            onRestrictedPath = false;
            restrictInteractText.SetActive(false);
        }
    }
    */
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "restrict")
        {
            if(other.gameObject.tag != "Ground")
            {
                onRestrictedPath = true;
                restrictInteractText.SetActive(true);
            }
            else
            {
                onRestrictedPath = false;
                restrictInteractText.SetActive(false);
            }
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "restrict")
        {
            onRestrictedPath = false;
            restrictInteractText.SetActive(false);
        }
    }

    void Update()
    {
        //position
        xpos = transform.position.x;
        ypos = transform.position.y;
        zpos = transform.position.z;

        //ESC
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (escMenu.activeSelf == false){
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                escMenu.SetActive(true);
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                escMenu.SetActive(false);
            }
        }

        //swaps  //grounded removed temporarily
        if (Input.GetKeyDown(KeyCode.Q) && onRestrictedPath != true)
        {
            if (currRealm.Equals("Dream"))
            {
                if (transform.position.z > 20 && transform.position.z < 24)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - 145, transform.position.z);
                }
                else if (transform.position.z > -15 && transform.position.z < -9)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - 145, transform.position.z);
                }
                else
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - 149, transform.position.z);
                }
                currRealm = "Nightmare";
                nmMusic.Play();
                drMusic.Pause();
            }
            else if (currRealm.Equals("Nightmare"))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + 151, transform.position.z);
                currRealm = "Dream";
                drMusic.Play();
                nmMusic.Pause();
            }
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            if (currRealm.Equals("Dream"))
            {
                transform.position = new Vector3(2.5f, 160f, 77f);
            }
            else
            {
                transform.position = new Vector3(2.5f, 5f, 77f);
            }
        }
    }
}
