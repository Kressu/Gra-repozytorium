using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

 class MenuStript : MonoBehaviour
{
   void OnStartGame(string mojaGra)

    {
        
        SceneManager.LoadScene(mojaGra);
    
    
    }
}
