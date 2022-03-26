using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleCam : MonoBehaviour
{
    public GameObject mercurio;
    public GameObject venus;
    public GameObject terra;
    public GameObject marte;
    public GameObject jupter;
    public GameObject saturno;
    public GameObject lua;
    public int indice;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(indice == 0)
        {
            transform.position = mercurio.transform.position;
        }
        if(indice == 1)
        {
            transform.position = venus.transform.position;
        }
        if(indice == 2)
        {
            transform.position = terra.transform.position;
        }
        if(indice == 3)
        {
            transform.position = marte.transform.position;
        }
        if(indice == 4)
        {
            transform.position = jupter.transform.position;
        }
        if(indice == 5)
        {
            transform.position = saturno.transform.position;
        }
        
         if(indice == 6)
        {
            transform.position = lua.transform.position;
        

        if(input.GetKeyDown(KeyCode.A))
        {
            indice = indice -1;
        }
        if(input.GetKeyDown(KeyCode.D))
        {
            indice = indice +1;
        }



        
    }
}
