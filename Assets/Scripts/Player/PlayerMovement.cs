using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//In case of forgetting to add the rigidbody, unity will automatically add it
[RequireComponent(typeof(Rigidbody))]

public class PlayerMovement : MonoBehaviour
{
    //To select the type of movement to test, we create an enum to contain the opcions in the inspector
    enum MoveType { addingForce, velocityMove, movePositionMove}

    [Header("Type of movement")]
    [SerializeField] MoveType moveType;
    

    //The speed at the player moves
    [SerializeField] float WalkingSpeed;


    //The vector that holds the direction of movement
    Vector3 direction;
    [SerializeField] Animator _ani;
    //The rigidbody of the player
    Rigidbody myRB;

   

    //Detecte if more or less distance

  
    


    [SerializeField] UserActions _controls;
    private InputAction move;
 


    private void Awake()
    {
        _controls = new UserActions();
    }

    public void OnEnable()
    {

        move = _controls.Player.Movement;
        move.Enable();


    }

    public void OnDisable()
    {
        move.Disable();
       
    }

    void Start()
    {
        //Gets the rigidbody component from the player
        myRB = GetComponent<Rigidbody>();

        //Set value

    }

    // Update is called once per frame
    void Update()
    {

        //We ge the direction from the input horizontal (a / d)
        // direction = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        
        //direction = move.ReadValue<Vector2>();
        direction = move.ReadValue<Vector2>();
        if (!GlobalBools._playerCanMove)
        {

            if (direction.x > 0)
            {
                //if(direction.x > 0 && direction.x < 0.1)
                transform.rotation = Quaternion.Euler(0, 90, 0);
                _ani.SetBool("Walking", true);
            }
            else if (direction.x < 0)
            {

                transform.rotation = Quaternion.Euler(0, -90, 0);
                _ani.SetBool("Walking", true);
            }
            else
            {

                _ani.SetBool("Walking", false);
            }
        }
    }

    void FixedUpdate()
    {
        if (!GlobalBools._playerCanMove)
        {
            //After selecting the move type we can test any of them thanks to this switch case 
            switch (moveType)
            {
                case MoveType.addingForce:
                    AddingForceMovement();
                    break;
                case MoveType.velocityMove:
                    VelocityMovement();
                    break;
                case MoveType.movePositionMove:
                    MovePositionMovement();
                    break;
            }
        }

    }

    private void AddingForceMovement()
    {
      
        //Adds a force that pushes the player
        myRB.AddForce(direction * WalkingSpeed);
        
    }

    private void VelocityMovement()
    {
       
        //Stablished the velocity of the rigidbody
        myRB.velocity = direction * WalkingSpeed;
       
    }

    private void MovePositionMovement()
    {
       
        //Moves the player in a direction
        myRB.MovePosition(transform.position + (direction * WalkingSpeed * Time.fixedDeltaTime));
        
    }
}
