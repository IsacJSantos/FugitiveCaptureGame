using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightController : MonoBehaviour
{
    [SerializeField]
    float _speed;

    Rigidbody2D _rigid;

    float horizontalInput;
    float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement() 
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        _rigid.velocity = new Vector2(horizontalInput * _speed, verticalInput * _speed);
    }
}
