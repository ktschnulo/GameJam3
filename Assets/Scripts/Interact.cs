using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    //player
    public GameObject playerObj;

    //game controller
    public GameObject gameController;

    [Header("Audio")]
    //audio
    public AudioSource torchTurnOnSFX;
    public AudioSource torchTurnOffSFX;
    public AudioSource flipSwitchSFX;
    public AudioSource moveStatueGoodSFX;
    public AudioSource moveStatueBadSFX;
    public AudioSource errorSFX;
    public AudioSource ladderClimbSFX;

    [Header("Ladders")]
    //ladders
    public GameObject ladderUpInteractText;
    public bool inReachLadderUp01;
    public bool inReachLadderUp02;
    public bool inReachLadderUp03;

    [Header("Puzzle 1")]
    //torches
    public GameObject torchInteractText;
    public GameObject torch01;
    public GameObject torch02;
    public GameObject torch03;
    public GameObject torch04;
    public GameObject torch05;
    public GameObject torch06;
    public bool inReachTorch01;
    public bool inReachTorch02;
    public bool inReachTorch03;
    public bool inReachTorch04;
    public bool inReachTorch05;
    public bool inReachTorch06;

    [Header("Puzzle 2")]
    //runes
    public GameObject statue;
    public int statuePosition;
    public GameObject runeInteractText;
    public bool inReachRuneUp;
    public bool inReachRuneDown;
    public bool inReachRuneLeft;
    public bool inReachRuneRight;

    [Header("Puzzle 3")]
    //lever
    public GameObject leverOff;
    public GameObject leverOn;
    public bool inReachLever;

    [Header("Puzzle 4")]
    //switches
    public GameObject switch01;
    public GameObject switch02;
    public bool inReachSwitch01;
    public bool inReachSwitch02;

    //windmills
    public int arrowLeftPosition = 1;
    public GameObject arrowLeft01;
    public GameObject arrowLeft02;
    public GameObject arrowLeft03;
    public GameObject arrowLeft04;

    public int arrowMiddlePosition = 2;
    public GameObject arrowMiddle01;
    public GameObject arrowMiddle02;
    public GameObject arrowMiddle03;
    public GameObject arrowMiddle04;

    public int arrowRightPosition = 3;
    public GameObject arrowRight01;
    public GameObject arrowRight02;
    public GameObject arrowRight03;
    public GameObject arrowRight04;

    void Start()
    {
        statuePosition = 2;
        inReachTorch01 = false;
        inReachTorch02 = false;
        inReachTorch03 = false;
        inReachTorch04 = false;
        inReachTorch05 = false;
        inReachTorch06 = false;
    }

    void OnTriggerEnter(Collider other)
    {
        //ladders
        if (other.gameObject.tag == "Ladder01Up")
        {
            inReachLadderUp01 = true;
            ladderUpInteractText.SetActive(true);
        }
        else if (other.gameObject.tag == "Ladder02Up")
        {
            inReachLadderUp02 = true;
            ladderUpInteractText.SetActive(true);
        }
        else if (other.gameObject.tag == "Ladder03Up")
        {
            inReachLadderUp03 = true;
            ladderUpInteractText.SetActive(true);
        }

        //puzzle 1
        if (gameController.GetComponent<GameController>().puzzle01 == false)
        {
            if (other.gameObject.tag == "Torch01")
            {
                inReachTorch01 = true;
                torchInteractText.SetActive(true);
            }
            else if (other.gameObject.tag == "Torch02")
            {
                inReachTorch02 = true;
                torchInteractText.SetActive(true);
            }
            else if (other.gameObject.tag == "Torch03")
            {
                inReachTorch03 = true;
                torchInteractText.SetActive(true);
            }
            else if (other.gameObject.tag == "Torch04")
            {
                inReachTorch04 = true;
                torchInteractText.SetActive(true);
            }
            else if (other.gameObject.tag == "Torch05")
            {
                inReachTorch05 = true;
                torchInteractText.SetActive(true);
            }
            else if (other.gameObject.tag == "Torch06")
            {
                inReachTorch06 = true;
                torchInteractText.SetActive(true);
            }
        }

        //puzzle 2
        if (gameController.GetComponent<GameController>().puzzle02 == false)
        {
            if (other.gameObject.tag == "RuneUp")
            {
                inReachRuneUp = true;
                runeInteractText.SetActive(true);
            }
            else if (other.gameObject.tag == "RuneDown")
            {
                inReachRuneDown = true;
                runeInteractText.SetActive(true);
            }
            else if (other.gameObject.tag == "RuneLeft")
            {
                inReachRuneLeft = true;
                runeInteractText.SetActive(true);
            }
            else if (other.gameObject.tag == "RuneRight")
            {
                inReachRuneRight = true;
                runeInteractText.SetActive(true);
            }
        }

        //puzzle 3
        if (gameController.GetComponent<GameController>().puzzle03 == false)
        {
            if (other.gameObject.tag == "Lever")
            {
                inReachLever = true;
                torchInteractText.SetActive(true);
            }
        }

        //puzzle 4
        if (gameController.GetComponent<GameController>().puzzle04 == false)
        {
            if (other.gameObject.tag == "Switch01")
            {
                inReachSwitch01 = true;
                torchInteractText.SetActive(true);
            }
            else if (other.gameObject.tag == "Switch02")
            {
                inReachSwitch02 = true;
                torchInteractText.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        //ladders
        if (other.gameObject.tag == "Ladder01Up")
        {
            inReachLadderUp01 = false;
            ladderUpInteractText.SetActive(false);
        }
        else if (other.gameObject.tag == "Ladder02Up")
        {
            inReachLadderUp02 = false;
            ladderUpInteractText.SetActive(false);
        }
        else if (other.gameObject.tag == "Ladder03Up")
        {
            inReachLadderUp03 = false;
            ladderUpInteractText.SetActive(false);
        }

        //puzzle 1
        if (other.gameObject.tag == "Torch01")
        {
            inReachTorch01 = false;
            torchInteractText.SetActive(false);
        }
        else if (other.gameObject.tag == "Torch02")
        {
            inReachTorch02 = false;
            torchInteractText.SetActive(false);
        }
        else if (other.gameObject.tag == "Torch03")
        {
            inReachTorch03 = false;
            torchInteractText.SetActive(false);
        }
        else if (other.gameObject.tag == "Torch04")
        {
            inReachTorch04 = false;
            torchInteractText.SetActive(false);
        }
        else if (other.gameObject.tag == "Torch05")
        {
            inReachTorch05 = false;
            torchInteractText.SetActive(false);
        }
        else if (other.gameObject.tag == "Torch06")
        {
            inReachTorch06 = false;
            torchInteractText.SetActive(false);
        }

        //puzzle 2
        else if (other.gameObject.tag == "RuneUp")
        {
            inReachRuneUp = false;
            runeInteractText.SetActive(false);
        }
        else if (other.gameObject.tag == "RuneDown")
        {
            inReachRuneDown = false;
            runeInteractText.SetActive(false);
        }
        else if (other.gameObject.tag == "RuneLeft")
        {
            inReachRuneLeft = false;
            runeInteractText.SetActive(false);
        }
        else if (other.gameObject.tag == "RuneRight")
        {
            inReachRuneRight = false;
            runeInteractText.SetActive(false);
        }

        //puzzle 3
        else if (other.gameObject.tag == "Lever")
        {
            inReachLever = false;
            torchInteractText.SetActive(false);
        }

        //puzzle 4
        else if (other.gameObject.tag == "Switch01")
        {
            inReachSwitch01 = false;
            torchInteractText.SetActive(false);
        }
        else if (other.gameObject.tag == "Switch02")
        {
            inReachSwitch02 = false;
            torchInteractText.SetActive(false);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            //ladders
            if (inReachLadderUp01)
            {
                ladderClimbSFX.Play();
                playerObj.transform.position = new Vector3(2.5f, 152f, transform.position.z - 6);
            }
            else if (inReachLadderUp02)
            {
                ladderClimbSFX.Play();
                playerObj.transform.position = new Vector3(2.5f, 157f, transform.position.z - 6);
            }
            else if (inReachLadderUp03)
            {
                ladderClimbSFX.Play();
                playerObj.transform.position = new Vector3(transform.position.x + 6, 157f, transform.position.z);
            }

            //puzzle 1
            if (gameController.GetComponent<GameController>().puzzle01 == false)
            {
                if (inReachTorch01)
                {
                    if (torch01.activeSelf == true)
                    {
                        torchTurnOffSFX.Play();
                        torch01.SetActive(false);
                    }
                    else
                    {
                        torchTurnOnSFX.Play();
                        torch01.SetActive(true);
                    }
                }
                else if (inReachTorch02)
                {
                    if (torch02.activeSelf == true)
                    {
                        torchTurnOffSFX.Play();
                        torch02.SetActive(false);
                    }
                    else
                    {
                        torchTurnOnSFX.Play();
                        torch02.SetActive(true);
                    }
                }
                else if (inReachTorch03)
                {
                    if (torch03.activeSelf == true)
                    {
                        torchTurnOffSFX.Play();
                        torch03.SetActive(false);
                    }
                    else
                    {
                        torchTurnOnSFX.Play();
                        torch03.SetActive(true);
                    }
                }
                else if (inReachTorch04)
                {
                    if (torch04.activeSelf == true)
                    {
                        torchTurnOffSFX.Play();
                        torch04.SetActive(false);
                    }
                    else
                    {
                        torchTurnOnSFX.Play();
                        torch04.SetActive(true);
                    }
                }
                else if (inReachTorch05)
                {
                    if (torch05.activeSelf == true)
                    {
                        torchTurnOffSFX.Play();
                        torch05.SetActive(false);
                    }
                    else
                    {
                        torchTurnOnSFX.Play();
                        torch05.SetActive(true);
                    }
                }
                else if (inReachTorch06)
                {
                    if (torch06.activeSelf == true)
                    {
                        torchTurnOffSFX.Play();
                        torch06.SetActive(false);
                    }
                    else
                    {
                        torchTurnOnSFX.Play();
                        torch06.SetActive(true);
                    }
                }
            }

            //puzzle 2
            if (gameController.GetComponent<GameController>().puzzle02 == false)
            {
                if (inReachRuneUp)
                {
                    //can move up
                    if (statuePosition == 1 || statuePosition == 2 || statuePosition == 4 || statuePosition == 6 ||
                        statuePosition == 7 || statuePosition == 8 || statuePosition == 9 || statuePosition == 10 ||
                        statuePosition == 12)
                    {
                        moveStatueGoodSFX.Play();
                        statuePosition = statuePosition + 4;
                        statue.transform.position = new Vector3(statue.transform.position.x, 0, statue.transform.position.z - 5);
                    }
                    //cannot move up due to edge
                    else if (statuePosition == 13 || statuePosition == 14 || statuePosition == 15 || statuePosition == 16)
                    {
                        moveStatueBadSFX.Play();
                        statue.transform.position = new Vector3(statue.transform.position.x, 0, statue.transform.position.z);
                    }
                    //hit an obstacle, so reset
                    else
                    {
                        errorSFX.Play();
                        statuePosition = 2;
                        statue.transform.position = new Vector3(5, 0, 10);
                    }
                }
                else if (inReachRuneDown)
                {
                    //can move down
                    if (statuePosition == 5 || statuePosition == 6 || statuePosition == 8 || statuePosition == 10 ||
                        statuePosition == 11 || statuePosition == 12 || statuePosition == 13 || statuePosition == 14 ||
                        statuePosition == 16)
                    {
                        moveStatueGoodSFX.Play();
                        statuePosition = statuePosition - 4;
                        statue.transform.position = new Vector3(statue.transform.position.x, 0, statue.transform.position.z + 5);
                    }
                    //cannot move down due to edge
                    else if (statuePosition == 1 || statuePosition == 2 || statuePosition == 3 || statuePosition == 4)
                    {
                        moveStatueBadSFX.Play();
                        statue.transform.position = new Vector3(statue.transform.position.x, 0, statue.transform.position.z);
                    }
                    //hit an obstacle, so reset
                    else
                    {
                        errorSFX.Play();
                        statuePosition = 2;
                        statue.transform.position = new Vector3(5, 0, 10);
                    }
                }
                else if (inReachRuneLeft)
                {
                    //can move left
                    if (statuePosition == 3 || statuePosition == 4 || statuePosition == 6 || statuePosition == 8 ||
                        statuePosition == 10 || statuePosition == 11 || statuePosition == 16)
                    {
                        moveStatueGoodSFX.Play();
                        statuePosition = statuePosition - 1;
                        statue.transform.position = new Vector3(statue.transform.position.x + 5, 0, statue.transform.position.z);
                    }
                    //cannot move left due to edge
                    else if (statuePosition == 1 || statuePosition == 5 || statuePosition == 9 || statuePosition == 13)
                    {
                        moveStatueBadSFX.Play();
                        statue.transform.position = new Vector3(statue.transform.position.x, 0, statue.transform.position.z);
                    }
                    //hit an obstacle, so reset
                    else
                    {
                        errorSFX.Play();
                        statuePosition = 2;
                        statue.transform.position = new Vector3(5, 0, 10);
                    }
                }
                else if (inReachRuneRight)
                {
                    //can move right
                    if (statuePosition == 2 || statuePosition == 3 || statuePosition == 5 || statuePosition == 7 ||
                        statuePosition == 9 || statuePosition == 10 || statuePosition == 15)
                    {
                        moveStatueGoodSFX.Play();
                        statuePosition = statuePosition + 1;
                        statue.transform.position = new Vector3(statue.transform.position.x - 5, 0, statue.transform.position.z);
                    }
                    //cannot move right due to edge
                    else if (statuePosition == 4 || statuePosition == 8 || statuePosition == 12 || statuePosition == 16)
                    {
                        moveStatueBadSFX.Play();
                        statue.transform.position = new Vector3(statue.transform.position.x, 0, statue.transform.position.z);
                    }
                    //hit an obstacle, so reset
                    else
                    {
                        errorSFX.Play();
                        statuePosition = 2;
                        statue.transform.position = new Vector3(5, 0, 10);
                    }
                }
            }

            //puzzle 3
            if (gameController.GetComponent<GameController>().puzzle03 == false)
            {
                if (inReachLever && leverOff.activeSelf == true)
                {
                    torchInteractText.SetActive(false);
                    leverOff.SetActive(false);
                    leverOn.SetActive(true);
                }
            }

            //puzzle 4
            if (gameController.GetComponent<GameController>().puzzle03 == false)
            {
                if (inReachSwitch01)
                {
                    flipSwitchSFX.Play();
                    //move left
                    if (arrowLeftPosition == 1)
                    {
                        arrowLeft01.SetActive(false);
                        arrowLeft02.SetActive(true);
                        arrowLeftPosition = 2;
                    }
                    else if (arrowLeftPosition == 2)
                    {
                        arrowLeft02.SetActive(false);
                        arrowLeft03.SetActive(true);
                        arrowLeftPosition = 3;
                    }
                    else if (arrowLeftPosition == 3)
                    {
                        arrowLeft03.SetActive(false);
                        arrowLeft04.SetActive(true);
                        arrowLeftPosition = 4;
                    }
                    else if (arrowLeftPosition == 4)
                    {
                        arrowLeft04.SetActive(false);
                        arrowLeft01.SetActive(true);
                        arrowLeftPosition = 1;
                    }

                    //move middle
                    if (arrowMiddlePosition == 1)
                    {
                        arrowMiddle01.SetActive(false);
                        arrowMiddle02.SetActive(true);
                        arrowMiddlePosition = 2;
                    }
                    else if (arrowMiddlePosition == 2)
                    {
                        arrowMiddle02.SetActive(false);
                        arrowMiddle03.SetActive(true);
                        arrowMiddlePosition = 3;
                    }
                    else if (arrowMiddlePosition == 3)
                    {
                        arrowMiddle03.SetActive(false);
                        arrowMiddle04.SetActive(true);
                        arrowMiddlePosition = 4;
                    }
                    else if (arrowMiddlePosition == 4)
                    {
                        arrowMiddle04.SetActive(false);
                        arrowMiddle01.SetActive(true);
                        arrowMiddlePosition = 1;
                    }
                }
                else if (inReachSwitch02)
                {
                    flipSwitchSFX.Play();
                    //move right
                    if (arrowRightPosition == 1)
                    {
                        arrowRight01.SetActive(false);
                        arrowRight02.SetActive(true);
                        arrowRightPosition = 2;
                    }
                    else if (arrowRightPosition == 2)
                    {
                        arrowRight02.SetActive(false);
                        arrowRight03.SetActive(true);
                        arrowRightPosition = 3;
                    }
                    else if (arrowRightPosition == 3)
                    {
                        arrowRight03.SetActive(false);
                        arrowRight04.SetActive(true);
                        arrowRightPosition = 4;
                    }
                    else if (arrowRightPosition == 4)
                    {
                        arrowRight04.SetActive(false);
                        arrowRight01.SetActive(true);
                        arrowRightPosition = 1;
                    }

                    //move middle
                    if (arrowMiddlePosition == 1)
                    {
                        arrowMiddle01.SetActive(false);
                        arrowMiddle02.SetActive(true);
                        arrowMiddlePosition = 2;
                    }
                    else if (arrowMiddlePosition == 2)
                    {
                        arrowMiddle02.SetActive(false);
                        arrowMiddle03.SetActive(true);
                        arrowMiddlePosition = 3;
                    }
                    else if (arrowMiddlePosition == 3)
                    {
                        arrowMiddle03.SetActive(false);
                        arrowMiddle04.SetActive(true);
                        arrowMiddlePosition = 4;
                    }
                    else if (arrowMiddlePosition == 4)
                    {
                        arrowMiddle04.SetActive(false);
                        arrowMiddle01.SetActive(true);
                        arrowMiddlePosition = 1;
                    }
                }
            }
        }
    }
}
