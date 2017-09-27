using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanArray : MonoBehaviour {
    public GameObject Spwan;
    public GameObject Array;

    bool IsSpwan = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.transform.tag);
        if (collision.transform.tag == "Player" && IsSpwan == false)
        {
            for (int i = 0; i < 3; i++)
            {
                float n = -0.5f;
                GameObject go = Instantiate(Array, Spwan.transform.position - new Vector3(n, 0, 0), Quaternion.identity);
                n += 0.5f;
            }
            IsSpwan = true;
        }
    }

}
