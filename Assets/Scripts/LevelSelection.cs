using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelection : MonoBehaviour
{
    [SerializeField] public GameObject Hints;
    [SerializeField] public GameObject Hints1;

    public void Start()
    {
        Hints1.SetActive(false);
    }
    public void LevelSelectionShow()
    {
        Hints.SetActive(false);
        Hints1.SetActive(true);
    }
    public void LevelSelectionHide()
    {
        Hints.SetActive(true);
        Hints1.SetActive(false);
    }

}
