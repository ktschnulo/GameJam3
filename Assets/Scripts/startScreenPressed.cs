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
    public GameObject exitBtn;
    public GameObject optionBtn;
    public TextMeshProUGUI title;
    public TextMeshProUGUI theme1;
    public TextMeshProUGUI theme2;
    public TextMeshProUGUI theme3;
    public TextMeshProUGUI theme4;
    public TextMeshProUGUI startTxt;
    public TextMeshProUGUI exitTxt;
    public TextMeshProUGUI optionTxt;
    public VertexGradient newGradient;
    public VertexGradient defaultGradient;
    private bool active = false;
    private float dilateTitleVal = -1.0f;
    private float dilateStartTxtVal = -1.0f;
    private float dilateThemeVal = -1.0f;


    void Start()
    {
        RenderSettings.skybox = dayBox;
        defaultGradient = title.colorGradient;
        newGradient = new VertexGradient(Color.white, Color.grey, Color.grey, Color.white);
        title.fontMaterial.SetFloat(ShaderUtilities.ID_FaceDilate, -1.0f);
        startTxt.fontMaterial.SetFloat(ShaderUtilities.ID_FaceDilate, -1.0f);
        exitTxt.fontMaterial.SetFloat(ShaderUtilities.ID_FaceDilate, -1.0f);
        theme1.fontMaterial.SetFloat(ShaderUtilities.ID_FaceDilate, -1.0f);
        theme2.fontMaterial.SetFloat(ShaderUtilities.ID_FaceDilate, -1.0f);
        theme3.fontMaterial.SetFloat(ShaderUtilities.ID_FaceDilate, -1.0f);
        theme4.fontMaterial.SetFloat(ShaderUtilities.ID_FaceDilate, -1.0f);
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
                exitTxt.colorGradient = newGradient;
                theme1.colorGradient = newGradient;
                theme2.colorGradient = newGradient;
                theme3.colorGradient = newGradient;
                theme4.colorGradient = newGradient;
                RenderSettings.skybox = nightBox;

                fireObj.SetActive(true);
                lightObj.SetActive(true);
                sceneLight.SetActive(false);
                startBtn.SetActive(true);
                exitBtn.SetActive(true);
                optionBtn.SetActive(true);
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
            dilateTitleVal += 0.005f;
            dilateThemeVal += 0.005f;
            title.fontMaterial.SetFloat(ShaderUtilities.ID_FaceDilate, dilateTitleVal);
            theme1.fontMaterial.SetFloat(ShaderUtilities.ID_FaceDilate, dilateThemeVal);
            theme2.fontMaterial.SetFloat(ShaderUtilities.ID_FaceDilate, dilateThemeVal);
            theme3.fontMaterial.SetFloat(ShaderUtilities.ID_FaceDilate, dilateThemeVal);
            theme4.fontMaterial.SetFloat(ShaderUtilities.ID_FaceDilate, dilateThemeVal);
        }
    }

    private void dilateStartTxt()
    {
        if (dilateStartTxtVal < 0.2)
        {
            dilateStartTxtVal += 0.005f;
            startTxt.fontMaterial.SetFloat(ShaderUtilities.ID_FaceDilate, dilateStartTxtVal);
            exitTxt.fontMaterial.SetFloat(ShaderUtilities.ID_FaceDilate, dilateStartTxtVal);
            optionTxt.fontMaterial.SetFloat(ShaderUtilities.ID_FaceDilate, dilateStartTxtVal);
        }
        else if (dilateThemeVal > -1.0)
        {
            dilateThemeVal -= 0.01f;
            theme1.fontMaterial.SetFloat(ShaderUtilities.ID_FaceDilate, dilateThemeVal);
            theme2.fontMaterial.SetFloat(ShaderUtilities.ID_FaceDilate, dilateThemeVal);
            theme3.fontMaterial.SetFloat(ShaderUtilities.ID_FaceDilate, dilateThemeVal);
            theme4.fontMaterial.SetFloat(ShaderUtilities.ID_FaceDilate, dilateThemeVal);
        }
    }
}
