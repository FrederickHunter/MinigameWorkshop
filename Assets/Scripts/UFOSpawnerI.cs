using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOSpawnerI: MonoBehaviour
{
    public GameObject UFOSpawn;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Summons());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator Summons()
    {
        yield return new WaitForSeconds(12);
        Instantiate(UFOSpawn, new Vector3(Random.Range(-42, 42), 1.5f, 30), UFOSpawn.transform.rotation);
        StartCoroutine(Summons());
    }
}
