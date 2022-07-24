using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MovementPlayer : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 direction;
    public float forwardSpeed;
    public float jumpForce;
    public float Gravity = -20;
    public float maxspeed;
    

    public Animator animator;

    private int desiredLane = 1;
    public float laneDistance = 4;

    

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
       

    }


    
    // Update is called once per frame
    void Update()
    {
       

        if (!PlayerManager.isGameStarted)
            return;
        
        if (forwardSpeed < maxspeed)
        {
            forwardSpeed += 0.1f * Time.deltaTime;
        }

        animator.SetBool("isGameStarted",true);
        direction.z = forwardSpeed;

        direction.y += Gravity * Time.deltaTime;

        if (controller.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) || SwipeMananger.swipeUp)
            {
                animator.SetBool("isGrounded", true);
                jump();
            }
            else
                animator.SetBool("isGrounded", false);

            if (SwipeMananger.swipeDown)
            {
                StartCoroutine(Slide());
            }


        }

        if (Input.GetKeyDown(KeyCode.RightArrow)|| SwipeMananger.swipeRight)
        {
            desiredLane++;
            if (desiredLane == 3)
                desiredLane = 2;
        }



        if (Input.GetKeyDown(KeyCode.LeftArrow) || SwipeMananger.swipeLeft)
        {
            desiredLane--;
            if (desiredLane == -1)
                desiredLane = 0;
        }


        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;

        if (desiredLane == 0)
        {
            targetPosition += Vector3.left * laneDistance;

        }else if (desiredLane == 2)
        {
            targetPosition += Vector3.right * laneDistance;
        }

        if (transform.position == targetPosition)
            return;
        Vector3 diff = targetPosition - transform.position;
        Vector3 moveDir = diff.normalized * 25 * Time.deltaTime;
        if (moveDir.sqrMagnitude < diff.sqrMagnitude)
            controller.Move(moveDir);
        else
            controller.Move(diff);
    }


    void jump()
    {
       
        direction.y = jumpForce;

    }
    private void FixedUpdate()
    {
        
        if (!PlayerManager.isGameStarted)
            return;
        controller.Move(direction * Time.fixedDeltaTime);
    }








    

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
   private IEnumerator Slide()
    {
        animator.SetBool("isSliding", true);

        yield return new WaitForSeconds(1.3f);

        animator.SetBool("isSliding", false);


    }
}
