using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
public float jump_speed;
public float speed;
private bool isGrounded;
private int pickup_count;
 
 // Start is called before the first frame update
    void Start() 
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),0.0f, 0.0f); // create a vector based on what the user is doing (in 2 dimensions)
transform.position = transform.position + movement * speed; // apply this vector to transform the position
if (Input.GetButtonDown ("Jump") && isGrounded)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jump_speed;
        }

    }
void OnCollisionEnter2D(Collision2D other){
      if(other.collider.tag == "ground"){
          isGrounded = true;
          print("grounded"); // debug - check the console
     }
     if(other.collider.tag == "pickup")
     {
        Destroy(other.collider.gameObject);

        pickup_count += 1;
        Debug.Log(pickup_count);    
    }
  }
  
 void OnCollisionExit2D(Collision2D other){
      if(other.collider.tag == "ground"){
          isGrounded = false;
          print("not grounded"); // debug - check the console
      }
  }
  
}
