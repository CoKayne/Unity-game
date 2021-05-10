using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
  public PlayerMove movement;
  public Rigidbody rb;
  void OnCollisionEnter (Collision collied){

      if(collied.collider.tag == "barrier"){
          movement.enabled = false;
          rb.useGravity = false;
          rb.mass = 0.0001f;
          rb.AddForce(0, 5 * Time.deltaTime, 0);
      }

  }

}
