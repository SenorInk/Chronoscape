using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsScript : MonoBehaviour
{

    public GameObject settingsPanel;
    public void ShowSettings()
    {
        settingsPanel.SetActive(true);
        
    }
    public void QuitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    public void CloseFactPanel()
    {
        settingsPanel.SetActive(false);
    }
}
