using UnityEngine;
using UnityEngine.SceneManagement;

public class win1 : MonoBehaviour
{
   

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Hero"))
        {
            SceneManager.LoadScene("Wictory1", LoadSceneMode.Single);
        }
    }
}
