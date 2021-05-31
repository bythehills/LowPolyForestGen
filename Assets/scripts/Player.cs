using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //creds brackeys 
    public CharacterController controller;
    public Transform camera;

    public float speed;
    public float smoothturn = 0.1f;
    float turnvel = 200f;
    float yrotation;

    static bool created;
    bool isGrounded;

    public Animator animator;
    private void Awake()
    {
        if (!created) //only creates player once
        {
            DontDestroyOnLoad(this.gameObject); //never destroy first instance of object
            created = true;
        } else
        {
            Destroy(this.gameObject); //otherwise destroy instance
        }
    }
    private void Update()
    {
        float horizontal = 0;
        float vertical = 0;
        if (Input.GetKey(KeyCode.W)) //forwards or backwards z-xis
        {
            vertical = 1;
        } else if (Input.GetKey(KeyCode.S))
        {
            vertical = -1; 
        }

        if (Input.GetKey(KeyCode.D)) //right or left y axis
        {
            horizontal = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            horizontal = -1;
        }

        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized; 
        if (direction.magnitude >= 0.1f) //if moving
        {
            animator.SetBool("isIdle", false);
            yrotation += horizontal * Time.deltaTime * turnvel; //adds or decreases to yrotation depending on whether turning right or left
            Quaternion rotation = Quaternion.Euler(0, yrotation, 0); //turns yrotation into a vector3 rotation
            transform.rotation = rotation; //applies it to gameobject
            transform.Translate(direction * speed * Time.deltaTime); //time.deltatime to make frame rate equal across devices

        } else
        {
            animator.SetBool("isIdle", true);
        }

    }

    //private void FixedUpdate()
   // {
        //RaycastHit hit;
        //Vector3 grounddir = new Vector3(0, -1, 0);
        //if (Input.GetKey(KeyCode.Space))
        //{
           // if(Physics.Raycast(transform.position, grounddir, 1))
           // {
               // Debug.Log("grounded");
               // transform.Translate.y += 2f;
          //  }
       // }


    //}
}
