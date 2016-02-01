using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {



	void Start () {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = transform.forward * 20;
    }
	

	
}
