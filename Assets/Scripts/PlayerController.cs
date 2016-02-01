using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }


    public GameObject shot;
    public Transform shotSpawn;
  

    private float nextFire;

    void Update()
    {
        if (Input.GetButton("Fire1"))// && Time.time > nextFire
        {
            nextFire = Time.time + 1;

            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }
    }


    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
       
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
     
        rigidbody.velocity = movement * 5;

        rigidbody.position = new Vector3
         (
             Mathf.Clamp(rigidbody.position.x, -6, 6),
             0.0f,
             Mathf.Clamp(rigidbody.position.z,-4, 13)
         );

        rigidbody.rotation = Quaternion.Euler(0.0f, 0.0f, rigidbody.velocity.x * -10);

    }
}