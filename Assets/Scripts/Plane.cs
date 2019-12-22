using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Plane : MonoBehaviour
{
    [SerializeField] private float minSpeed = 0.2f;
    [SerializeField] private float maxSpeed = 0.4f;
   
    private float speed;
    public float Speed => speed;

    delegate void MovementStrategy();
    private MovementStrategy movementStrategy;

    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        
        var myTrajectory = (Trajectories)Random.Range(0, 3);

        switch (myTrajectory)
        {
            case Trajectories.LINE:
                movementStrategy = MoveLinear;
                break;
            case Trajectories.SQUARE:
                movementStrategy = MoveSquare;
                break;
            case Trajectories.SIN:
                movementStrategy = MoveSin;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
   
    void Update()
    {
        movementStrategy();
    }

    private void MoveLinear()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    private void MoveSquare()
    {
        Vector3 delta = Vector3.left * speed;
        Vector3 velocity = new Vector3(delta.x, delta.x * delta.x, delta.z);
        transform.position += velocity * Time.deltaTime;
    }

    private void MoveSin()
    {
        Vector3 velocity = new Vector3(-1, Mathf.Sin(Time.timeSinceLevelLoad), 0).normalized;
        transform.position += velocity * Time.deltaTime * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }
}

  public  enum Trajectories
    {
        LINE,
        SQUARE,
        SIN
    }
