using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalBehaior : MonoBehaviour
{
    public static AnimalBehaior instance;
    public float animalSpeed;
    public int score;

    public Image hungryBar;
    private float currentHungry;
    public float full;

    private void Start()
    {
        hungryBar.fillAmount = currentHungry / full;
    }

    private void Update()
    {
        hungryBar.fillAmount = currentHungry / full;
        //gameObject.transform.parent.Translate(-Vector3.forward * Time.deltaTime * animalSpeed);

        if(currentHungry == full)
        {
            Destroy(gameObject);
            ScoreManager.instance.GetPoint(score);
        }
    }

    public void fillHunger()
    {
        currentHungry += 25f;
    }
}
