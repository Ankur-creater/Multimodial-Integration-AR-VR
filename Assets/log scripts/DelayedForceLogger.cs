using UnityEngine;
using System.Collections;

public class DelayedForceLogger : MonoBehaviour
{
    public float stylusMass = 0.05f; // Adjust based on Phantom stylus mass (kg)
    public float logDelay = 0.1f; // Delay time in seconds before logging force

    private Vector3 lastVelocity;
    private float collisionStartTime;
    private bool isColliding = false;

    void FixedUpdate()
    {
        // Store previous velocity for impulse calculation
        lastVelocity = GetComponent<Rigidbody>().linearVelocity;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (!isColliding)
        {
            isColliding = true;
            collisionStartTime = Time.time; // Store collision start time
            StartCoroutine(LogForceWithDelay(collision));
        }
    }

    IEnumerator LogForceWithDelay(Collision collision)
    {
        yield return new WaitForSeconds(logDelay); // Wait before logging

        // Calculate change in velocity
        Vector3 velocityBeforeImpact = lastVelocity;
        Vector3 velocityAfterImpact = GetComponent<Rigidbody>().linearVelocity;
        Vector3 deltaV = velocityAfterImpact - velocityBeforeImpact;

        // Compute impulse: J = m * Δv
        float impulse = stylusMass * deltaV.magnitude;

        // Compute collision duration
        float collisionDuration = Time.time - collisionStartTime;
        if (collisionDuration <= 0) collisionDuration = Time.fixedDeltaTime; // Avoid division by zero

        // Compute impulse force: F = J / Δt
        float impulseForce = impulse / collisionDuration;

        Debug.Log($"[DELAYED] Impulse (J): {impulse:F4} Ns");
        Debug.Log($"[DELAYED] Impulse Force (F): {impulseForce:F4} N over {collisionDuration:F4} seconds");

        isColliding = false;
    }
}
