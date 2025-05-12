using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("---------- Audio Source ----------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource kickSource;
    [SerializeField] AudioSource SFXSource;

    [Header("---------- Audio Clip ----------")]
    public AudioClip peaceBg;
    public AudioClip combatBg;
    public AudioClip kickBg;
    public AudioClip walkSfx;
    public AudioClip deathSfx;
    public AudioClip dialogueSfx;

    private void Start()
    {
        musicSource.clip = peaceBg;
        musicSource.Play();

        kickSource.clip = kickBg;
        kickSource.Play();
    }

    public void PlaySfx(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
