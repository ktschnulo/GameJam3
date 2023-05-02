using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SensitivityManager : MonoBehaviour
{
    [SerializeField] Slider senseSlider;
    public PlayerCam myCam;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("moveSense"))
        {
            PlayerPrefs.SetFloat("moveSense", 150f);
            Load();
        }
        else
        {
            Load();
        }
    }
    public void ChangeSensitivity()
    {
        myCam.sensX = senseSlider.value;
        myCam.sensY = senseSlider.value;
        Save();
    }

    private void Load()
    {
        senseSlider.value = PlayerPrefs.GetFloat("moveSense");

    }

    private void Save()
    {
        PlayerPrefs.SetFloat("moveSense", senseSlider.value);
    }
}
