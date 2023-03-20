using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

    public class startScreenPressed : MonoBehaviour
{
    public Material dayBox;
    public Material nightBox;
    public GameObject fireObj;
    public GameObject lightObj;
    public GameObject sceneLight;
    public GameObject startBtn;
    public TextMeshProUGUI title;
    public TextMeshProUGUI startTxt;
    public VertexGradient newGradient;
    public VertexGradient defaultGradient;
    private bool active = false;


    void Start()
    {
        RenderSettings.skybox = dayBox;
        defaultGradient = title.colorGradient;
        newGradient = new VertexGradient(Color.white, Color.grey, Color.grey, Color.white);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!active)
            {
                title.colorGradient = newGradient;
                startTxt.colorGradient = newGradient;
                RenderSettings.skybox = nightBox;

                fireObj.SetActive(true);
                lightObj.SetActive(true);
                sceneLight.SetActive(false);
                startBtn.SetActive(true);
                active = true;
            }
            else
            {
                title.colorGradient = defaultGradient;
                startTxt.colorGradient = defaultGradient;
                RenderSettings.skybox = dayBox;

                fireObj.SetActive(false);
                lightObj.SetActive(false);
                sceneLight.SetActive(true);
                active = false;
            }
        }
    }
}
