using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.VersionControl;
using UnityEngine;

public class UserInput : MonoBehaviour
{
   public Rigidbody2D ballRigidbody2D;
   public float speed = 5f;
   public float jumpForce = 300f;
   
   public Vector2 direction;
   public Vector2 yDirection;

   void Update()
   {
      direction.x = Input.GetAxis("Horizontal") * speed;                //<<for Joystick or pressing two arrows at the same time.
      ballRigidbody2D.AddForce(direction, ForceMode2D.Force);
       
      /*if (Input.GetKey(KeyCode.RightArrow))
      {
         ballRigidbody2D.AddForce(direction, ForceMode2D.Force);
      }

      if (Input.GetKey(KeyCode.LeftArrow))
      {
         ballRigidbody2D.AddForce(-direction, ForceMode2D.Force);
      }
         expanded version of joystick code above.  they do the same thing*/

      if (Input.GetButtonDown("Jump")) //GetButtonDown only reads the press once.  GetKey means you gotta hold it down to keep reading it.
      {
         yDirection.y = jumpForce;
         ballRigidbody2D.AddForce(yDirection, ForceMode2D.Force);
      }
   }
}
