using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skrypt : MonoBehaviour {

	public GameObject[] obiekty;
	void Start () {
		InvokeRepeating("Losuj", 0, 3f);
	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Return))
			CancelInvoke("Losuj");

		if (Input.GetKeyDown(KeyCode.Space))
			Losuj();

		if (Input.GetKeyDown(KeyCode.Alpha1))
			Generuj(0);

		if (Input.GetKeyDown(KeyCode.Alpha2))
			Generuj(1);

		if (Input.GetKeyDown(KeyCode.Alpha3))
			Generuj(2);

		if (Input.GetKeyDown(KeyCode.Alpha4))
			Generuj(3);

		if (Input.GetKeyDown(KeyCode.Alpha5))
			Generuj(4);
	}
	void Losuj()
    {
		Generuj(Random.Range(0, obiekty.Length));
    }
	void Generuj(int num)
    {
		Instantiate(obiekty[num], transform.position, Quaternion.identity);
    }
}
