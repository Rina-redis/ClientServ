using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class CameraMovement : NetworkBehaviour
{
    // Start is called before the first frame update
    public GameObject myPlayer;
    public float distance = 100f;

    void LateUpdate()
    {
        if (isLocalPlayer)
        {
            transform.position = myPlayer.transform.position + Vector3.up * distance;
        }
      
    }
}
