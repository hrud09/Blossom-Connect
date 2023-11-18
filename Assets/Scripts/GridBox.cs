using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBox : MonoBehaviour
{


    public FlowerType thisGridType;
    private void OnMouseOver()
    {
        if (Input.GetMouseButton(0)) {

            if (FlowerDotsManager.instance.currentFlowerType == FlowerType.Green) { 
            
                GetComponent<SpriteRenderer>().color = Color.green;
                thisGridType = FlowerType.Green;
            }
        }
    }

    private void OnMouseDown()
    {

        FlowerDotsManager.instance.currentFlowerType = thisGridType;
    }
    private void OnMouseUp()
    {

       
    }
}
