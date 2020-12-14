using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChanger : MonoBehaviour
{
    public void SetColourRed()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
    public void SetColourBlue()
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }
}
