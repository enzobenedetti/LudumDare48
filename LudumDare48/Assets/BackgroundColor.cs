using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundColor : MonoBehaviour
{
    [SerializeField]
    private GameObject goal;

    [SerializeField]
    private GameObject squid;

    [SerializeField]
    private Color startColor;

    [SerializeField]
    private Color endColor;

    Vector2 startPos;
    float distance;

    // Start is called before the first frame update
    void Start()
    {
        startPos = squid.transform.position;
        distance = Vector2.Distance(startPos, goal.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        Camera.main.backgroundColor = Color.Lerp(endColor, startColor, Vector2.Distance(squid.transform.position, goal.transform.position) / distance);
    }
}
