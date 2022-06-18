using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject upButton;
    public GameObject greenLight;
    public bool isOn;
    public bool isUp;
    // Start is called before the first frame update
    void Start()
    {
        upButton.SetActive(isUp);
        greenLight.SetActive(isOn);
        if(isOn)
        {
            Main.Instance.SwitchChange(1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseUp()
    {
        isUp = !isUp;
        isOn = !isOn;
        upButton.SetActive(isUp);
        greenLight.SetActive(isOn);
        if(isOn)
        {
            Main.Instance.SwitchChange(1);
        }
        else
        {
            Main.Instance.SwitchChange(-1);
        }
    }
}
