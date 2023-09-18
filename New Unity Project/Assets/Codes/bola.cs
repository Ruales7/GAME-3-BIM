using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour
{
    public Vector3 positionChange;

    // Start is called before the first frame update
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        transform.position += positionChange;
    }

    // Update is called once per frame
    void Start()
    {
        
    }
}
