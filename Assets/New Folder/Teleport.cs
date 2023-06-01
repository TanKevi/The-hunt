using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform player;
    public float newx;
    public float newy;
    public float newz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        player.transform.position = new Vector3(newx, newy, newz);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player"){
        player.transform.position = new Vector3(newx, newy, newz);
        }
    }
}
