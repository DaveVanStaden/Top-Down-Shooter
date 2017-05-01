using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour {

    public GameObject Enemyprefab;
    private int timer = 5;
    private int quick = 0;

    // Use this for initialization

    // Update is called once 
    //per frame
	void Update () {
        timer = timer - 1;

        if (timer == 0)
        {
            timer = 150 - quick;
            quick = quick + 2;
            Vector3 pos = new Vector3(Random.Range(-35, 35),1, Random.Range(-35, 35));
            Instantiate(Enemyprefab, pos, Quaternion.identity);
            
        }
        if (quick >= 150)
        {
            quick = 148;
        }

    }

}
