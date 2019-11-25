using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class FramerateController : MonoBehaviour
{
    public TextMeshProUGUI text;

    public int desiredFPS;

    void Awake()
    {
         Application.targetFrameRate = -1;
         QualitySettings.vSyncCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetUp(OVRInput.RawButton.B))
        {
            if (desiredFPS < 120)
            {
                desiredFPS += 5;
            }
        }
        else if (OVRInput.GetUp(OVRInput.RawButton.A))
        {
            if (desiredFPS > 9)
            {
                desiredFPS -= 5;
            }
        }
        text.text = "~" + desiredFPS + " fps";

        long lastTicks = DateTime.Now.Ticks;
        long currentTicks = lastTicks;
        float delay = 1f / desiredFPS;
        float elapsedTime;

        if (desiredFPS <= 0)
            return;

        while (true)
        {
            currentTicks = DateTime.Now.Ticks;
            elapsedTime = (float)TimeSpan.FromTicks(currentTicks - lastTicks).TotalSeconds;
            if (elapsedTime >= delay)
            {
                break;
            }

        }


    }
}
