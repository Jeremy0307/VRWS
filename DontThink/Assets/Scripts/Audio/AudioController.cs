using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField] private AudioClip[] _clips = null;

    private int _clipIndex = 0;

    private AudioSource _audio = null;

    private bool _audioPlaying = false;

    private void Start()
    {
        _audio = gameObject.GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (!_audio.isPlaying)
        {
            _clipIndex = Random.Range(0, _clips.Length - 1);
            _audio.clip = _clips[_clipIndex];
            _audio.PlayDelayed(Random.Range(20f, 50f));
        }
    }
}
