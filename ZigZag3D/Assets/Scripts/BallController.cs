using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (!GameManager.instance.startGame)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = new Vector3(speed, 0, 0);
                GameManager.instance.StartGame();
                GameObject.Find("PlatformSpawner").GetComponent<PlatformSpawner>().StartSpawnPlatform();
            }
        }
        if (!Physics.Raycast(transform.position, Vector3.down, 1f))
        {
            rb.velocity = new Vector3(0, -25f, 0);
            GameManager.instance.GameOver();
        }
        if (Input.GetMouseButtonDown(0) && !GameManager.instance.gameOver)
            SwitchDirection();
    }
    void SwitchDirection()
    {
        if (rb.velocity.z > 0)
            rb.velocity = new Vector3(speed, 0, 0);
        else if (rb.velocity.x > 0)
            rb.velocity = new Vector3(0, 0, speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Diamond")
        {
            Destroy(other.gameObject);
            ScoreManager.instance.IncrementScoreTrigerDiamond();
        }
    }
}
