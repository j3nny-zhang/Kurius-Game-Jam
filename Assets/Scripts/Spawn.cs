using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawn : MonoBehaviour
{
    public GameObject[] cars;
    public System.Random random = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            Randomize(cars[i]);
        }
    }


    public void Randomize(GameObject car)
    {
        double pos_x = random.NextDouble() * 9 - 4.5;
        double pos_y = random.NextDouble() * 9 - 4.5;

        Vector3 p = new Vector3((float)pos_x, (float)pos_y, 1f);
        car.transform.position = p;

    }
}


    
