using UnityEngine;
using System.Collections;

public class HapticLatencyLogger : MonoBehaviour
{
    private float touchTime;
    private float forceFeedbackTime;

    void OnCollisionEnter(Collision collision)
    {
        touchTime = Time.time; // Log touch moment
        Debug.Log($"Touch Time: {touchTime:F4} sec");

        StartCoroutine(LogForceFeedbackDelay());
    }

    IEnumerator LogForceFeedbackDelay()
    {
        yield return new WaitForSeconds(0.00f); // Simulating delay

        forceFeedbackTime = Time.time;

        float latency = forceFeedbackTime - touchTime;
        Debug.Log($"Force Feedback Delay: {latency * 1000:F2} ms");
    }
}

