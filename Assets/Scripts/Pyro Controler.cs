using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyroController : MonoBehaviour
{
    public GameObject player;
    public float angularVelocity;

    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
        if (Input.GetKey(KeyCode.D)) transform.Rotate(0, 90f * angularVelocity * Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.A)) transform.Rotate(0, -90f * angularVelocity * Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.W)) transform.Rotate(0, 0, 0);
        if (Input.GetKey(KeyCode.S)) transform.Rotate(0, 180f * angularVelocity * Time.deltaTime, 0);
    }
}
