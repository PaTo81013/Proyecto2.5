using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _AudioManager : MonoBehaviour
{
    public static _AudioManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    [SerializeField] private AudioSource musicSource, SfxSource = default;

    public void PlaySFX(AudioClip clip)
    {
        SfxSource.PlayOneShot(clip);
    }
    public void PlayMusic(AudioClip music)
    {
        musicSource.clip = music;
        musicSource.Play();
    }
}
