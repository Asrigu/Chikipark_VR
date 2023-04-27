using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUIpizza : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject ppPizza;
    [SerializeField] private GameObject chPizza;
    [SerializeField] private List<GameObject> pizzaSpawn;
     private List<GameObject> spawnedPizzas = new List<GameObject>();

    public void SpawnPP()
    {
        
    }

    public void SpawnCH()
    {
        
    }

    public void DestroyPizza()
    {
        foreach (GameObject item in spawnedPizzas)
        {
            Destroy(item);
        }
        spawnedPizzas.Clear();
    }
    
}
