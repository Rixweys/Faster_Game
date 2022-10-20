using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Scene : MonoBehaviour
{
    public void onClickStart()
    {
        SceneManager.LoadScene("Lvl2", LoadSceneMode.Single);
    }
}
