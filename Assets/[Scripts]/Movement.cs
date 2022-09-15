using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10.0f;
    public Boundry boundry;
    public float verticalPos;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(0.0f, verticalPos);
    }

    // Update is called once per frame
    void Update()
    {

        Move();
        //CheckBounds();
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        //float y = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        //transform.position += new Vector3(x, 0, 0);

        transform.position += new Vector3(x, 0, 0);
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, boundry.min, boundry.max), verticalPos);
        //Mathf.Clamp(x,boundry.min,boundry.max)
        //transform.position = new Vector2(transform.position.x + x, 0);
        //transform.position = new Vector2(transform.position.x + x,transform.position.y + y);
    }

    void CheckBounds()
    {
        if (transform.position.x > boundry.max)
        {
            transform.position = new Vector2(boundry.max, verticalPos);
        }
        if (transform.position.x < boundry.min)
        {
            transform.position = new Vector2(boundry.min, verticalPos);
        }
    }
}
