using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
    using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Image image;
    public Sprite normalSprite;
    public Sprite hoverSprite;

    // Switch the image used on hover.
    public void SwitchButton(bool hovering)
    {
        if (hovering) image.sprite = hoverSprite;
        if (!hovering) image.sprite = normalSprite;
    }

    // Exiting the game logic - mainly for the difference between Unity Editor and compiled builds
    public void ExitGame()
    {
        #if UNITY_EDITOR
            // Application.Quit doesn't work without this modification.
            EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }
}
