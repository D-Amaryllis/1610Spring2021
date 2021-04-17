using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody playerRB;
    private bool powerup = false;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        
        playerRB.AddForce(Vector3.forward * speed * verticalInput);
        playerRB.AddForce(Vector3.right * speed * horizontalInput);
    }

    public IEnumerator PowerupActive()
    {
        powerup = true;
        Debug.Log("Powerup is true");
        if (powerup = true)
        {
            yield return new WaitForSeconds(5);
            powerup = false;
            Debug.Log ("Powerup is false");
        }
    }
}
