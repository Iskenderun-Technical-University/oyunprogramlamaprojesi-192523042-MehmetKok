using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{   
    private CharacterController controller;
    private Vector3 yon;
    public float forwardSpeed=10;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
     yon.z = forwardSpeed;
    
    }

    private void GuncelUpdate()
    {
         controller.Move(yon*Time.fixedDeltaTime);

    }
}
