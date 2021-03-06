﻿using Mapbox.Examples;
using Mapbox.Unity.Utilities;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FaceCamera : MonoBehaviour
{
    public Camera Camera;
    public TextMeshPro PelletNumberText;
    static int pelletNumber = 0;
    //public PositionWithLocationProvider playerPosition;

    // Start is called before the first frame update
    void Start()
    {
        pelletNumber++;
        PelletNumberText.text = "Pellet #: " + pelletNumber;
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera == null)
        {
            this.transform.LookAt(Camera.main.transform.position);
        }
        else
        {
            this.transform.LookAt(Camera.transform.position);
        }
        //playerPosition.GetComponent<PositionWithLocationProvider>();
        //float distance = Vector3.Distance(playerPosition._locationProvider.CurrentLocation.LatitudeLongitude.ToVector3xz(), this.gameObject.transform.localPosition.ToVector2d().ToVector3xz());
        //distanceText.text = "Pellet #: " + distance;
    }
}
