using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPS : MonoBehaviour
{
    //�������� NPS
    public int health = 67;

    //������� NPS
    public int level = 2;

    //�������� NPS
    public float speed= 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        //��������+��� NPS
        health = health + level;
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
