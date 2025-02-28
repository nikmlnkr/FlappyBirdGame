using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMyNextLevel : MonoBehaviour
{
    public void StartMyGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
