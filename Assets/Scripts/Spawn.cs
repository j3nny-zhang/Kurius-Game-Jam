using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Randomize(GetComponent<Transform>());
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Collider" || collision.gameObject.tag == "Car")
        {
            Randomize(GetComponent<Transform>());
        }
    }

    private void Randomize(Transform pos)
    {
        System.Random random = new System.Random();

        double pos_x = random.NextDouble() * 9 - 4.5;
        double pos_y = random.NextDouble() * 9 - 4.5;

        Vector3 p = new Vector3((float)pos_x, (float)pos_y, 1f);
        pos.position = p;

    }
}
