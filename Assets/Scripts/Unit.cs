using UnityEngine;

public class Unit : MonoBehaviour
{
    private Vector3 targetPosition;
    [SerializeField]private MouseWorld mouseWorld;

    [SerializeField]private Animator unitAnimator;

    private void Update()
    {
        
        float stoppingDistance = .1f;
        if(Vector3.Distance(transform.position, targetPosition) > stoppingDistance)
        {
            Vector3 moveDirection = (targetPosition - transform.position).normalized;
            float moveSpeed = 4f;
            transform.position += moveDirection * moveSpeed * Time.deltaTime;
            float rotationSpeed = 10f;
            transform.forward = Vector3.Lerp(transform.forward, moveDirection, Time.deltaTime * rotationSpeed);
            unitAnimator.SetBool("IsWalking", true);
        }
        else
        {
            unitAnimator.SetBool("IsWalking", false);
        }

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 mouseClickPosition = MouseWorld.GetPosition();
            Move(mouseClickPosition);
        }
    }
    private void Move(Vector3 targerPosition)
    {
        this.targetPosition = targerPosition;
 
    }
}
