using UnityEngine;
using System.Collections;

public class PlayerController1 : MonoBehaviour
{
    private RaycastHit hit;
    private Vector3 surfaceNormal;
    private Vector3 forwardRelativeToSurfaceNormal;
    public float speed = 6.0f;
    public float jumpSpeed = 10.0f;
    public float gravity = 20.0f;
    private Vector3 moveDirection = Vector3.zero;   //Means Vector3(0,0,0)
    private CharacterController playerController;

    // Use this for initialization
    void Start () {

        playerController = GetComponent<CharacterController>();

        }
	
	// Update is called once per frame
	void Update () {

        //Move Character
	   MoveCharacter();
        //Rotate Character
       CharacterFaceRelativeToSurface();
        

	}


    void MoveCharacter()
    {
        if (playerController.isGrounded)
            {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection = moveDirection * speed;
            if (Input.GetKeyDown("space"))
                moveDirection.y = jumpSpeed;

            }

        moveDirection.y -= gravity * Time.deltaTime;
        playerController.Move(moveDirection*Time.deltaTime);
    }

    private void CharacterFaceRelativeToSurface()
    {
        //For Detect The Base/Surface.
        if (Physics.Raycast(transform.position, -Vector3.up, out hit, 10))
            {
            surfaceNormal = hit.normal; // Assign the normal of the surface to surfaceNormal
            forwardRelativeToSurfaceNormal = Vector3.Cross(transform.right, surfaceNormal);
            Quaternion targetRotation = Quaternion.LookRotation(forwardRelativeToSurfaceNormal, surfaceNormal); //check For target Rotation.
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * 2); //Rotate Character accordingly.
            }
        }

}
