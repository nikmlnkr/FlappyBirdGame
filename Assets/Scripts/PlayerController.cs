using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed = 2;

    public Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Left mouse button - 0
        //Right mouse button - 1
        //Middle mouse button - 2
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            FlyBird();
        }
    }

    public void FlyBird()
    {
        if (!GameManager.Instance.gameOver && GameManager.Instance.hasGameStarted)
        {
            rb.linearVelocity = new Vector3(0, speed, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameManager.Instance.Score();
    }
  
    //OnCollisionEnter
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!GameManager.Instance.gameOver)
        {
            GameManager.Instance.GameOver();
        }

        if(collision.gameObject.CompareTag("ground"))
        {
             
        }
    }

}
