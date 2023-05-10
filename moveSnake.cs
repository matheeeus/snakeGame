using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSnake : MonoBehaviour
{

    float moveX, moveY;
    public float velocity;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");

        if(moveX == moveY || moveX == -moveY)
            moveY = 0;
        velocity = 10;

        transform.position = transform.position + new Vector3(moveX,moveY,0) * Time.deltaTime * velocity;
        



    }
}
