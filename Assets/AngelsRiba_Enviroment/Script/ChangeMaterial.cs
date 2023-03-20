using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{

    [Serializefield]
    private Material otherMaterial;

    private MeshRenderer _meshRenderer = null;
    private Material originalMaterial;

    void Awake()
    {
        //obtenemos el coponente de Mesh ENDERER
        _meshRenderer = GetComponent<MeshRenderer>();
        originalMaterial = _meshRenderer.material;
    }

    //public void 

}
