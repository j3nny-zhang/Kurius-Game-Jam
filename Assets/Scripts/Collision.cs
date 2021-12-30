using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using static Score;

public class Collision : MonoBehaviour
{
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Car")
        {
            Destroy(collision.gameObject);
            scoreValue++;

            if (scoreValue == 6)
            {
                SceneManager.LoadScene("Closing Cutscene");
            }
        }
    }
}
