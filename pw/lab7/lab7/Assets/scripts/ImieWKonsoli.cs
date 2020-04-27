using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImieWKonsoli : MonoBehaviour
{
    public int ilosc = 2;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < ilosc; i++)
            print("Rafał");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
