//using System;
//using UnityEngine;

//namespace UnityStandardAssets.Characters.ThirdPerson
//{
//    [RequireComponent(typeof (ThirdPersonCharacter))]
//    public class ThirdPersonUserControl : MonoBehaviour
//    {
//        private ThirdPersonCharacter m_Character; 
//        private Transform m_Cam;                  
//        private Vector3 m_CamForward;             
//        private Vector3 m_Move;
//        private bool isJump;

//        [SerializeField] string InteractableTag = "Interactable";
//        [SerializeField] InputReader inputReader;
//        [SerializeField] private Animator animator;

//        public float distGround = 0.1f;

//        private void OnEnable()
//        {
//            inputReader.rightArmEvent += OnRightArm;
//            inputReader.leftArmEvent += OnLeftArm;
//            inputReader.jumpEvent += OnJump;
//        }

//        private void OnDisable()
//        {
//            inputReader.rightArmEvent -= OnRightArm;
//            inputReader.leftArmEvent -= OnLeftArm;
//            inputReader.jumpEvent -= OnJump;
//        }


//        private void Start()
//        {
//            // get the transform of the main camera
//            if (Camera.main != null)
//            {
//                m_Cam = Camera.main.transform;
//            }

//            // get the third person character ( this should never be null due to require component )
//            m_Character = GetComponent<ThirdPersonCharacter>();
//        }

//        private bool IsGrounded()
//        {
//            return Physics.Raycast(transform.position, -Vector3.up, distGround + 0.3f);
//        }

//        // Fixed update is called in sync with physics
//        private void FixedUpdate()
//        {
//            // read inputs
//            // float h = CrossPlatformInputManager.GetAxis("Horizontal");
//            float h = Input.GetAxis("Horizontal");
//            // float v = CrossPlatformInputManager.GetAxis("Vertical");
//            float v = Input.GetAxis("Vertical");
//            bool crouch = Input.GetKey(KeyCode.C);

//            // calculate move direction to pass to character
//            if (m_Cam != null)
//            {
//                // calculate camera relative direction to move:
//                m_CamForward = Vector3.Scale(m_Cam.forward, new Vector3(1, 0, 1)).normalized;
//                m_Move = v*m_CamForward + h*m_Cam.right;
//            }
//            else
//            {
//                // we use world-relative directions in the case of no main camera
//                m_Move = v*Vector3.forward + h*Vector3.right;
//            }
//#if !MOBILE_INPUT
//			// walk speed multiplier
//	        if (Input.GetKey(KeyCode.LeftShift)) m_Move *= 0.5f;
//#endif

//            // pass all parameters to the character control script
//            m_Character.Move(m_Move, crouch, isJump);
//            isJump = false;
//        }

//        private void OnRightArm()
//        {
//            Debug.Log("Character RightArm handler.");
//        }

//        private void OnLeftArm()
//        {
//            Debug.Log("Character left arm handler.");
//        }

//        private void OnJump()
//        {
//            if (IsGrounded())
//            {
//                isJump = true;
//            }
//        }
//    }
//}
