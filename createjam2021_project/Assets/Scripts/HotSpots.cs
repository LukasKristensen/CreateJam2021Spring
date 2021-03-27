using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotSpots : MonoBehaviour
{
    public bool[] hotspotsReady;
    public int[,] coordinates = {
               { -7 , -3 , -15 , } ,
               { -14 , -3 , -15 , } ,
               { -7 , -3 , -7 , } ,
             };


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            CountStates();
        }
    }


    void CountStates()
    {
        foreach(bool hotSpotsList in hotspotsReady)
        {
            print(hotSpotsList);
        }
    }
}
