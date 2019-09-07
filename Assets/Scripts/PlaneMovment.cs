using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovment : MonoBehaviour
{
    public float Speed;


    void Start()
    {
        Speed = Random.Range(0.2f, 0.4f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    enum trajectorys
    {
        line,
        square,
        sin
    }
}
