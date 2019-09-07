using UnityEngine;

public class Dot : MonoBehaviour
{
    [SerializeField] private RocketLauncher rocketLauncher;
    private const float RocketSpeed = 1f;      
    private const string PlaneTag = "Plane";
 
    void Update()
    {
        var target = GameObject.FindGameObjectWithTag(PlaneTag)?.GetComponent<Plane>();

        if (target && !rocketLauncher.IsRocketLaunched)
        {
            transform.position = (target.transform.position.magnitude / RocketSpeed * target.Speed) *  Vector3.left + target.transform.position;
        }
    }
}
