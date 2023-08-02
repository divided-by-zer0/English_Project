using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAttack : MonoBehaviour
{
    public GameObject[] ataques;
    void Start()
    {
        ataques[Random.Range(0, 4)].SetActive(true);

    }
}
