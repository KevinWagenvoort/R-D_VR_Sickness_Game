using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FramerateController : MonoBehaviour
{
    private float framerate = 72;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = (int)framerate;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        framerate -= Time.deltaTime;
        Application.targetFrameRate = (int)framerate;
        Debug.Log(framerate);
    }
}
