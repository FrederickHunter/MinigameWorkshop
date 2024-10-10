using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKillZone : MonoBehaviour
{
    private float westKZ = 100;
    private float eastkZ = -100;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > westKZ)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < eastkZ)
        {
            Destroy(gameObject);
        }
        if (transform.position.z > westKZ)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < eastkZ)
        {
            Destroy(gameObject);
        }
    }
}
