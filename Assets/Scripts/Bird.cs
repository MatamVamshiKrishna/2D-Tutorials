using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    public float Speed = 100.0f;
    public Text ScoreText;

    private int score = 0;
    public static bool IsAlive = true;
    Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            rigidbody2D.velocity = Vector2.up * Time.deltaTime * Speed; 
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log(other);
        score++;
        ScoreText.text = score.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision);
        IsAlive = false;
    }
}
