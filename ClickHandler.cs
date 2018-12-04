using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class ClickHandler : MonoBehaviour, IInputClickHandler {

    public GameObject text;

    Color original;

    public void Start()
    {
        original = this.GetComponent<Renderer>().material.color;
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
      

        text.SetActive(!text.activeSelf);


        Renderer r = this.GetComponent<Renderer>();

        if (text.activeSelf)
        {
            r.material.SetColor("_Color", Color.blue);
        } else
        {
            r.material.SetColor("_Color", original);
        }

    }

}
