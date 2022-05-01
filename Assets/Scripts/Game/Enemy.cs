using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    public GameObject player;
    private Player playerScript;
    private Vector2 next;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerScript = player.GetComponent<Player>();
        playerScript.OnMove += Move;
    }
    private void Update()
    {
        if (rb.velocity == Vector2.zero)
        {
            Move2();
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, next, step);
        }
    }
    void Move(object sender, EventArgs e)
    {

        next = BoardManager.Instance.nextStep((int)transform.position.x, (int)transform.position.y, (int)player.transform.position.x, (int)player.transform.position.y);
    }
    void Move2()
    {

        next = BoardManager.Instance.nextStep((int)transform.position.x, (int)transform.position.y, (int)player.transform.position.x, (int)player.transform.position.y);
    }
}
