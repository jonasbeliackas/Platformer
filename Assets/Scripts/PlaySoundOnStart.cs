using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnStart : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;
    [SerializeField] bool master;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("on start");
        if (master) SounManager.Instance.PlaySoundMaster(_clip);
        else SounManager.Instance.PlaySoundEffect(_clip);

    }

}
