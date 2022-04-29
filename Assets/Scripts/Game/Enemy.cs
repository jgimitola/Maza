using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    public GameObject player;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        if(rb.velocity == Vector2.zero)
        {

            float step = speed * Time.deltaTime;
            Vector2 next = BoardManager.Instance.nextStep((int)transform.position.x, (int)transform.position.y, (int)player.transform.position.x, (int)player.transform.position.y);
            transform.position = Vector2.MoveTowards(transform.position, next, step);
            Debug.Log((int)player.transform.position.x+" "+ (int)player.transform.position.y);
            Debug.Log(next);
        }
    }
    void Move()
    {
        float step = speed * Time.deltaTime;
        Vector2 next = BoardManager.Instance.nextStep((int)transform.position.x, (int)transform.position.y, (int)player.transform.position.x, (int)player.transform.position.y);
        Debug.Log(next);
        transform.position = next;
    }
}
