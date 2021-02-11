using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChomperCharge : MonoBehaviour
{
    public ChargingSlider slider;

    void Awake()
    {
        slider = GameObject.FindGameObjectWithTag("holdsCharging").GetComponent<ChargingSlider>();    
    }

    public void ChargeWithChomperDeath()
    {
        slider.AddChomperCharge();
    }
}
