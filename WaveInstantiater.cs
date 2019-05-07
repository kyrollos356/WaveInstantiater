using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveInstantiater : MonoBehaviour
{
    public GameObject currentWave;
    public GameObject[] waves;
    int waveIndex=0;
    CubeIstantiater[] findShips;
   
    void Update()
    { 
        checkIfEmpty(currentWave);
        if (currentWave == null)
        {
            InstantiateWave();
        }
    }
    private void InstantiateWave()
    {
        currentWave = waves[waveIndex];
        Instantiate(currentWave,transform.position,Quaternion.identity);
        waveIndex = waveIndex + 1;
    }
    private void checkIfEmpty(GameObject currentWave)
    {
        findShips = FindObjectsOfType<CubeIstantiater>();

        if (findShips.Length == 0)
        {
            this.currentWave = null;
            if (waveIndex == 5) { Application.LoadLevel("Winner"); }
        }
    }
}
