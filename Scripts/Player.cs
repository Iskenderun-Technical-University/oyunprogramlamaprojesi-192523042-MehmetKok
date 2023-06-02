using System.Collections ;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 direction;
    public float forwardSpeed;

    private int desiredLane=1; 
    public float laneDistance=4;

    public float Gravity=-20;
    
    void Start()
    { 
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
     private void Update()
    {
       
        direction.z = forwardSpeed; 
        direction.y += Gravity*Time.deltaTime;

       if(Input.GetKeyDown(KeyCode.RightArrow)){
        desiredLane++;
            if(desiredLane==3)
            desiredLane=2;
       }

     if(Input.GetKeyDown(KeyCode.LeftArrow)){
        desiredLane--   ;
            if(desiredLane==-1)
             desiredLane=0;   
       }
       Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;
       
       
        if(desiredLane==0) {
            targetPosition += Vector3.left * laneDistance;
        
        }
        else if(desiredLane ==2){
            targetPosition += Vector3.right * laneDistance;
        }

       transform.position= Vector3.Lerp(transform.position, targetPosition, 80 * Time.fixedDeltaTime); 
        controller.center = controller.center;
        

    }

     void FixedUpdate()
    {
        if(!PlayerMenu.isGameStarted)
        return;
        controller.Move(direction * Time.fixedDeltaTime);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.transform.tag == "Obstacle")
        {
            PlayerMenu.gameOver = true;
        }
    }
}

