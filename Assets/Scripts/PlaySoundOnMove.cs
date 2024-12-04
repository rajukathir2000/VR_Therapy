using UnityEngine;

public class PlaySoundOnMove : MonoBehaviour
{
    private Vector3 lastPosition;
    public AudioSource audioSource;

    void Start()
    {
        lastPosition = transform.position;

        if (audioSource == null)
        {
            Debug.LogError("AudioSource component missing from GameObject!");
        }
    }

    void Update()
    {
        if (transform.position != lastPosition)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
        lastPosition = transform.position;
    }
}
