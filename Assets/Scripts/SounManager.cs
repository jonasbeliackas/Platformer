using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SounManager : MonoBehaviour
{
    public static SounManager Instance;
    [SerializeField] private AudioSource _master, _effects;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }
    public void PlaySoundMaster(AudioClip clip)
    {
        if (!_master.isPlaying)
        {
            Debug.Log("start sound");
            _master.clip = clip;
            _master.loop = true;

            _master.Play();
        }

    }
    public void PlaySoundEffect(AudioClip clip)
    {
        _effects.PlayOneShot(clip);

    }

    public void ChangeVolume(float val)
    {
        AudioListener.volume = val;
    }

    public float GetVolume()
    {
        return AudioListener.volume;
    }
}
