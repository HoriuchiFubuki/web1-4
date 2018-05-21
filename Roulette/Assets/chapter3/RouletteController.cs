using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour {

    float rotSpeed = 0;
    int i = 0;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetMouseButtonDown(0))
        {
            i = 1;   
        }
        if (i == 1)
        {
            this.rotSpeed += 1;
            if (this.rotSpeed > 50)
                i = 0;
        }
        else
        {
            this.rotSpeed *= 0.96f;
        }
        transform.Rotate(0, 0, this.rotSpeed);
        
    }
}
