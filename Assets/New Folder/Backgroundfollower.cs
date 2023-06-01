using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroundfollower : MonoBehaviour
{
    public Transform followme;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         this.transform.position = new Vector3(followme.position.x, followme.position.y, 10.0f);
    }
}
