using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject VFX;
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Target"))
        {
            print("hit" + other.gameObject.name+"!");
            GameObject localVFX = Instantiate(VFX, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        else
        {
            GameObject localVFX = Instantiate(VFX, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
