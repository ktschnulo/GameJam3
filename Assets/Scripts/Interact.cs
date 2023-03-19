using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    //game conroller
    public GameObject gameController;

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

    //lever
    public GameObject leverOff;
    public GameObject leverOn;
    public bool inReachLever;

    void Start()
    {
        inReachTorch01 = false;
        inReachTorch02 = false;
        inReachTorch03 = false;
        inReachTorch04 = false;
        inReachTorch05 = false;
        inReachTorch06 = false;
    }

    void OnTriggerEnter(Collider other)
    {
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

        //puzzle 3
        if (gameController.GetComponent<GameController>().puzzle02 == false)
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
            //puzzle 1
            if (inReachTorch01)
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
