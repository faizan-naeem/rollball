using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
   public void OnLevelSelect(int level)
   {
       SceneManager.LoadScene("Level" + level.ToString());
   }
}
