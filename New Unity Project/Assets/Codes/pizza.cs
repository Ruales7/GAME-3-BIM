using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pizza : MonoBehaviour
{
    public Vector3 rotateChange;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateChange);
    }

    void OnTriggerEnter(Collider Other)
    {
        Destroy(gameObject);
        scoring.thescore -= 1;
    }
}