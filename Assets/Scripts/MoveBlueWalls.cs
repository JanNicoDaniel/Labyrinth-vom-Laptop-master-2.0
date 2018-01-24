﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlueWalls : MonoBehaviour
{
    //Diese Methode soll alle Türen bewegen
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (this.name == "WhiteTrigger")
            {
                {
                    if (this.transform.position.y == 0.1f)
                    {
                        MoveDown.setWhiteDown(true);
                        this.transform.position = new Vector3(transform.position.x, transform.position.y - 2, transform.position.z);
                    }
                }
            }
            if (this.name == "BlueTrigger")
            {
                if (this.transform.position.y == 0.1f)
                {
                    MoveDown.setBlueDown(true);
                    this.transform.position = new Vector3(transform.position.x, transform.position.y - 2, transform.position.z);
                }
            }
            if (this.name == "RedTrigger")
            {
                if (this.transform.position.y == 0.1f)
                {
                    MoveDown.setRedDown(true);
                    this.transform.position = new Vector3(transform.position.x, transform.position.y - 2, transform.position.z);
                }
            }
            if (this.name == "YellowTrigger")
            {
                if (this.transform.position.y == 0.1f)
                {
                    MoveDown.setYellowDown(true);
                    this.transform.position = new Vector3(transform.position.x, transform.position.y - 2, transform.position.z);
                }
            }
            if (this.name == "GreenTrigger")
            {
                if (this.transform.position.y == 0.1f)
                {
                    MoveDown.setGreenDown(true);
                    this.transform.position = new Vector3(transform.position.x, transform.position.y - 2, transform.position.z);
                }
            }
            if (this.name == "OrangeTrigger")
            {
                if (this.transform.position.y == 0.1f)
                {
                    MoveDown.setOrangeDown(true);
                    this.transform.position = new Vector3(transform.position.x, transform.position.y - 2, transform.position.z);
                }
            }
            if (this.name == "PurpleTrigger")
            {
                if (this.transform.position.y == 0.1f)
                {
                    MoveDown.setPurpleDown(true);
                    this.transform.position = new Vector3(transform.position.x, transform.position.y - 2, transform.position.z);
                }
            }
            if (this.name == "TealTrigger")
            {
                if (this.transform.position.y == 0.1f)
                {
                    MoveDown.setTealDown(true);
                    this.transform.position = new Vector3(transform.position.x, transform.position.y - 2, transform.position.z);
                }
            }
        }
        }
    }
