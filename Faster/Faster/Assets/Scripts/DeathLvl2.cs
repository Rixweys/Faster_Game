using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathLvl2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Hero"))
        {
            Cursor.visible = true;
            SceneManager.LoadScene("DeathScreenLvl2", LoadSceneMode.Single);
        }
    }
}
//справка