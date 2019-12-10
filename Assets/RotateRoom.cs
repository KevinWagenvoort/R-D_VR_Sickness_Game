using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRoom : MonoBehaviour
{
    public Vector3 RotateAmountMax;

    // Update is called once per frame
    void Update()
    {
        Vector3 RandomRotate = new Vector3(Random.Range(0, RotateAmountMax.x), Random.Range(0, RotateAmountMax.y), Random.Range(0, RotateAmountMax.z));
        transform.Rotate(RandomRotate * Time.deltaTime);x
    }
}
