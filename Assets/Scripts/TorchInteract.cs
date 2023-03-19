using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchInteract : MonoBehaviour
{
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
        if (other.gameObject.tag == "Torch01")
        {
            inReachTorch01 = true;
            torchInteractText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Torch01")
        {
            inReachTorch01 = false;
            torchInteractText.SetActive(false);
        }
    }

    void Update()
    {
        if (inReachTorch01 && Input.GetKeyDown(KeyCode.F))
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
    }
}
