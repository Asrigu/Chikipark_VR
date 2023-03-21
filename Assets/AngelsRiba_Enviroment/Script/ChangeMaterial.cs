using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{

    [SerializeField]
    
    public Material otherMaterial;
    private Material originalMaterial;

    private MeshRenderer _meshRenderer = null;

    private bool isOriginal;
   
    void Awake()
    {
        //obtenemos el coponente de Mesh Renderer
        _meshRenderer = GetComponent<MeshRenderer>();
        originalMaterial = _meshRenderer.material;
        isOriginal = true;
    }

    //Cambiar el material de manera mas optima
    public void CambiarMaterial(Material matarialACambiar)
    {
        _meshRenderer.material = materialACambiar;
    }

    //Cambiar de material de manera menos optima pero mas visual
    //si tiene el material original, cambia por el other
    public void ChangeToOtherMaterial()
    {
        if (isOriginal)
        {
            _meshRenderer.material = otherMaterial;
            isOriginal = false;
        }
    }
    //ai tiene el other material, cambia por el original
    public void ChangeToOriginalMaterial()
    {
        if (!isOriginal)
        {
            _meshRenderer.material = originalMaterial;
            isOriginal = true;
        }
    }

}
