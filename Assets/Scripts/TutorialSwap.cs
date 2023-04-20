using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialSwap : MonoBehaviour
{
    public string currRealm = "Nightmare";

    //audio 
    public AudioSource nmMusic;
    public AudioSource drMusic;

    //pos
    public float xpos;
    public float ypos;
    public float zpos;

    //speech
    public GameObject speechBubble;
    public GameObject tutorialManTextContinue;
    public GameObject tutorialManText5;
    public GameObject tutorialManText6;

    public GameObject player;
    public GameObject playerCam;

    public bool canSwap = false;

    void Update()
    {
        //position
        xpos = transform.position.x;
        ypos = transform.position.y;
        zpos = transform.position.z;

        //swaps
        if (Input.GetKeyDown(KeyCode.Q) && GetComponent<movement>().grounded == true)
        {
            if (canSwap == true){

                //remove speech bubble
                speechBubble.SetActive(false);
                tutorialManTextContinue.SetActive(false);
                tutorialManText5.SetActive(false);
                tutorialManText6.SetActive(false);

                //unlock movement
                player.GetComponent<movement>().movementLocked = false;
                playerCam.GetComponent<PlayerCam>().camLocked = false;

                if (currRealm.Equals("Dream"))
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - 50, transform.position.z);
                    currRealm = "Nightmare";
                    nmMusic.Play();
                    drMusic.Pause();
                }
                else if (currRealm.Equals("Nightmare"))
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y + 50, transform.position.z);
                    currRealm = "Dream";
                    drMusic.Play();
                    nmMusic.Pause();
                }
            }
        }
    }
}
