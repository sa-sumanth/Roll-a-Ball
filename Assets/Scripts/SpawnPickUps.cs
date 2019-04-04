using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPickUps : MonoBehaviour
{
    public GameObject pickUps;

    void Start()
    {
        Vector3 location;
        for(int i = 0; i < 8; i++)
        {
            location = getLoc(i);

            GameObject pickUp = Instantiate<GameObject>(pickUps, location, Quaternion.identity);
        }
    }

    Vector3 getLoc(int i)
    {
        if (i < 4)
            if (i < 2)
                return new Vector3(Random.Range(-8f, 0f), 0.5f, Random.Range(-8f, 0f));
            else
                return new Vector3(Random.Range(-0f, 8f), 0.5f, Random.Range(-8f, 0f));
        else
            if (i < 6)
                return new Vector3(Random.Range(-8f, 0f), 0.5f, Random.Range(0f, 8f));
            else
                return new Vector3(Random.Range(0f, 8f), 0.5f, Random.Range(-8f, 0f));
    }
}
