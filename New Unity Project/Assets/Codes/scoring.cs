using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoring : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject scoretext;
    public static int thescore = 25;

    // Update is called once per frame
    void Update()
    { 
        scoretext.GetComponent<Text>().text = "Pizzas restantes: " + thescore;
        if (thescore <= 0)
        {
            scoretext.GetComponent<Text>().text = "Parabéns, você conseguiu entregar todas";
        }
    }
}
