using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ChargingSlider : MonoBehaviour
{
    public GameObject endPost;
    public GameObject exit;
    public GameObject spawners;
    public Slider slider;

    [Header("Pedestal Lights")]
    public GameObject startingLights;
    public GameObject finishingLights;

    private int chomperCharge = 20;
    private int spitterCharge = 25;
    private bool charged = false;

    int i = 0;

    void Start()
    {
        slider.value = 0;
    }

    private void Update()
    {
        if (slider.value >= slider.maxValue) FullyCharged();
    }

    void FixedUpdate()
    {
        if (charged) return;
        i++;
        if(i >= 100)
        {
            i = 0;
            slider.value -= 3;
        }
    }

    public void AddChomperCharge()
    {
        slider.value += chomperCharge;
    }

    public void AddSpitterCharge()
    {
        slider.value += spitterCharge;
    }

    void FullyCharged()
    {
        slider.value = 100;
        charged = true;
        slider.transform.GetChild(1).GetChild(0).GetComponent<Image>().color = Color.green;

        endPost.SetActive(true);
        exit.SetActive(true);
        startingLights.SetActive(false);
        finishingLights.SetActive(true);
        spawners.SetActive(false);
    }
}
