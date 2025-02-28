using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //Variable list
    public AudioClip scoreSound;
    public AudioClip gameOverSound;


    //Singleton pattern definition
    private static AudioManager _instance;

    public static AudioManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindFirstObjectByType<AudioManager>();
            }

            return _instance;
        }
    }

    //Functions
    public void PlayScoreSound()
    {
        AudioSource.PlayClipAtPoint(scoreSound, Camera.main.transform.position);
    }

    public void PlayGameOverSound()
    {
        AudioSource.PlayClipAtPoint(gameOverSound, Camera.main.transform.position);
    }

}
