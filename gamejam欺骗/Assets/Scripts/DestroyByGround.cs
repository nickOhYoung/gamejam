using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByGround : MonoBehaviour {
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.transform.tag);
        if (collision.transform.tag == "Ground")
        {
            Destroy(this.gameObject);
        }
    }
}
