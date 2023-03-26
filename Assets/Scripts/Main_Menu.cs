using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeScene(string Level_Menu)
    {
        SceneManager.LoadScene(Level_Menu);
    }

}
