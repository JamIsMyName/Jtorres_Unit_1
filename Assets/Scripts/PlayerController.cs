using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 25;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime);
        // Vector3. forward --> (0, 0, 1)
        // (0, 0, 1) * Time.deltatime = (0, 0, .001)
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }
}
