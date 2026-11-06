using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject pearlPrefab;
    public GameObject portalPrefab;
    public Transform SP1;
    public Transform SP2;
    public Transform SP3;
    public Transform SP4;
    public Transform SP5;
    public Transform portalSP;

    void Awake()
    {
        GameObject newCoin1 = Instantiate(pearlPrefab, SP1.position,
        SP1.rotation);
        GameObject newCoin2 = Instantiate(pearlPrefab, SP2.position,
        SP2.rotation);
        GameObject newCoin3 = Instantiate(pearlPrefab, SP3.position,
        SP3.rotation);
        GameObject newCoin4 = Instantiate(pearlPrefab, SP4.position,
        SP4.rotation);
        GameObject newCoin5 = Instantiate(pearlPrefab, SP5.position,
        SP5.rotation);
    }


    void SpawnCoin()
    {
        
    }
}
