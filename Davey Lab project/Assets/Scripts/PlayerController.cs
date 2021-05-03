using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float xRange = 15f;
    
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
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        float horizontalInput = Input.GetAxis("Horizontal");
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
