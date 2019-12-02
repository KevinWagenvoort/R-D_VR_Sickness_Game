using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TagDetectionController : MonoBehaviour
{
    [Serializable]
    public class CallbackFunction : UnityEvent<bool, GameObject> { }

    public CallbackFunction callbackFunction;

    public string tagName;

    // Called when the trigger is colliding
    void OnTriggerEnter(Collider collision)
    {
        // Check if the collision is on the right layer
        if (Detection(collision.gameObject))
        {
            callbackFunction.Invoke(true, collision.gameObject);
        }
    }

    // Called when the trigger is no longer colliding
    void OnTriggerExit(Collider collision)
    {
        // Check if the collision is on the right layer
        if (Detection(collision.gameObject))
        {
            callbackFunction.Invoke(false, collision.gameObject);
        }
    }

    // Called when the trigger is colliding
    void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is on the right layer
        if (Detection(collision.gameObject))
        {
            callbackFunction.Invoke(true, collision.gameObject);
        }
    }

    // Called when the trigger is no longer colliding
    void OnCollisionExit(Collision collision)
    {
        // Check if the collision is on the right layer
        if (Detection(collision.gameObject))
        {
            callbackFunction.Invoke(false, collision.gameObject);
        }
    }

    public bool Detection(GameObject gameObject)
    {
        return gameObject.tag.Equals(tagName);
    }
}
