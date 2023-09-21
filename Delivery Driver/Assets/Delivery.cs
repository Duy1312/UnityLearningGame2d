using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
      [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1);
    bool hasPackage;

    SpriteRenderer spriteRenderer;
    void Start() {
          spriteRenderer = GetComponent<SpriteRenderer>();

    }
    [SerializeField] float timeDelayPickPackage = 0.5f;
     void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("ouch");
    }
     void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Package" && !hasPackage){
            Debug.Log("package picked up");
                 spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, timeDelayPickPackage);
       
            hasPackage = true;
        }
        if(other.tag == "Customer" && hasPackage){
            Debug.Log("Deliver package");
                spriteRenderer.color = noPackageColor;
            hasPackage = false;
        }
        //if(pakage is trigger)
        // in ra package picked up o console

    }
}
