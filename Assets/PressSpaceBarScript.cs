using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressSpaceBarScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject projectile;
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
            Debug.Log("Wrong Button! " + Time.time + " seconds");
    }
 
}