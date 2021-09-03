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

        for (int i = 0; i <5; i++)
        {
            Debug.Log(array[i]);
        }
}
        // Update is called once per frame
   
        private void Update()
        {

        }
}
   
      