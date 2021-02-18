using UnityEngine;
public class AudioController : MonoBehaviour
{
    [SerializeField]
    AudioSource hitAudioSource;
    [SerializeField]
    AudioSource themeAudioSource;

    private void Awake()
    {
        PlayThemeClip();
    }

    public void PlayHitSound()
    {
        hitAudioSource.Play();
    }


    public void PlayThemeClip()
    {
        themeAudioSource.Play();
    }
    public void PlaySound(AudioClip audioClip)
    {
        hitAudioSource.PlayOneShot(audioClip);
    }

}

