using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBehavior : MonoBehaviour
{
    public static FoodBehavior instance;
    public float foodSpeed;


    // Update is called once per frame
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    private void Update()
    {
        gameObject.transform.Translate(Vector3.forward * Time.deltaTime * foodSpeed);       
    }

    private void OnCollision(Collision collision)
    {
        if (collision.collider.CompareTag("Animal"))
        {           
            AnimalBehaior.instance.fillHunger();
            Destroy(gameObject);
        }
    }

}
