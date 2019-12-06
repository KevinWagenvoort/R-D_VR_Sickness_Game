using PathCreation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{

    public GameObject camera;
    public float speed;
    public PathCreator pathCreator;
    private float distanceTraveled;

    // Start is called before the first frame update
    void Start()
    {
        distanceTraveled = pathCreator.path.GetClosestDistanceAlongPath(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        distanceTraveled += speed * Time.deltaTime;
        camera.transform.position = pathCreator.path.GetPointAtDistance(distanceTraveled);

        camera.transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTraveled);
        camera.transform.Rotate(new Vector3(0, -90, 0));
    }
}
