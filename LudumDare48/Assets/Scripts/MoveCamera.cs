using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField]
    private GameObject squid;

    [SerializeField]
    private float speed = 2.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = squid.transform.position - this.transform.position;
        direction.z = 0f;
        this.transform.position += direction.normalized * speed * Time.deltaTime;
    }
}
