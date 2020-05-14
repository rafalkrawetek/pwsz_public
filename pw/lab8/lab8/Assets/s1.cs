using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] kule = GameObject.FindGameObjectsWithTag("kula");
        foreach (GameObject kula in kule)
            Destroy(kula);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
