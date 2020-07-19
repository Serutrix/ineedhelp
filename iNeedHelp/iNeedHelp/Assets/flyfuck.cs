using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class flyfuck : MonoBehaviour
{
    public Gamemanager Gamemanager;
    public float meow = 1;
    private Rigidbody2D rb;



    // Start is called before the first frame update
    void Start()
    {
        pointi.score = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * meow;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Gamemanager.GameOver();
    }
}
