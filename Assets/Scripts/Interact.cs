using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    //player
    public GameObject playerObj;

    //game controller
    public GameObject gameController;

    //ladders
    public GameObject ladderUpInteractText;
    public bool inReachLadderUp01;
    public bool inReachLadderUp02;
    public bool inReachLadderUp03;

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

    //runes
    public GameObject statue;
    public int statuePosition;
    public GameObject runeInteractText;
    public bool inReachRuneUp;
    public bool inReachRuneDown;
    public bool inReachRuneLeft;
    public bool inReachRuneRight;

    //lever
    public GameObject leverOff;
    public GameObject leverOn;
    public bool inReachLever;

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
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            //ladders
            if (inReachLadderUp01)
            {
                playerObj.transform.position = new Vector3(2.5f, 152f, transform.position.z - 6);
            }
            else if (inReachLadderUp02)
            {
                playerObj.transform.position = new Vector3(2.5f, 157f, transform.position.z - 6);
            }
            else if (inReachLadderUp03)
            {
                playerObj.transform.position = new Vector3(transform.position.x + 6, 157f, transform.position.z);
            }

            //puzzle 1
            else if (inReachTorch01)
            {
                if (torch01.activeSelf == true)
                {
                    torch01.SetActive(false);
                }
                else
                {
                    torch01.SetActive(true);
                }
            }
            else if (inReachTorch02)
            {
                if (torch02.activeSelf == true)
                {
                    torch02.SetActive(false);
                }
                else
                {
                    torch02.SetActive(true);
                }
            }
            else if (inReachTorch03)
            {
                if (torch03.activeSelf == true)
                {
                    torch03.SetActive(false);
                }
                else
                {
                    torch03.SetActive(true);
                }
            }
            else if (inReachTorch04)
            {
                if (torch04.activeSelf == true)
                {
                    torch04.SetActive(false);
                }
                else
                {
                    torch04.SetActive(true);
                }
            }
            else if (inReachTorch05)
            {
                if (torch05.activeSelf == true)
                {
                    torch05.SetActive(false);
                }
                else
                {
                    torch05.SetActive(true);
                }
            }
            else if (inReachTorch06)
            {
                if (torch06.activeSelf == true)
                {
                    torch06.SetActive(false);
                }
                else
                {
                    torch06.SetActive(true);
                }
            }

            //puzzle 2
            else if (inReachRuneUp)
            {
                //can move up
                if (statuePosition == 1 || statuePosition == 2 || statuePosition == 4 || statuePosition == 6 ||
                    statuePosition == 7 || statuePosition == 8 || statuePosition == 9 || statuePosition == 10 ||
                    statuePosition == 12)
                {
                    statuePosition = statuePosition + 4;
                    statue.transform.position = new Vector3(statue.transform.position.x, 0, statue.transform.position.z - 5);
                }
                //cannot move up due to edge
                else if (statuePosition == 13 || statuePosition == 14 || statuePosition == 15 || statuePosition == 16)
                {
                    statue.transform.position = new Vector3(statue.transform.position.x, 0, statue.transform.position.z);
                }
                //hit an obstacle, so reset
                else
                {
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
                    statuePosition = statuePosition - 4;
                    statue.transform.position = new Vector3(statue.transform.position.x, 0, statue.transform.position.z + 5);
                }
                //cannot move down due to edge
                else if (statuePosition == 1 || statuePosition == 2 || statuePosition == 3 || statuePosition == 4)
                {
                    statue.transform.position = new Vector3(statue.transform.position.x, 0, statue.transform.position.z);
                }
                //hit an obstacle, so reset
                else
                {
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
                    statuePosition = statuePosition - 1;
                    statue.transform.position = new Vector3(statue.transform.position.x + 5, 0, statue.transform.position.z);
                }
                //cannot move left due to edge
                else if (statuePosition == 1 || statuePosition == 5 || statuePosition == 9 || statuePosition == 13)
                {
                    statue.transform.position = new Vector3(statue.transform.position.x, 0, statue.transform.position.z);
                }
                //hit an obstacle, so reset
                else
                {
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
                    statuePosition = statuePosition + 1;
                    statue.transform.position = new Vector3(statue.transform.position.x - 5, 0, statue.transform.position.z);
                }
                //cannot move right due to edge
                else if (statuePosition == 4 || statuePosition == 8 || statuePosition == 12 || statuePosition == 16)
                {
                    statue.transform.position = new Vector3(statue.transform.position.x, 0, statue.transform.position.z);
                }
                //hit an obstacle, so reset
                else
                {
                    statuePosition = 2;
                    statue.transform.position = new Vector3(5, 0, 10);
                }
            }

            //puzzle 3
            else if (inReachLever)
            {
                if (leverOff.activeSelf == true)
                {
                    torchInteractText.SetActive(false);
                    leverOff.SetActive(false);
                    leverOn.SetActive(true);
                }
            }
        }
    }
}
