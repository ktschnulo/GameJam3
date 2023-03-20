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
    private float dilateTitleVal = -1.0f;
    private float dilateStartTxtVal = -1.0f;


    void Start()
    {
        RenderSettings.skybox = dayBox;
        defaultGradient = title.colorGradient;
        newGradient = new VertexGradient(Color.white, Color.grey, Color.grey, Color.white);
        title.fontMaterial.SetFloat(ShaderUtilities.ID_FaceDilate, -1.0f);
        startTxt.fontMaterial.SetFloat(ShaderUtilities.ID_FaceDilate, -1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        dilateTitleTxt();
        if (Input.GetButtonDown("Fire1") && !active)
        {
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
        }
        if (active)
        {
            dilateStartTxt();
        }
    }

    private void dilateTitleTxt()
    {
        if (dilateTitleVal < 0.2)
        {
            dilateTitleVal += 0.003f;
            title.fontMaterial.SetFloat(ShaderUtilities.ID_FaceDilate, dilateTitleVal);
        }
    }

    private void dilateStartTxt()
    {
        if (dilateStartTxtVal < 0.2)
        {
            dilateStartTxtVal += 0.003f;
            startTxt.fontMaterial.SetFloat(ShaderUtilities.ID_FaceDilate, dilateStartTxtVal);
        }
    }
}
