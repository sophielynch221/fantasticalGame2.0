using UnityEngine;
#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
using UnityEngine.InputSystem;
#endif

namespace StarterAssets
{
	public class StarterAssetsInputs : MonoBehaviour
	{
		[Header("Character Input Values")]
		public Vector2 move;
		public Vector2 look;
		public bool jump;
		public bool sprint;

		[Header("Movement Settings")]
		public bool analogMovement;

		[Header("Animator")]
		//public Animator girlAnimator;
		public GameObject player;

#if !UNITY_IOS || !UNITY_ANDROID
		[Header("Mouse Cursor Settings")]
		public bool cursorLocked = true;
		public bool cursorInputForLook = true;
#endif

        private void Start()
        {
			SetCursorState(cursorLocked);
			//girlAnimator = gameObject.GetComponent<Animator>();
			
		}

#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
        public void OnMove(InputValue value)
		{
			MoveInput(value.Get<Vector2>());
			player.GetComponent<Animator>().SetBool("walking", true);
			Invoke("OnMoveExit", 1f);
		}

		public void OnLook(InputValue value)
		{
			if(cursorInputForLook)
			{
				LookInput(value.Get<Vector2>());
			}
		}

		public void OnJump(InputValue value)
		{
			JumpInput(value.isPressed);
			player.GetComponent<Animator>().SetBool("jump", true);
			//player.GetComponent<Animator>().SetTrigger("jumpOne");
			Invoke("OnJumpExit", 1f);
		}


		public void OnSprint(InputValue value)
		{
			SprintInput(value.isPressed);
			player.GetComponent<Animator>().SetBool("running", true);
			Invoke("OnSprintExit", 4f);
		}


		public void OnJumpExit()
		{
			player.GetComponent<Animator>().SetBool("jump", false);
		}

		public void OnMoveExit()
		{
			player.GetComponent<Animator>().SetBool("walking", false);
		}

		public void OnSprintExit()
		{
			player.GetComponent<Animator>().SetBool("running", false);
		}
#else
	// old input sys if we do decide to have it (most likely wont)...
#endif


		public void MoveInput(Vector2 newMoveDirection)
		{
			move = newMoveDirection;
		} 

		public void LookInput(Vector2 newLookDirection)
		{
			look = newLookDirection;
		}

		public void JumpInput(bool newJumpState)
		{
			jump = newJumpState;
		}

		public void SprintInput(bool newSprintState)
		{
			sprint = newSprintState;
		}

#if !UNITY_IOS || !UNITY_ANDROID

		private void OnApplicationFocus(bool hasFocus)
		{
			SetCursorState(cursorLocked);
		}

		private void SetCursorState(bool newState)
		{
			Cursor.lockState = newState ? CursorLockMode.Locked : CursorLockMode.None;
		}

       

#endif

    }
	
}