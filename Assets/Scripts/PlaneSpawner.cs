using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneSpawner : MonoBehaviour
{
    [SerializeField] private GameObject planePrefab;

    private float xLeft = 0f;
    private float xRight = 8f;
    private float yTop = 4.5f;
    private float yBot = 0.5f;

    private GameObject currentPlane;
    private Vector3 currentPosition;

    void Update()
    {
        if (!currentPlane)
        {
            CreatePlane();
        }
    }

    void CreatePlane()
    {
        currentPosition = new Vector3(Random.Range(xLeft, xRight), Random.Range(yBot, yTop), 0);
        currentPlane = Instantiate(planePrefab, currentPosition, Quaternion.identity);
    }
}
