using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket_Launcher : MonoBehaviour
{
    [SerializeField] private GameObject rocketPrefab;
    private Vector3 currentPosition;
    private GameObject rocket;

    void Update()
    {
        if (!rocket && Input.GetMouseButtonDown(0))
        {
            currentPosition = new Vector3(0, 0, 0);
            rocket = GameObject.Instantiate(rocketPrefab, currentPosition, Quaternion.identity);
        }
    }
}
