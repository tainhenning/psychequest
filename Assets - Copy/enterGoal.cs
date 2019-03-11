using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enterGoal : MonoBehaviour
{
    public GameObject completeScreen;
    public Transform satellite;
    public GameObject satelliteObj;
    private Transform thisTransform;

    private void Start()
    {
        thisTransform = GetComponent<Transform>();
    }
    private void Update()
    {
        if(satellite.position.x + 0.1 > thisTransform.position.x && satellite.position.x - 0.1 < thisTransform.position.x)
        {
            if(satellite.position.y + 0.1 > thisTransform.position.y && satellite.position.y - 0.1 < thisTransform.position.y)
            {
                completeScreen.SetActive(true);
                Destroy(satelliteObj);
            }
        }
    }
}
