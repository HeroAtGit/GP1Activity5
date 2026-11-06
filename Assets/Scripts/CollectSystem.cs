using UnityEngine;
using UnityEngine.SceneManagement;
public class CollectSystem : MonoBehaviour
{
    private int pearls = 0;
    public GameObject portal;

    public void Update()
    {
        if (pearls == 5)
        {
            portal.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Collectable")
        {
            pearls++;
            Destroy(other.gameObject);
        }

        if (other.transform.tag == "Portal")
        {
            SceneManager.LoadSceneAsync(2);
        }
    }

}
