using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    public float depth = 1;
    Player player;

    public float destroyPoint = -28;
    public float spawnPoint = 85;

    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float realVelocity = player.velocity.x / depth;
        Vector2 pos = transform.position;
        

        pos.x -= realVelocity * Time.fixedDeltaTime;

        if (pos.x <= destroyPoint)
            pos.x = spawnPoint;

  

        transform.position = pos;
    }
}
