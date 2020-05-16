using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuStript : MonoBehaviour
{
  public void OnStartGame(string SampleScene)

    {
        
        SceneManager.LoadScene(SampleScene);
    
    
    }
}
