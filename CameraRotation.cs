using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public Transform Camera;
    public Transform player;
    public float MouseX;
    public float MouseY;
    public float sens;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MouseX += Input.GetAxis("Mouse X") * sens * Time.deltaTime;
        MouseY += Input.GetAxis("Mouse Y") *sens * Time.deltaTime;


        MouseY = Mathf.Clamp(MouseY,-90,90);

        player.rotation = Quaternion.Euler(0, MouseX, 0);
        Camera.rotation = Quaternion.Euler(-MouseY, MouseX, 0);
    }
}
