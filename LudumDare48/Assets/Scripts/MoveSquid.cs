using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSquid : MonoBehaviour
{
    private GameObject squid;

    private Vector3 mousePosition;

    [SerializeField]
    private float speed = 3f;
    private float swimSpeed = 0f;

    [SerializeField]
    private float maxMomentum = 2f;
    private float swimMomentum;
    private bool isSwimming = false;

    private void Awake()
    {
        squid = this.gameObject;
        swimMomentum = maxMomentum;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 squidPosition = Camera.main.WorldToScreenPoint(squid.transform.position);
        Vector3 direction = Input.mousePosition - squidPosition;
        direction.z = 0f;

        SetSquidRotation(direction);

        if (Input.GetMouseButtonDown(0))
        {
            isSwimming = true;
        }
        if (isSwimming)
        {
            swimSpeed = speed * swimMomentum / maxMomentum;
            swimMomentum -= Time.deltaTime;
        }
        if (swimMomentum <= 0f)
        {
            if (Input.GetMouseButton(0))
            {
                isSwimming = true;
            }
            else
                isSwimming = false;
            swimMomentum = maxMomentum;
        }
        if (isSwimming)
            squid.transform.position += direction.normalized * swimSpeed * Time.deltaTime;
    }

    private void SetSquidRotation(Vector3 direction)
    {
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        squid.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
