using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Hero"))
        {
            Cursor.visible = true;
            SceneManager.LoadScene("DeathScreen", LoadSceneMode.Single);
        }
    }
}
