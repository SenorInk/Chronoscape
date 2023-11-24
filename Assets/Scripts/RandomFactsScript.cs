using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RandomFactsScript : MonoBehaviour
{
    [Header("List of facts")]
    public List<String> facts;
    [Header("Elements")]
    public GameObject randomfactPanel;
    public TextMeshProUGUI factText;
    public void ShowRandomFact()
    {
        randomfactPanel.SetActive(true);
        bool factServed = true;
        do
        {
            try
            {
                factText.text = facts[new System.Random().Next(0, facts.Count)];
            }
            catch (IndexOutOfRangeException)
            {
                factServed = false;
            }
        } while (!factServed);
    }

    public void CloseFactPanel()
    {
        randomfactPanel.SetActive(false);
    }
}