using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;

public class MenuUIpizza : MonoBehaviour
{

    [SerializeField] private GameObject ppPizza;
    [SerializeField] private GameObject chPizza;
    [SerializeField] private List<GameObject> pizzaSpawn;
     private List<GameObject> spawnedPizzas = new List<GameObject>();

    public void SpawnPP()
    {
        DestroyPizza();
       // foreach (GameObject item in spawnedPizzas)
      //  {
           // GameObject pizza = Instantiate(ppPizza, item.transform);
            spawnedPizzas.Add(ppPizza);
       // }
    }

    public void SpawnCH()
    {
        DestroyPizza();
       // foreach (GameObject item in spawnedPizzas)
       // {
           // GameObject pizza = Instantiate(chPizza, item.transform);
            spawnedPizzas.Add(chPizza);
       // }
        
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
