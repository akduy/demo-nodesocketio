using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] float speed;
    
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var direction = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position).ConvertToVector2().normalized;
            transform.Translate(speed * direction * Time.deltaTime);
        }
    }
}
