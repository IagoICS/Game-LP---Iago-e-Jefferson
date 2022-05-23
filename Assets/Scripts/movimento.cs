using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{

  
  public float movementSpeed =1;
    public float jumpForce =1;
    private Rigidbody2D _rigidbody;
    public Animator animator;

    private float horizontal;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
   private void Update()
    {
        
      var movement = Input.GetAxis("Horizontal");

      transform.position += new Vector3(movement,0,0) * Time.deltaTime * movementSpeed;
      if(Input.GetAxis("Horizontal")!=0){
            //movendo
            animator.SetBool("taMovendo", true);
        }else{
          //parado
          animator.SetBool("taMovendo", false);
        }
    
     if(!Mathf.Approximately(0,movement))
     transform.rotation= movement < 0 ? Quaternion.Euler(0,180,0) : Quaternion.identity;
     
     if(Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y)< 0.001f)
     {
          _rigidbody.AddForce(new Vector2(0,jumpForce), ForceMode2D.Impulse);
     }
    }

}
