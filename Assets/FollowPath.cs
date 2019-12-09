using PathCreation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{

    public GameObject gameObject;
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
        //gameObject.transform.position = pathCreator.path.GetPointAtDistance(distanceTraveled);
        gameObject.GetComponent<Rigidbody>().velocity = pathCreator.path.GetPointAtDistance(distanceTraveled).normalized * speed;

        gameObject.transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTraveled);
        Debug.Log(pathCreator.path.GetRotationAtDistance(distanceTraveled));
    }

    public void ResetPath(bool collision, GameObject game)
    {
        if (collision)
        {
            distanceTraveled = 0;
            speed++;

            gameObject.transform.position = new Vector3(0, 0.211f, 0);
        }
    }
}
