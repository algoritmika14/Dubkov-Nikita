using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPS : MonoBehaviour
{
    //Здоровье NPS
    public int health = 67;

    //Уровень NPS
    public int level = 2;

    //Скорость NPS
    public float speed= 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        //Здоровье+Лвл NPS
        health = health + level;
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
