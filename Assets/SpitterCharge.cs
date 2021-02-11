using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpitterCharge : MonoBehaviour
{
    public ChargingSlider slider;

    void Awake()
    {
        slider = GameObject.FindGameObjectWithTag("holdsCharging").GetComponent<ChargingSlider>();
    }

    public void ChargeWithSpitterDeath()
    {
        slider.AddSpitterCharge();
    }
}
