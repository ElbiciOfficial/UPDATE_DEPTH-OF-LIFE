using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour {


    [SerializeField] private string horizontalInputName;
    [SerializeField] private string verticalInputName;

    [SerializeField] private float walkSpeed, runSpeed;
    [SerializeField] private float runBuildUpSpeed;
    [SerializeField] private KeyCode runKey;

    private float movementSpeed;
   // public Animator rifle;

    private CharacterController charController;

    private void Awake()
    {
        charController = GetComponent<CharacterController>();
      
    }

    private void Update()
    {
        
        if(Time.time >= 6)
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
        if (Input.GetKey(runKey))
        {
            //rifle.SetBool("run", true);
            movementSpeed = Mathf.Lerp(movementSpeed, runSpeed, Time.deltaTime * runBuildUpSpeed);
        }
        else
        {
            //rifle.SetBool("run", false);
            //rifle.SetBool("walk", true);
            movementSpeed = Mathf.Lerp(movementSpeed, walkSpeed, Time.deltaTime * runBuildUpSpeed);
        }
    }


}
