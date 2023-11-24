using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{
    [Space]
    [SerializeField] AudioSource _musicAudio = null;
    [SerializeField] AudioSource _flapAudio = null;
    [SerializeField] AudioSource _gameOverAudio = null;
    [SerializeField] AudioSource _scoreAudio = null;
    [Space]
    [SerializeField] AudioClip _flapClip = null;
    [SerializeField] AudioClip _scoreClip = null;

    public void PlayMusic()
    {
        _musicAudio.Play();
    }

    public void StopMusic()
    {
        _musicAudio.Stop();
    }

    public void PlayFlapSfx()
    {
        _flapAudio.PlayOneShot(_flapClip);
    }

    public void PlayScoreSfx()
    {
        _scoreAudio.PlayOneShot(_scoreClip);
    }

    public void PlayGameOverSfx()
    {
        _gameOverAudio.Play();
    }

    public void StopGameOverSfx()
    {
        _gameOverAudio.Stop();
    }
}
