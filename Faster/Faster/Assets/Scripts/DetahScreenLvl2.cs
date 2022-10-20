using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetahScreenLvl2 : MonoBehaviour
{
    public GameObject DeathScreen_;
    public void OnClickStart()
    {
        SceneManager.LoadScene("Lvl2", LoadSceneMode.Single);

    }
}
