using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class MenuNewLoadGame : MonoBehaviour
{
    public PlayableDirector playableMan;

    // Play transition
    public void LoadScene(int scene)
    {
        playableMan.Play();
        SceneManager.LoadScene(scene);
    }
}
