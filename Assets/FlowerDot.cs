using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerDot : MonoBehaviour
{
    public FlowerType type;
    public FlowerDotsManager dotsManager;
    public LineRenderer lineRenderer;
    private void Start()
    {
        dotsManager = FlowerDotsManager.instance;
    }


    private void OnMouseDown()
    {
       dotsManager.currentFlowerType = type;
    }
}
