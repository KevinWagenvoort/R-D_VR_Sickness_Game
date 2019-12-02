using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    private int timesScored = 0;


    void Update()
    {
        Debug.Log(timesScored);
    }

    public void Score(bool collision, GameObject gameObject)
    {
        if (collision)
        {
            timesScored++;
        }
    }
}
