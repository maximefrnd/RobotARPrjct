using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gaze : MonoBehaviour
{

    public GameObject robot;

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                GameObject go = hit.collider.gameObject;
                if (go = robot)
                    {
                        CallRobot();
                    }
            }
    }

    void CallRobot(){
        robot.GetComponent<FaceCamera>().Face();
        robot.GetComponent<Talk>().talking();
    }
}
