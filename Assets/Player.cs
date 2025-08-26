using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 5f;

    private void Update()
    {
        float xMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float yMove = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(xMove, yMove, 0);

        if(xMove > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else if(xMove < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
    }
}
