using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonSpawnerIII: MonoBehaviour
{
    public GameObject DemonSpawn;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Summons());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Summons()
    {
        yield return new WaitForSeconds(3);
        Instantiate(DemonSpawn, new Vector3(80, 1.5f, Random.Range(-12, 12)), DemonSpawn.transform.rotation);
        StartCoroutine(Summons());
    }
}
