using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GeoController : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed = 5;
    public string nextlevel = "Scene_2";
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    string thislevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thislevel);
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextlevel);
                    break;
                }
        }
    }
}
