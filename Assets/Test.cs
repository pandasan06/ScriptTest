using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {
        int[] array = new int[5];

        array[4] = 20;
        array[3] = 60;
        array[2] = 10;
        array[1] = 50;
        array[0] = 30;

        for (int x = 0; x < 5; x++)
        {
            Debug.Log(array[x]);
        }
        for (int y = 4; -1 < y; y--)
        {
            Debug.Log(array[y]);
        }
    }


        // Update is called once per frame

        void Update()
        {

        }
    }
   
      