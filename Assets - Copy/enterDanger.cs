using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enterDanger : MonoBehaviour
{
    public GameObject endScreen;
    public Transform satellite;
    public GameObject satelliteObj;
    private Transform thisTransform;

    private void Start()
    {
        thisTransform = GetComponent<Transform>();
    }
    private void Update()
    {
        if (satellite.position.x + 1 > thisTransform.position.x && satellite.position.x - 1 < thisTransform.position.x)
        {
            if (satellite.position.y + 1 > thisTransform.position.y && satellite.position.y - 1 < thisTransform.position.y)
            {
                endScreen.SetActive(true);
                Destroy(satelliteObj);
            }
        }
    }
}
