using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeUi : MonoBehaviour
{
    public GameObject objectToFollow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Resetear el transform del objeto para que quede en 0, así no se raya cuando invertimos la rotación
        transform.localPosition = Vector2.zero;
        
        //Centra los valores para que gire alrededor del 0,0 del objeto
        Vector2 direction = new Vector2(
            transform.position.x - objectToFollow.transform.position.x,
            transform.position.y - objectToFollow.transform.position.y);
        
        //Clamp redondo, regla de tres, metameticas
        float magnitude = direction.magnitude;
        float clampedMagnitude = Mathf.Clamp(magnitude, -0.05f, 0.05f);
        direction = new Vector2(-direction.x * clampedMagnitude / magnitude, -direction.y * clampedMagnitude / magnitude);
        
        //Magia
        transform.localPosition = direction;
    }
}
