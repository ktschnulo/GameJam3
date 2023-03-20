using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //puzzles
    public bool puzzle01 = false;
    public bool puzzle02 = false;
    public bool puzzle03 = false;
    public bool puzzle04 = false;

    public GameObject interactText;
    public GameObject runeInteractText;

    public bool textOff01 = false;
    public bool textOff02 = false;
    public bool textOff03 = false;
    public bool textOff04 = false;

    //braziers
    public GameObject brazier01_nm;
    public GameObject brazier02_nm;
    public GameObject brazier03_nm;
    public GameObject brazier04_nm;

    public GameObject brazier01_dr;
    public GameObject brazier02_dr;
    public GameObject brazier03_dr;
    public GameObject brazier04_dr;

    //torches
    public GameObject torch01;
    public GameObject torch02;
    public GameObject torch03;
    public GameObject torch04;
    public GameObject torch05;
    public GameObject torch06;

    //switch
    public GameObject leverOff;
    public GameObject leverOn;

    //statue
    public GameObject statue;

    //widmills
    public GameObject arrowLeft;
    public GameObject arrowMiddle;
    public GameObject arrowRight;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //puzzle 1
        if (torch01.activeSelf == true && torch02.activeSelf == false &&
            torch03.activeSelf == false && torch04.activeSelf == false &&
            torch05.activeSelf == true && torch06.activeSelf == true)
        {
            puzzle01 = true;
            brazier01_nm.SetActive(true);
            brazier01_dr.SetActive(true);
            if (textOff01 == false)
            {
                interactText.SetActive(false);
                textOff01 = true;
            }
        }

        //puzzle 2
        if (statue.transform.position.x == 0 && statue.transform.position.z == -5)
        {
            puzzle02 = true;
            brazier02_nm.SetActive(true);
            brazier02_dr.SetActive(true);
            if (textOff02 == false)
            {
                runeInteractText.SetActive(false);
                textOff02 = true;
            }
        }

        //puzzle 3
        if (leverOn.activeSelf == true)
        {
            puzzle03 = true;
            brazier03_nm.SetActive(true);
            brazier03_dr.SetActive(true);
            if (textOff03 == false)
            {
                interactText.SetActive(false);
                textOff03 = true;
            }
        }

        //puzzle 4
        if (arrowLeft.activeSelf == true && arrowMiddle.activeSelf == true && arrowRight.activeSelf == true)
        {
            puzzle04 = true;
            brazier04_nm.SetActive(true);
            brazier04_dr.SetActive(true);
            if (textOff04 == false)
            {
                interactText.SetActive(false);
                textOff04 = true;
            }
        }
    }
}
