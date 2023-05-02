using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject player;
    public GameObject completedStatue_dr;
    public GameObject completedStatue_nm;
    public GameObject completedLight_dr;
    public GameObject completedLight_nm;

    //audio 
    public AudioSource puzzleFinishSFX;


    //puzzles
    public bool puzzle01 = false;
    public bool puzzle02 = false;
    public bool puzzle03 = false;
    public bool puzzle04 = false;
    public bool puzzle05 = false;
    public bool puzzle06 = false;
    public bool completed = false;

    public GameObject completedText;
    public GameObject interactText;
    public GameObject runeInteractText;

    public bool textOff01 = false;
    public bool textOff02 = false;
    public bool textOff03 = false;
    public bool textOff04 = false;
    public bool textOff05 = false;
    public bool textOff06 = false;

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

    //puzzle 5
    public GameObject campFire;

    //puzzle 6
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;

    //Crystals
    public GameObject crystalRedCaged;
    public GameObject crystalRedUncaged;
    public GameObject crystalOrangeCaged;
    public GameObject crystalOrangeUncaged;
    public GameObject crystalYellowCaged;
    public GameObject crystalYellowUncaged;
    public GameObject crystalBlueCaged;
    public GameObject crystalBlueUncaged;
    public GameObject crystalGreenCaged;
    public GameObject crystalGreenUncaged;


    //completions
    public bool complete1;
    public bool complete2;
    public bool complete3;
    public bool complete4;
    public bool complete5;
    public bool complete6;
    public bool complete7;

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
            if (crystalRedCaged.activeSelf == true){
                crystalRedCaged.SetActive(false);
                crystalRedUncaged.SetActive(true);
            }
            brazier01_nm.SetActive(true);
            brazier01_dr.SetActive(true);
            if (textOff01 == false)
            {
                puzzleFinishSFX.Play();
                interactText.SetActive(false);
                textOff01 = true;
            }
        }

        //puzzle 2
        if (statue.transform.position.x == 0 && statue.transform.position.z == -5)
        {
            puzzle02 = true;
            if (crystalYellowCaged.activeSelf == true){
                crystalYellowCaged.SetActive(false);
                crystalYellowUncaged.SetActive(true);
            }
            brazier02_nm.SetActive(true);
            brazier02_dr.SetActive(true);
            if (textOff02 == false)
            {
                puzzleFinishSFX.Play();
                runeInteractText.SetActive(false);
                textOff02 = true;
            }
        }

        //puzzle 3
        if (leverOn.activeSelf == true)
        {
            puzzle03 = true;
            if (crystalBlueCaged.activeSelf == true){
                crystalBlueCaged.SetActive(false);
                crystalBlueUncaged.SetActive(true);
            }
            brazier03_nm.SetActive(true);
            brazier03_dr.SetActive(true);
            if (textOff03 == false)
            {
                puzzleFinishSFX.Play();
                interactText.SetActive(false);
                textOff03 = true;
            }
        }

        //puzzle 4
        if (arrowLeft.activeSelf == true && arrowMiddle.activeSelf == true && arrowRight.activeSelf == true)
        {
            puzzle04 = true;
            if (crystalOrangeCaged.activeSelf == true){
                crystalOrangeCaged.SetActive(false);
                crystalOrangeUncaged.SetActive(true);
            }
            brazier04_nm.SetActive(true);
            brazier04_dr.SetActive(true);
            if (textOff04 == false)
            {
                puzzleFinishSFX.Play();
                interactText.SetActive(false);
                textOff04 = true;
            }
        }

        //puzzle 5
        if(campFire.activeSelf == true)
        {
            puzzle05 = true;
            if(textOff06 == false)
            {
                puzzleFinishSFX.Play();
                textOff06 = true;
            }
        }

        //puzzle 6
        if(b1.activeSelf == true && b2.activeSelf == true && b3.activeSelf == true)
        {
            puzzle06 = true;
            if (crystalGreenCaged.activeSelf == true){
                crystalGreenCaged.SetActive(false);
                crystalGreenUncaged.SetActive(true);
            }
            if(textOff06 == false)
            {
                puzzleFinishSFX.Play();
                textOff06 = true;
            }
        }

        /*
        if (puzzle01 == true && puzzle02 == true && puzzle03 == true && puzzle04 == true)
        {
            completedStatue_dr.transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);
            completedStatue_nm.transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);
            if (completed == false)
            {
                completed = true;
                completedText.SetActive(true);
                completedLight_dr.SetActive(true);
                completedLight_nm.SetActive(true);
                player.transform.position = new Vector3(2.5f, 148f, 67.5f);
                completedStatue_dr.transform.position = new Vector3(completedStatue_dr.transform.position.x, completedStatue_dr.transform.position.y + 1, completedStatue_dr.transform.position.z);
                completedStatue_nm.transform.position = new Vector3(completedStatue_nm.transform.position.x, completedStatue_nm.transform.position.y + 1, completedStatue_nm.transform.position.z);
            }
        }
        */

        if (complete1 && complete2 && complete3 && complete4 && complete5 && complete6 && complete7){
            SceneManager.LoadScene(2);
        }
    }
}
