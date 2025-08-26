using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    float rotZ = 0f;
    
    private void Update()
    {
        float xMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float yMove = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(xMove, yMove, 0);
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            rotZ = 90f;
            
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            rotZ = -90f;
            
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            rotZ = 180f;
            
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            rotZ = 0f;
            
        }
        transform.localRotation = Quaternion.Euler(0, 0, rotZ);


    }

}
