using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Jogar()
    {
        SceneManager.LoadScene("Pizzaria");
    }

    // Update is called once per frame
    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }
}
