using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerMovementSpeed;
    Rigidbody rb;
    public Transform pos;
    public GameObject Food;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        throwFood();
    }

    private void Movement()
    {
        float inputHorizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector3(inputHorizontal * playerMovementSpeed, 0f);
    }

    private void throwFood()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SFXController.instance.ThrowFood();
            Instantiate(Food, pos);
        }
    }
}
