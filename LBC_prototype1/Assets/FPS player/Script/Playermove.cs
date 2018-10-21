using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour {


    [SerializeField] private string horizontalInputName;
    [SerializeField] private string verticalInputName;

    [SerializeField] private float walkSpeed, runSpeed;
    [SerializeField] private float runBuildUpSpeed;
    [SerializeField] private KeyCode runKey;
    [SerializeField] private KeyCode walkKey;

    private float movementSpeed;
    public Animator marcus;

    private CharacterController charController;

    private void Awake()
    {
        charController = GetComponent<CharacterController>();
      
    }

    private void Update()
    {
     

        if (Time.time >= 6)
        {
            PlayerMovement();
        }
      
        
    }

    private void PlayerMovement()
    {
       
        float horizInput = Input.GetAxis(horizontalInputName);

        float vertInput = Input.GetAxis(verticalInputName);

        Vector3 forwardMovement = transform.forward * vertInput;
        Vector3 rightMovement = transform.right * horizInput;

        charController.SimpleMove(Vector3.ClampMagnitude(forwardMovement + rightMovement, 1.0f) * movementSpeed);
      
        SetMovementSpeed();
    }

    private void SetMovementSpeed()
    {
        marcus.SetBool("idle", true);
        marcus.SetBool("walk", false);
        marcus.SetBool("run", false);
        if (Input.GetKey(runKey))
        {
            marcus.SetBool("run", true);
            marcus.SetBool("walk", false);
            marcus.SetBool("idle", false);
            movementSpeed = Mathf.Lerp(movementSpeed, runSpeed, Time.deltaTime * runBuildUpSpeed);
        }
        else if(Input.GetKey(walkKey))
        {

            marcus.SetBool("walk", true);
            marcus.SetBool("run", false);
            marcus.SetBool("idle", false);
            movementSpeed = Mathf.Lerp(movementSpeed, walkSpeed, Time.deltaTime * runBuildUpSpeed);
        }
       
    }


}
