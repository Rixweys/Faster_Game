using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lvl1 : MonoBehaviour
{

    public void onClickStart()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
}
