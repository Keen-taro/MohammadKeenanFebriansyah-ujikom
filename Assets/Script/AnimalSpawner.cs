using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    public Transform[] spawn;
    public GameObject[] animal;

    private int index, index_2;

    // Update is called once per frame
    void Update()
    {
        index = Random.Range(0, spawn.Length);
        index_2 = Random.Range(0, animal.Length);
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        Instantiate(animal[index_2], spawn[index]);
        yield return new WaitForSeconds(4f);
    }
}
