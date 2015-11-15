using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{


    public float rotateSpeed;
    public float forwardSpeed;
    public float jumpSpeed = 5;
    public float gravity = 20.0f;
    private CharacterController playerController;

	// Use this for initialization
	void Start ()
	{

	    playerController = GetComponent<CharacterController>();

	}
	
	// Update is called once per frame
	void Update () {

            //Allow Player to Jump
        if (Input.GetKeyDown("space") && (playerController.isGrounded))
        { 
	        playerController.Move((Vector3.up) * jumpSpeed);
	    }

        //Character Movement: Rotate, forward and back using adsw keys (set in project input prefs)
        transform.Rotate(0,Input.GetAxis("Horizontal") * rotateSpeed, 0);
	    Vector3 forward = transform.TransformDirection(Vector3.forward);    //Look at which way the transform is facing so we can apply a forward speed
	    float speed = forwardSpeed*Input.GetAxis("Vertical");               //Calculate a positive or negative number for speed
	    playerController.SimpleMove(speed*forward);                         //Move

        

    }
}
