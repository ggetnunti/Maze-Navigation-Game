using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    public AudioClip background;
    public AudioClip bush;
    public AudioClip coin;
    public AudioClip doorOpen;
    public AudioClip gameover;
    public AudioClip levelcomplete;
    public AudioClip bigCoin;
    public AudioClip heart;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
