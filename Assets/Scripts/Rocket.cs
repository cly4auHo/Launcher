using UnityEngine;

public class Rocket : MonoBehaviour
{

    private const float Speed = 1f;
    private Transform target;
    private Vector3 targetPosition;
    private Rigidbody2D rb;

    private const string TargetTag = "Dot";
    private const string PlaneTag = "Plane";

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag(TargetTag).transform;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        targetPosition = target.position;
        rb.velocity = (targetPosition - transform.position).normalized * Speed;
        transform.LookAt(targetPosition);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(PlaneTag))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
