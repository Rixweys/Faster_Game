using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreenButtonScript : MonoBehaviour
{
    public GameObject DeathScreen_;
    public void OnClickStart()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);

    }
  
}
