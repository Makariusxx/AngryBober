using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruction : MonoBehaviour
{
    public GameObject Victim;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(Victim, 5);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
