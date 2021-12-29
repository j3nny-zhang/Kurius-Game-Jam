using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using static Spawn;

public class FindTrigger : MonoBehaviour
{
    public Spawn car;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Collider" || collision.gameObject.tag == "Car")
        {
            car.Randomize(gameObject);
        }
    }

}
