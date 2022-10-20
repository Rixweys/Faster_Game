using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class FpsCounter : MonoBehaviour
{
    public Text textFps;
    int fpsCounter = 0;
    float mTimeCounter = 0.0f;
    float lastFrameRate = 0.0f;
    public float refreshTime = 0.5f;
    const string format = "{0} Fps";
    

    // Update is called once per frame
    void Update()
    {
        if (mTimeCounter < refreshTime)
        {
            mTimeCounter += Time.deltaTime;
            fpsCounter++;
        }

        else
        {
            lastFrameRate = (float)fpsCounter / mTimeCounter;

            mTimeCounter = 0.0f;
            fpsCounter = 0;

        }

        textFps.text = string.Format(format, lastFrameRate);

        

        
    }
}
