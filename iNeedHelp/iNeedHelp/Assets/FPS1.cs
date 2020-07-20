using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class FPS1 : MonoBehaviour
{
    static int FPS = 20;
    public static float a = 60;

    // Start is called before the first frame update
    void Start()
    {
        mainSlider.value = a;




    }

    // Update is called once per frame
    void Update()
    {
        a = mainSlider.value;
        Application.targetFrameRate = FPS;
        FPS = (int)a;
    }

    public Slider mainSlider;

    public void SubmitSliderSetting()
    {
        //Displays the value of the slider in the console.
        a = mainSlider.value;
    }
}
