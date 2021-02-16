using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.VersionControl;
using UnityEngine;

public class UserInput : MonoBehaviour
{
   public Rigidbody2D ballRigidbody2D;
   public Vector2 direction;
   public Vector2 yDirection;
   public float speed = 3f;

   void Update()
   {
      /*
       *  direction.x = Input.GetAxis("Horizontal");  <<for Joystick or pressing two arrows at the same time.
       */
      if (Input.GetKey(KeyCode.RightArrow))
      {
         ballRigidbody2D.AddForce(direction, ForceMode2D.Force);
      }

      if (Input.GetKey(KeyCode.LeftArrow))
      {
         ballRigidbody2D.AddForce(-direction, ForceMode2D.Force);
      }

      if (Input.GetButtonDown("Jump"))
      {
         ballRigidbody2D.AddForce(yDirection, ForceMode2D.Force);
      }
   }
}
