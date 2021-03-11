using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField] private AudioClip[] _clips = null;

    private int _clipIndex = 1;

    private AudioSource _audio = null;

    private bool _audioPlaying = false;

    void Start()
    {
        StartCoroutine(PlaySound());
        _audio = GetComponent<AudioSource>();
    }

    IEnumerator PlaySound()
    {
        yield return new WaitForSeconds(Random.Range(10f, 20f));

        _clipIndex = Random.Range(0, _clips.Length - 1);
        _audio.PlayOneShot(_clips[_clipIndex], 1f);

        yield return new WaitForSeconds(_clips[_clipIndex].length);
        StartCoroutine(PlaySound());
    }
}
