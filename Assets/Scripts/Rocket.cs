using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public int Speed = 1;
    private GameObject target;
    private Vector3 targetPosition;
    private Rigidbody2D rb;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Plane");
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        targetPosition = target.transform.position;
        rb.velocity = (targetPosition - transform.position).normalized * Speed;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Plane"))
        {
            Destroy(gameObject);
            Destroy(target);
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
