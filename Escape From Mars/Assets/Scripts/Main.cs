using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    static public Main Instance;

    public int switchCount;
    public GameObject winText;
    public GameObject barrier;
    public GameObject[] turrets;
    private int onCount = 0;

    private void Awake()
    {
        Instance = this;
    }

    public void SwitchChange(int points)
    {
        onCount += points;
        if(onCount==switchCount)
        {
            //winText.SetActive(true);
            barrier.SetActive(false);
            for(int i=0;i<turrets.Length;i++)
            {
                turrets[i].GetComponent<Turret>().enabled = false;
            }
            gameObject.SetActive(false);
        }
    }
}
