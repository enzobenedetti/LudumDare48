using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSquid : MonoBehaviour
{
    private GameObject squid;

    private Vector3 mousePosition;

    private void Awake()
    {
        squid = this.gameObject;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetSquidRotation();


    }

    private void SetSquidRotation()
    {
        Vector3 position = Camera.main.WorldToScreenPoint(squid.transform.position);
        Vector3 direction = Input.mousePosition - position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        squid.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
