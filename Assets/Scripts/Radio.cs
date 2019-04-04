﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Only for radio item
public class Radio : CollectableObject // inherits from CollectableObject because it is in equipment
{
    enum BatteryLevel { DEP, LOW, MID, HIGH}; // enum list with battery levels (depleted, low, medium, high)

    private BatteryLevel batteryStatus; // variable of type BatteryLevel storing current battery level

    void Start()
    {
        batteryStatus = BatteryLevel.DEP; // default battery level is DEP
        gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Interacive/intercom-depleted"); // load depleted sprite
    }

    public void AddBattery()
    {
        batteryStatus = BatteryLevel.HIGH; // change battery status to high
        gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Interacive/intercom-full"); // load full battery sprite
    }

    // OnMouseDown
    public void OnMouseDown()
    {
        switch (batteryStatus) // check battery status
        {
            case BatteryLevel.DEP: // battery is depleted
                isSelected = true; // mark selected for combine
                equipment.Combine(); // invoke combine method
                isSelected = false; // mark deselected
                break;

            case BatteryLevel.LOW: // battery is low
                batteryStatus = BatteryLevel.DEP; // change battery status to depleted
                gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Interacive/intercom-depleted"); // load depleted sprite
                break;

            case BatteryLevel.MID: // battery is medium
                batteryStatus = BatteryLevel.LOW; // change battery status to low
                break;

            case BatteryLevel.HIGH: // battery is high
                batteryStatus = BatteryLevel.MID; // change battery status to medium
                break;
        }
    }
}