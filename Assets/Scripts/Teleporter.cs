
using UnityEngine;
using UnityEngine.SceneManagement;
public class Teleporter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadSceneAsync(2);
        }
    }
}
