using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Terry's motor so we can use it
    public KinematicPlayerMotor motor;
    public PlayerInput input;
    bool isTeleportable = false;
    //implement animations here or in another script
    // Start is called before the first frame update
    void OnEnable()
    {
        input.currentActionMap["Jumping"].performed += jumpPlayer;
        input.currentActionMap["Teleport"].performed += teleportPlayer;
    }
    private void OnDisable()
    {
        try
        {
            input.currentActionMap["Jumping"].performed -= jumpPlayer;
        }
        catch(NullReferenceException)
        {
            Debug.Log("Failed to unsubscribe from the jumpPlayer method due to input manager being removed first");
        }
        
    }
    private void teleportPlayer(InputAction.CallbackContext obj)
    {
        if (isTeleportable) 
        {

        }
    }
    private void jumpPlayer(InputAction.CallbackContext obj) //this will be called when the player hits the space bar or whatever binding I give to jump and simply apply the jump vector in terry's code
    {
        motor.JumpInput();
    }
    private void Update()//we'll use update to handle our actual movement
    {
        Vector2 movementVec2 = input.currentActionMap["Walking"].ReadValue<Vector2>();
        motor.MoveInput(new Vector3(movementVec2.x, 0.0f, movementVec2.y));

        //check the teleport spot and place the special effects
    }

    private void CheckTeleport() 
    {
        
    }

}
