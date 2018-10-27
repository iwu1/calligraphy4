﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderScript : MonoBehaviour {
    public bool triggered = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider c)
    {
        Debug.Log("triggered " + c.name);
        triggered = true;
        transform.parent.GetComponent<parentScript>().childTriggered(gameObject.name);
    }
}
