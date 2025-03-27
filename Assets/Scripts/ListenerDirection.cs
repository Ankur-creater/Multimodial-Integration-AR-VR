using UnityEngine;

public class ListenerDirection : MonoBehaviour
{
    public Transform listener; // Assign the AudioListener's Transform

    void Update()
    {
        if (listener == null)
        {
            Debug.LogError("Listener Transform is not assigned!");
            return;
        }

        Vector3 direction = listener.position - transform.position;
        direction.Normalize();

        // Azimuth calculation (angle in the horizontal plane)
        float azimuth = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;

        // Elevation calculation (angle in the vertical plane)
        float elevation = Mathf.Asin(direction.y) * Mathf.Rad2Deg;

        Debug.Log($"Azimuth: {azimuth}°, Elevation: {elevation}°");
    }
}
