using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour {

    float rotSpeed = 0;
    bool slot = false;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetMouseButtonDown(0))
        {
            slot = true;   
        }
        if (slot)
        {
            this.rotSpeed += 1;
            if (this.rotSpeed > 50)
                slot = false;
        }
        else
        {
            this.rotSpeed *= 0.96f;
        }
        transform.Rotate(0, 0, this.rotSpeed);
        
    }
}
