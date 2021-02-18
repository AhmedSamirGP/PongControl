using UnityEngine;
public class AudioController : MonoBehaviour
{
    [SerializeField]
    AudioSource hitAudioSource;

    public void PlayHitSound()
    {
        hitAudioSource.Play();
    }

    public void PlaySound(AudioClip audioClip)
    {
        hitAudioSource.PlayOneShot(audioClip);
    }

}

