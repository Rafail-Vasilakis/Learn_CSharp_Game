using UnityEngine;
using UnityEngine.UI;

public class UIFollowPlayer : MonoBehaviour
{ 
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Vector3 offset;

    [Header("Logic")]
    public Camera cam;
  
  

    private void Start()
    {
        cam = Camera.main;
    }
    private void Update()
    {

        Vector3 pos = cam.WorldToScreenPoint(playerTransform.position + offset);
        // Set the canvas position based on the player's position and orientation
        
        if(transform.position != pos)
            transform.position = pos;
    }
}
