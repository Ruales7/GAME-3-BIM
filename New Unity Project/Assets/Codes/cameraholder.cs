using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraholder : MonoBehaviour
{
    public Transform cameraposition;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = cameraposition.position;
    }
}
