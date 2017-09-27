using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap1 : MonoBehaviour {

    public GameObject A;
    public float x;
    public float y;
    public float z;
 void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject .tag=="Player") {
            Instantiate(A,new Vector3(x,y,z),Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
