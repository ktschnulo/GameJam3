using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinaleInteract : MonoBehaviour
{
    [Header("Crystals")]
    public GameObject crystalRed;
    public GameObject crystalOrange;
    public GameObject crystalYellow;
    public GameObject crystalGreen;
    public GameObject crystalBlue;
    public GameObject crystalPurple;
    public GameObject crystalPink;
    public GameObject crystalBlack;

    [Header("Beams")]
    public GameObject beamRed;
    public GameObject beamOrange;
    public GameObject beamYellow;
    public GameObject beamGreen;
    public GameObject beamBlue;
    public GameObject beamPurple;
    public GameObject beamPink;
    public GameObject beamBlack;

    [Header("Materials")]
    public Material matRed;
    public Material matOrange;
    public Material matYellow;
    public Material matGreen;
    public Material matBlue;
    public Material matPurple;
    public Material matPink;
    public Material matBlack;

    [Header("In Reach")]
    public bool inReachRed;
    public bool inReachOrange;
    public bool inReachYellow;
    public bool inReachGreen;
    public bool inReachBlue;
    public bool inReachPurple;
    public bool inReachPink;
    public bool inReachBlack;

    [Header("Door")]
    public GameObject door;
    public bool inReachExitDoor;

    [Header("Other")]
    public GameObject interactText;
    public GameObject interactText2;
    public GameObject crystalPlayer;
    public int crystalPlayerNum;

    // Start is called before the first frame update
    void Start()
    {
        crystalPlayerNum = 1;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RedPed" && crystalRed.activeSelf == false)
        {
            inReachRed = true;
            interactText.SetActive(true);
        }
        else if (other.gameObject.tag == "OrangePed" && crystalOrange.activeSelf == false)
        {
            inReachOrange = true;
            interactText.SetActive(true);
        }
        else if (other.gameObject.tag == "YellowPed" && crystalYellow.activeSelf == false)
        {
            inReachYellow = true;
            interactText.SetActive(true);
        }
        else if (other.gameObject.tag == "GreenPed" && crystalGreen.activeSelf == false)
        {
            inReachGreen = true;
            interactText.SetActive(true);
        }
        else if (other.gameObject.tag == "BluePed" && crystalBlue.activeSelf == false)
        {
            inReachBlue = true;
            interactText.SetActive(true);
        }
        else if (other.gameObject.tag == "PurplePed" && crystalPurple.activeSelf == false)
        {
            inReachPurple = true;
            interactText.SetActive(true);
        }
        else if (other.gameObject.tag == "PinkPed" && crystalPink.activeSelf == false)
        {
            inReachPink= true;
            interactText.SetActive(true);
        }
        else if (other.gameObject.tag == "BlackPed" && crystalBlack.activeSelf == false)
        {
            inReachBlack = true;
            interactText.SetActive(true);
        }
        else if (other.gameObject.tag == "ExitDoor")
        {
            inReachExitDoor = true;
            interactText2.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "RedPed")
        {
            inReachRed = false;
            interactText.SetActive(false);
        }
        else if (other.gameObject.tag == "OrangePed")
        {
            inReachOrange = false;
            interactText.SetActive(false);
        }
        else if (other.gameObject.tag == "YellowPed")
        {
            inReachYellow = false;
            interactText.SetActive(false);
        }
        else if (other.gameObject.tag == "GreenPed")
        {
            inReachGreen = false;
            interactText.SetActive(false);
        }
        else if (other.gameObject.tag == "BluePed")
        {
            inReachBlue = false;
            interactText.SetActive(false);
        }
        else if (other.gameObject.tag == "PurplePed")
        {
            inReachPurple = false;
            interactText.SetActive(false);
        }
        else if (other.gameObject.tag == "PinkPed")
        {
            inReachPink= false;
            interactText.SetActive(false);
        }
        else if (other.gameObject.tag == "BlackPed")
        {
            inReachBlack = false;
            interactText.SetActive(false);
        }
        else if (other.gameObject.tag == "ExitDoor")
        {
            inReachExitDoor = false;
            interactText2.SetActive(false);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        if (beamBlack.activeSelf == true){
            if (door.transform.position.y < 0){
                door.transform.Translate(Vector3.up * 0.5f * Time.deltaTime);
            }
            else{
                beamRed.SetActive(false);
                beamOrange.SetActive(false);
                beamYellow.SetActive(false);
                beamGreen.SetActive(false);
                beamBlue.SetActive(false);
                beamPurple.SetActive(false);
                beamPink.SetActive(false);
                beamBlack.SetActive(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (inReachRed){
                if (crystalPlayerNum == 1){
                    crystalRed.SetActive(true);
                    crystalPlayerNum++;
                    crystalPlayer.GetComponent<Renderer>().material = matBlue;
                }
                else{
                    //play wrong noise
                }
            }
            else  if (inReachOrange){
                if (crystalPlayerNum == 8){
                    crystalOrange.SetActive(true);
                    crystalPlayerNum++;
                    crystalPlayer.SetActive(false);
                    beamRed.SetActive(true);
                    beamOrange.SetActive(true);
                    beamYellow.SetActive(true);
                    beamGreen.SetActive(true);
                    beamBlue.SetActive(true);
                    beamPurple.SetActive(true);
                    beamPink.SetActive(true);
                    beamBlack.SetActive(true);
                }
                else{
                    //play wrong noise
                }
            }
            else  if (inReachYellow){
                if (crystalPlayerNum == 3){
                    crystalYellow.SetActive(true);
                    crystalPlayerNum++;
                    crystalPlayer.GetComponent<Renderer>().material = matBlack;
                }
                else{
                    //play wrong noise
                }
            }
            else  if (inReachGreen){
                if (crystalPlayerNum == 5){
                    crystalGreen.SetActive(true);
                    crystalPlayerNum++;
                    crystalPlayer.GetComponent<Renderer>().material = matPink;
                }
                else{
                    //play wrong noise
                }
            }
            else  if (inReachBlue){
                if (crystalPlayerNum == 2){
                    crystalBlue.SetActive(true);
                    crystalPlayerNum++;
                    crystalPlayer.GetComponent<Renderer>().material = matYellow;
                }
                else{
                    //play wrong noise
                }
            }
            else  if (inReachPurple){
                if (crystalPlayerNum == 7){
                    crystalPurple.SetActive(true);
                    crystalPlayerNum++;
                    crystalPlayer.GetComponent<Renderer>().material = matOrange;
                }
                else{
                    //play wrong noise
                }
            }
            else  if (inReachPink){
                if (crystalPlayerNum == 6){
                    crystalPink.SetActive(true);
                    crystalPlayerNum++;
                    crystalPlayer.GetComponent<Renderer>().material = matPurple;
                }
                else{
                    //play wrong noise
                }
            }
            else  if (inReachBlack){
                if (crystalPlayerNum == 4){
                    crystalBlack.SetActive(true);
                    crystalPlayerNum++;
                    crystalPlayer.GetComponent<Renderer>().material = matGreen;
                    
                }
                else{
                    //play wrong noise
                }
            }
            else  if (inReachExitDoor){
                SceneManager.LoadScene(0);
            }
        }
    }
}
