using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    public GameObject genericObject;
    public float lowerUpperRange = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnPipes", 1, 1);
    }

    
    void SpawnPipes()
    {
        if (!GameManager.Instance.gameOver && GameManager.Instance.hasGameStarted)
        {
            Instantiate(genericObject, new Vector3(transform.position.x, Random.Range(-lowerUpperRange, lowerUpperRange), 0), Quaternion.identity);
        }
    }
}
