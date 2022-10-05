using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBooster : MonoBehaviour
{
    public float SpeedMultiplyer;
    public GameObject Ball;
    public Rigidbody rb;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            Ball = other.gameObject;
            rb = Ball.GetComponent<Rigidbody>();
            rb.AddForce(rb.velocity * SpeedMultiplyer, ForceMode.VelocityChange);
        }
    }


}
