using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F1education : MonoCache
{
    private int countFrameEducation = 0;
    private int countFrameEducation1 = 0;
    public bool isOpendEducation = true; //Открыто ли обучение

    public void ShowHideMenu()
    {
        isOpendEducation = !isOpendEducation;
        GetComponent<Canvas>().enabled = isOpendEducation; //Включение или отключение Canvas.

    }

    public override void OnTick()
    {
        countFrameEducation1++;
        if (Input.GetKey(KeyCode.F1))
        {
            if (countFrameEducation == 0)
            {
                ShowHideMenu();
                countFrameEducation++;
                countFrameEducation1 = 0;
            }

        }

        if (countFrameEducation1 == 10)
        {
            countFrameEducation = 0;
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
