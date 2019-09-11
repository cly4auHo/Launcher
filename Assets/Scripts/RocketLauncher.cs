using UnityEngine;

public class RocketLauncher : MonoBehaviour
{
    [SerializeField] private GameObject rocketPrefab;
    public bool IsRocketLaunched => rocket;
    private GameObject rocket;

    void Update()
    {
        if (!rocket)
        {
            if (Input.touchCount > 0 || Input.GetMouseButtonDown(0))
            {
                rocket = GameObject.Instantiate(rocketPrefab, Vector3.zero, Quaternion.identity);
            }
        }
    }
}
