using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{

    public Transform cam;
    public Transform player;
    public float CamDistance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        cam.position = player.position + new Vector3(0, 6, -CamDistance);

    }
}
