using UnityEngine;
public class TeacherGreetings : MonoBehaviour
{
    //  public Animator cameraAnimator;
    [SerializeField]
    private Animator teacher;

    [SerializeField]
    private Camera cameraControl;

    private bool isCursorLocked = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            teacher.SetBool("isGreeting", true);
            cameraControl.enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            teacher.SetBool("isGreeting", false);
            cameraControl.enabled = true;
        }
    }
}
