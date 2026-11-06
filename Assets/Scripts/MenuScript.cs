using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void A_Play()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void A_Main()
    {
        SceneManager.LoadSceneAsync(0);
    }

}