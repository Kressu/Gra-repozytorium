using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Bouton123 : MonoBehaviour
{
    public Button button;
    public Sprite IMAGGEE;

    void Start()
    {
        button = GetComponent<Button>();

        button.GetComponent<Image>().sprite = IMAGGEE;
    }

    void Update()
    {

    }
}