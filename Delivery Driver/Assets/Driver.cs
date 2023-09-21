using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float speedDriver = 12f;
    [SerializeField] float speedHorizontal = 120f;
    [SerializeField] float slowSpeed = 7f;
    [SerializeField] float boostSpeed = 20f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        float verticalInput = Input.GetAxis("Vertical");

        transform.Rotate(0, 0, -horizontalInput * speedHorizontal * Time.deltaTime);
        transform.Translate(0, verticalInput * speedDriver * Time.deltaTime, 0);
        
    }
      void OnTriggerEnter2D(Collider2D other) {
    
        if(other.tag == "SpeedUp"){
         speedDriver = boostSpeed;
        }  
    }
     void OnCollisionEnter2D(Collision2D other) {
        speedDriver = slowSpeed;
    }
 
}
