using UnityEngine;

public class PhantomImpulseCalculator : MonoBehaviour
{
    public float stylusMass = 0.05f; // Approximate mass of Phantom stylus in kg
    private Vector3 lastVelocity;
    private float collisionStartTime;

    void FixedUpdate()
    {
        // Store previous velocity for impulse calculation
        lastVelocity = GetComponent<Rigidbody>().linearVelocity;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Calculate change in velocity
        Vector3 velocityBeforeImpact = lastVelocity;
        Vector3 velocityAfterImpact = GetComponent<Rigidbody>().linearVelocity;
        Vector3 deltaV = velocityAfterImpact - velocityBeforeImpact;

        // Get the duration of collision
        collisionStartTime = Time.time;  // Store collision start time

        // Compute impulse J = m * Δv
        float impulse = stylusMass * deltaV.magnitude;

        Debug.Log($"Impulse (J): {impulse:F4} Ns");
    }

    void OnCollisionExit(Collision collision)
    {
        // Compute collision duration
        float collisionDuration = Time.time - collisionStartTime;
        if (collisionDuration <= 0) collisionDuration = Time.fixedDeltaTime; // Ensure no divide by zero

        // Compute impulse force F = J / Δt
        float impulseForce = (stylusMass * lastVelocity.magnitude) / collisionDuration;

        Debug.Log($"Impulse Force (F): {impulseForce:F4} N over {collisionDuration:F4} seconds");
    }
}
