using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCrate : MonoBehaviour
{
    [Header("Visuals")]
    public GameObject Container;
    public float rotationSpeed = 180f;

    [Header("Gameplay")]
    public int health = 50;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Container.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

}