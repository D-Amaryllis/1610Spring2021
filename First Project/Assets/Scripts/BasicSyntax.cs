using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSyntax : MonoBehaviour
{
  void Start()
  {
    //I'm eriting a one line comment to myself.
    Debug.Log(transform.position.x);

    if (transform.position.y <= 5f)
    {
      /*I'm A bit nervous that I'm not fully wrapping my head around all this.
       But I've just got to push through!
       I don't think I'm as far behind as I thought I was
       Moving has been an ordeal.
       It should have been done two days ago but our roommates keep dragging their feet.
       I can't afford to drag it out this long.  pls...just do it*/
      
      Debug.Log("I'm about to hit the ground!");
    }
  }
}
