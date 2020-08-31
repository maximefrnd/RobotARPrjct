using UnityEngine;


[ExecuteInEditMode]
public class FaceCamera : MonoBehaviour
{

    Transform cam;
    Vector3 targetAngle = Vector3.zero;

    void Start()
    {
        cam = Camera.main.transform;
    }

    public void Face() {

        transform.LookAt(cam);
        targetAngle = transform.localEulerAngles;
        targetAngle.x = -90;
        targetAngle.z = 0;
        transform.localEulerAngles = targetAngle;
        
    }



}
