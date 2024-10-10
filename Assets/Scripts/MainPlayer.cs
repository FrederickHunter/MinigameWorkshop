using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{

    public float horizontalInput;
    public float Xspeed;
    public float verticalInput;
    public float Zspeed;
    public float Xrange;
    public float Zrange = 23;

    // Start is called before the first frame update
    void Start()
    {
        // Randomize MainPlayer's X and Y speed
        Xspeed = Random.Range(10.0f, 25.0f);
        Zspeed = Random.Range(25.0f, 45.0f);
        Xrange = Random.Range(23, 42);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * Xspeed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * Zspeed);

        // Player can't leave area

        if (transform.position.x < -Xrange)
        {
            transform.position = new Vector3(-Xrange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > Xrange)
        {
            transform.position = new Vector3(Xrange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -Zrange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -Zrange);
        }
        if (transform.position.z > Zrange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, Zrange);
        }

    }
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
