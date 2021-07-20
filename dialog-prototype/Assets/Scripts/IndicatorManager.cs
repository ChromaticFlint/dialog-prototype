using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorManager : MonoBehaviour
{
  [SerializeField] private GameObject lightOne;
  [SerializeField] private GameObject lightTwo;
  [SerializeField] private GameObject lightThree;

  List<GameObject> lights = new List<GameObject>();

  private void Start()
  {
    lights.Add(lightOne);
    lights.Add(lightTwo);
    lights.Add(lightThree);

    foreach (GameObject light in lights)
    {
      light.SetActive(false);
    }
  }

  public void EnableLight(int light)
  {
    int index = light - 1;

    lights[index].SetActive(true);
  }
}
