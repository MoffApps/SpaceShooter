using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {



	// Use this for initialization
	void Start () {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = transform.forward * 20;
    }
	
	// Update is called once per frame
	
}
