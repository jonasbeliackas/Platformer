using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour
{

    [SerializeField] private AudioSource run;
    [SerializeField] private AudioSource jump;
    [SerializeField] private AudioSource land;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void runSound()
    {
        Debug.Log("runSound");
        run.Play();
    }
    void jumpSound()
    {
        Debug.Log("jumpSound");
        jump.Play();
    }
    void landSound()
    {
        Debug.Log("landSound");
        land.Play();
    }
}
