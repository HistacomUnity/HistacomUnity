using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win95System : MonoBehaviour
{
    // General things
    public GameObject startMenu;

    // For function hoverStartItem()
    public GameObject itemHoverPanel;
    public Text itemText;

    /// <summary>
    /// Toggles the Start Menu. Uses EventTriggers in Unity to accomplish this.
    /// </summary>
    public void toggleStart()
    {
        if (startMenu.activeInHierarchy) startMenu.SetActive(false);
        else startMenu.SetActive(true);
    }

    /// <summary>
    /// Hover state for start menu items. Uses EventTriggers in Unity to accomplish this.
    /// </summary>
    public void hoverStartItem(bool hovering)
    {
        if (hovering)
        {
            itemHoverPanel.SetActive(true);
            itemText.color = Color.white;
        } else {
            itemHoverPanel.SetActive(false);
            itemText.color = Color.black;
        }
    }
}
