using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moiscript : MonoBehaviour
{
    public string updateString;  
   public string startString = "Bober";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(startString);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(updateString);
    }
}
