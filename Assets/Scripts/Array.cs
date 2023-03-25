using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    int[] array = {20, 27, 10, 5, 30, 9};

    private void Awake() {
        array = BubbleSort(array);

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);    
        }
    }

    private int[] BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int e = 0; e < arr.Length - (i+1); e++)
            {
                if (arr[e] > arr[e+1])
                {
                    (arr[e], arr[e+1]) = (arr[e+1], arr[e]);
                }
            }
        }

        return arr;
    }
}
