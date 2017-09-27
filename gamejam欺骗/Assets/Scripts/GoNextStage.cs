using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoNextStage : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            Debug.Log(Application.loadedLevelName);
            switch (Application.loadedLevelName)
            {
                case "startScene":
                    {
                       // Application.LoadLevel("scene1");
                        break;
                    }
                case "scene1":
                    {
                        Application.LoadLevel("scene2");
                        break;
                    }
                case "scene2":
                    {
                        Application.LoadLevel("scene3");
                        break;
                    }
                case "scene3":
                    {
                        Application.LoadLevel("scene4");
                        break;
                    }
                case "scene4":
                    {
                        //Application.LoadLevel("scene5");
                        break;
                    }
                case "scene5":
                    {
                        break;
                    }
            }
        }
    }
}
