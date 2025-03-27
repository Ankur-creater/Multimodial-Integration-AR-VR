using UnityEngine;

public class StylusTouchSound : MonoBehaviour
{
    public AudioSource audioSource; // Assign the AudioSource in the Inspector

    private void Start()
    {
        audioSource.playOnAwake = false;
        audioSource.Stop(); // Ensure the sound does not play at the start
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Stylus")) // Ensure the stylus has the "Stylus" tag
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Stylus"))
        {
            audioSource.Stop();
        }
    }
}
