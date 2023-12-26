using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float carControl = 1f;
    [SerializeField] float carSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;

    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        float controlAmount = Input.GetAxis("Horizontal") * carControl * Time.deltaTime;
        float speedAmount = Input.GetAxis("Vertical") * carSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -controlAmount);
        transform.Translate(0, speedAmount, 0);
    }

    void OnCollisionEnter2D(Collision2D other) {
            carSpeed = slowSpeed;
    }

    void OnTriggerEnter2D(Collider2D other) {
        
        if(other.tag == "BoostSpeed") {
            carSpeed = boostSpeed;
        }
    }
}
