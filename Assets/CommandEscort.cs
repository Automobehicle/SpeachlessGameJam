using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandEscort : MonoBehaviour
{

    GameObject escort;
    public static bool hiding = false;
    // Start is called before the first frame update
    void Start()
    {
        escort = GameObject.FindGameObjectWithTag("Escort");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            hiding = !hiding;
        }
    }


}
