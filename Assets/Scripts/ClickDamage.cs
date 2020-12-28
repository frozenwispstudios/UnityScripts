using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDamage : MonoBehaviour
{
    [SerializeField] GameObject Cube1;
    [SerializeField] GameObject Cube2;

    Health health1;
    Health health2;

    void Start()
    {
        health1 = Cube1.GetComponent<Health>();
        health2 = Cube2.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            health1.TakeDamage(2);
        }
        if (Input.GetMouseButtonDown(1))
        {
            health2.GetComponent<Health>().TakeDamage(5);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            health1.Heal(1);
            health2.Heal(1);
        }
    }
}
