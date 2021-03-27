using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotSpots : MonoBehaviour
{
    public bool[] hotspotsReady;
    public int[,] coordinates = {
               { -13,-3,-15,} ,
               { -7,-3,-15, } ,
               { -13,-3,-8, } ,
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
