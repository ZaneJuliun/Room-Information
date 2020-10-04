using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{

    public void StartLevel()
    {
        SceneManager.LoadScene("Level01");
    }

}