using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTeclas : MonoBehaviour
{
    public GameObject[] objetos;
    private int counter = 0; 

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < objetos.Length; i++)
        {
            objetos[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            objetos[counter].SetActive(false);
            counter--;
            if (counter == -1)
            {
                counter = objetos.Length -  1;
            }
            objetos[counter].SetActive(true);
            
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            objetos[counter].SetActive(false);
            counter++;
            if (counter == objetos.Length)
            {
                counter = 0 ;
            }
            objetos[counter].SetActive(true);
        }
    }
}
