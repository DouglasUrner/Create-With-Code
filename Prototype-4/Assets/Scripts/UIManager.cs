using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
  public GameObject leftUIPanel;

  void Update()
  {

  }

  public void StartButtonClicked()
  {
    leftUIPanel.gameObject.SetActive(false);
  }
}