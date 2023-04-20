using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialInteract : MonoBehaviour
{
    public GameObject tutorialManInteractText;
    public GameObject speechBubble;
    public GameObject tutorialManTextContinue;

    //man 1
    public bool inReachTutorialMan = false;
    public int tutorialManTextNum = 1;
    public GameObject tutorialManText1;
    public GameObject tutorialManText2;
    public GameObject tutorialManText3;
    public GameObject tutorialManText4;
    public GameObject tutorialManText5;
    public GameObject tutorialManText6;

    //man 2
    public bool inReachTutorialMan2 = false;
    public int tutorialMan2TextNum = 1;
    public GameObject tutorialMan2Text1;
    public GameObject tutorialMan2Text2;
    public GameObject tutorialMan2Text3;
    public GameObject tutorialMan2Text4;
    public GameObject tutorialMan2Text5;
    public GameObject tutorialMan2Text6;
    public GameObject tutorialMan2Text7;

    //player and cam
    public GameObject player;
    public GameObject playerCam;

    //doors
    public GameObject fence1;
    public GameObject gate1;
    public GameObject fence1open;
    public GameObject gate1open;

    //flowers
    public GameObject flowerInteractText;
    public GameObject tutorialFlower1;
    public GameObject tutorialFlower2;
    public GameObject tutorialFlower3;
    public string tutorialFlowerCode = "231";
    public string tutorialFlowerCodeInput = "";
    public bool inReachTutorialFlower1 = false;
    public bool inReachTutorialFlower2 = false;
    public bool inReachTutorialFlower3 = false;

    //puzzle
    public GameObject speechBubble2;
    public GameObject puzzleTextContinue;
    public int puzzleTextNum = 1;
    public GameObject puzzleText1;
    public GameObject puzzleText2;
    public GameObject puzzleText3;
    public GameObject puzzleText4;
    public GameObject puzzleText5;
    public GameObject puzzleTextComplete;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        //man 1
        if (other.gameObject.tag == "TutorialMan")
        {
            if (tutorialManTextNum != 7){
                inReachTutorialMan = true;
                tutorialManInteractText.SetActive(true);
            }
        }
        //man 2
        else if (other.gameObject.tag == "TutorialMan2")
        {
            if (tutorialMan2TextNum != 9){
                inReachTutorialMan2 = true;
                tutorialManInteractText.SetActive(true);
            }
        }
        //flowers
        else if (other.gameObject.tag == "TutorialFlower1")
        {
            inReachTutorialFlower1 = true;
            flowerInteractText.SetActive(true);
        }
        else if (other.gameObject.tag == "TutorialFlower2")
        {
            inReachTutorialFlower2 = true;
            flowerInteractText.SetActive(true);
        }
        else if (other.gameObject.tag == "TutorialFlower3")
        {
            inReachTutorialFlower3 = true;
            flowerInteractText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        //tutorial man
        if (other.gameObject.tag == "TutorialMan")
        {
            inReachTutorialMan = false;
            tutorialManInteractText.SetActive(false);
        }
        else if (other.gameObject.tag == "TutorialMan2")
        {
            inReachTutorialMan2 = false;
            tutorialManInteractText.SetActive(false);
        }
        //flowers
        else if (other.gameObject.tag == "TutorialFlower1")
        {
            inReachTutorialFlower1 = false;
            flowerInteractText.SetActive(false);
        }
        else if (other.gameObject.tag == "TutorialFlower2")
        {
            inReachTutorialFlower2 = false;
            flowerInteractText.SetActive(false);
        }
        else if (other.gameObject.tag == "TutorialFlower3")
        {
            inReachTutorialFlower3 = false;
            flowerInteractText.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.z > 20 && puzzleTextNum == 1){
            speechBubble2.SetActive(true);
            puzzleTextContinue.SetActive(true);
            puzzleText1.SetActive(true);
            puzzleTextNum = 2;

        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            //man 1
            if (inReachTutorialMan)
            {
                if (tutorialManTextNum == 1){
                    tutorialManInteractText.SetActive(false);
                    speechBubble.SetActive(true);
                    tutorialManText1.SetActive(true);
                    tutorialManTextContinue.SetActive(true);
                    player.GetComponent<movement>().movementLocked = true;
                    playerCam.GetComponent<PlayerCam>().camLocked = true;
                    tutorialManTextNum = 2;
                }
                else if (tutorialManTextNum == 6){
                    tutorialManInteractText.SetActive(false);
                    speechBubble.SetActive(true);
                    tutorialManText6.SetActive(true);
                    tutorialManTextContinue.SetActive(true);
                    player.GetComponent<movement>().movementLocked = true;
                    playerCam.GetComponent<PlayerCam>().camLocked = true;
                }
            }
            //man 2
            else if (inReachTutorialMan2){
                if (tutorialMan2TextNum == 1){
                    tutorialManInteractText.SetActive(false);
                    speechBubble.SetActive(true);
                    tutorialMan2Text1.SetActive(true);
                    tutorialManTextContinue.SetActive(true);
                    player.GetComponent<movement>().movementLocked = true;
                    playerCam.GetComponent<PlayerCam>().camLocked = true;
                    player.GetComponent<TutorialSwap>().canSwap = false;
                    tutorialMan2TextNum = 2;
                }
            }
            //flowers
            else if (inReachTutorialFlower1){
                tutorialFlower1.SetActive(false);
                tutorialFlowerCodeInput += "1";
                if (tutorialFlowerCodeInput.Length == 3 ){
                    if (tutorialFlowerCodeInput.Equals(tutorialFlowerCode)){
                        puzzleText1.SetActive(false);
                        puzzleText2.SetActive(false);
                        puzzleText3.SetActive(false);
                        puzzleText4.SetActive(false);
                        puzzleText5.SetActive(false);
                        puzzleTextComplete.SetActive(true);
                        puzzleTextNum = 7;
                    }
                    else{
                        tutorialFlower1.SetActive(true);
                        tutorialFlower2.SetActive(true);
                        tutorialFlower3.SetActive(true);
                        tutorialFlowerCodeInput = "";
                    }
                }
                inReachTutorialFlower1 = false;
                flowerInteractText.SetActive(false);
            }
            else if (inReachTutorialFlower2){
                tutorialFlower2.SetActive(false);
                tutorialFlowerCodeInput += "2";
                if (tutorialFlowerCodeInput.Length == 3 ){
                    if (tutorialFlowerCodeInput.Equals(tutorialFlowerCode)){
                        puzzleText1.SetActive(false);
                        puzzleText2.SetActive(false);
                        puzzleText3.SetActive(false);
                        puzzleText4.SetActive(false);
                        puzzleText5.SetActive(false);
                        puzzleTextComplete.SetActive(true);
                        puzzleTextNum = 7;
                    }
                    else{
                        tutorialFlower1.SetActive(true);
                        tutorialFlower2.SetActive(true);
                        tutorialFlower3.SetActive(true);
                        tutorialFlowerCodeInput = "";
                    }
                }
                inReachTutorialFlower2 = false;
                flowerInteractText.SetActive(false);
            }
            else if (inReachTutorialFlower3){
                tutorialFlower3.SetActive(false);
                tutorialFlowerCodeInput += "3";
                if (tutorialFlowerCodeInput.Length == 3 ){
                    if (tutorialFlowerCodeInput.Equals(tutorialFlowerCode)){
                        puzzleText1.SetActive(false);
                        puzzleText2.SetActive(false);
                        puzzleText3.SetActive(false);
                        puzzleText4.SetActive(false);
                        puzzleText5.SetActive(false);
                        puzzleTextComplete.SetActive(true);
                        puzzleTextNum = 7;
                    }
                    else{
                        tutorialFlower1.SetActive(true);
                        tutorialFlower2.SetActive(true);
                        tutorialFlower3.SetActive(true);
                        tutorialFlowerCodeInput = "";
                    }
                }
                inReachTutorialFlower3 = false;
                flowerInteractText.SetActive(false);
            }
        }
        else if (Input.GetKeyDown(KeyCode.E)){
            if (tutorialManTextNum == 2){
                tutorialManText1.SetActive(false);
                tutorialManText2.SetActive(true);
                tutorialManTextNum = 3;
            }
            else if (tutorialManTextNum == 3){
                tutorialManText2.SetActive(false);
                tutorialManText3.SetActive(true);
                tutorialManTextNum = 4;
            }
            else if (tutorialManTextNum == 4){
                tutorialManText3.SetActive(false);
                tutorialManText4.SetActive(true);
                tutorialManTextNum = 5;
            }
            else if (tutorialManTextNum == 5){
                tutorialManText4.SetActive(false);
                tutorialManText5.SetActive(true);
                tutorialManTextContinue.SetActive(false);
                player.GetComponent<TutorialSwap>().canSwap = true;
            }
            else if (tutorialManTextNum == 6 && inReachTutorialMan){
                tutorialManInteractText.SetActive(true);
                speechBubble.SetActive(false);
                tutorialManText6.SetActive(false);
                tutorialManTextContinue.SetActive(false);
                player.GetComponent<movement>().movementLocked = false;
                playerCam.GetComponent<PlayerCam>().camLocked = false;
            }
            //man2
            else if (tutorialMan2TextNum == 2){
                tutorialMan2Text1.SetActive(false);
                tutorialMan2Text2.SetActive(true);
                tutorialMan2TextNum = 3;
            }
            else if (tutorialMan2TextNum == 3){
                tutorialMan2Text2.SetActive(false);
                tutorialMan2Text3.SetActive(true);
                tutorialMan2TextNum = 4;
            }
            else if (tutorialMan2TextNum == 4){
                tutorialMan2Text3.SetActive(false);
                tutorialMan2Text4.SetActive(true);
                tutorialMan2TextNum = 5;
            }
            else if (tutorialMan2TextNum == 5){
                tutorialMan2Text4.SetActive(false);
                tutorialMan2Text5.SetActive(true);
                tutorialMan2TextNum = 6;
            }
            else if (tutorialMan2TextNum == 6){
                tutorialMan2Text5.SetActive(false);
                tutorialMan2Text6.SetActive(true);
                tutorialMan2TextNum = 7;
            }
            else if (tutorialMan2TextNum == 7){
                tutorialMan2Text6.SetActive(false);
                tutorialMan2Text7.SetActive(true);
                tutorialMan2TextNum = 8;
            }
            else if (tutorialMan2TextNum == 8){
                speechBubble.SetActive(false);
                tutorialManTextContinue.SetActive(false);
                tutorialMan2Text7.SetActive(false);
                tutorialMan2TextNum = 9;
                tutorialManTextNum = 7;
                player.GetComponent<TutorialSwap>().canSwap = true;
                player.GetComponent<movement>().movementLocked = false;
                playerCam.GetComponent<PlayerCam>().camLocked = false;
                gate1.SetActive(false);
                fence1.SetActive(false);
                gate1open.SetActive(true);
                fence1open.SetActive(true);
            }
            if (puzzleTextNum == 2){
                puzzleText1.SetActive(false);
                puzzleText2.SetActive(true);
                puzzleTextNum = 3;
            }
            else if (puzzleTextNum == 3){
                puzzleText2.SetActive(false);
                puzzleText3.SetActive(true);
                puzzleTextNum = 4;
            }
            else if (puzzleTextNum == 4){
                puzzleText3.SetActive(false);
                puzzleText4.SetActive(true);
                puzzleTextNum = 5;
            }
            else if (puzzleTextNum == 5){
                puzzleText4.SetActive(false);
                puzzleText5.SetActive(true);
                puzzleTextNum = 6;
            }
            else if (puzzleTextNum == 7){
                //go to real game
            }
        }
        if (Input.GetKeyDown(KeyCode.Q)){
            if (tutorialManTextNum == 5){
                tutorialManTextNum = 6;
            }
        }
    }
}
