using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Animator))]
public class ThirdPersonCharacter : MonoBehaviour
{
	[SerializeField] float m_JumpPower = 12f;
	[Range(1f, 4f)] [SerializeField] float m_GravityMultiplier = 2f;
	[SerializeField] float m_RunCycleLegOffset = 0.2f; //specific to the character in sample assets, will need to be modified to work with others
	[SerializeField] float m_MoveSpeedMultiplier = 1f;
	[SerializeField] float m_AnimSpeedMultiplier = 1f;
	[SerializeField] float m_GroundCheckDistance = 0.1f;

	Rigidbody m_Rigidbody;
	Animator animator;
	bool isGrounded;
	float m_OrigGroundCheckDistance;
	const float k_Half = 0.5f;
	float m_TurnAmount;
	float m_ForwardAmount;
	Vector3 groundNormal;

	void Start()
	{
		animator = GetComponent<Animator>();
		m_Rigidbody = GetComponent<Rigidbody>();

		m_OrigGroundCheckDistance = m_GroundCheckDistance;
	}


	public void Move(Vector3 move, bool jump)
	{
		if (move.magnitude > 1f)
		{
			move.Normalize();
		}

		move = transform.InverseTransformDirection(move);
		CheckGroundStatus();
		move = Vector3.ProjectOnPlane(move, groundNormal);
		m_TurnAmount = Mathf.Atan2(move.x, move.z);
		m_ForwardAmount = move.z;

		// control and velocity handling is different when grounded and airborne:
		if (isGrounded)
		{
			HandleGroundedMovement(jump);
		}
		else
		{
			HandleAirborneMovement();
		}

		// send input and other state parameters to the animator
		UpdateAnimator(move);
	}


	private void UpdateAnimator(Vector3 move)
	{
		// update the animator parameters
		animator.SetFloat("Forward", m_ForwardAmount, 0.1f, Time.deltaTime);
		animator.SetFloat("Turn", m_TurnAmount, 0.1f, Time.deltaTime);
		animator.SetBool("OnGround", isGrounded);
		if (!isGrounded)
		{
			animator.SetFloat("Jump", m_Rigidbody.velocity.y);
		}

		// calculate which leg is behind, so as to leave that leg trailing in the jump animation
		// (This code is reliant on the specific run cycle offset in our animations,
		// and assumes one leg passes the other at the normalized clip times of 0.0 and 0.5)
		float runCycle =
			Mathf.Repeat(
				animator.GetCurrentAnimatorStateInfo(0).normalizedTime + m_RunCycleLegOffset, 1);
		float jumpLeg = (runCycle < k_Half ? 1 : -1) * m_ForwardAmount;
		if (isGrounded)
		{
			animator.SetFloat("JumpLeg", jumpLeg);
		}

		// the anim speed multiplier allows the overall speed of walking/running to be tweaked in the inspector,
		// which affects the movement speed because of the root motion.
		if (isGrounded && move.magnitude > 0)
		{
			animator.speed = m_AnimSpeedMultiplier;
		}
		else
		{
			// don't use that while airborne
			animator.speed = 1;
		}
	}


	private void HandleAirborneMovement()
	{
		// apply extra gravity from multiplier:
		Vector3 extraGravityForce = (Physics.gravity * m_GravityMultiplier) - Physics.gravity;
		m_Rigidbody.AddForce(extraGravityForce);

		m_GroundCheckDistance = m_Rigidbody.velocity.y < 0 ? m_OrigGroundCheckDistance : 0.01f;
	}


	private void HandleGroundedMovement(bool jump)
	{
		// check whether conditions are right to allow a jump:
		if (jump && animator.GetCurrentAnimatorStateInfo(0).IsName("Grounded"))
		{
			// jump!
			m_Rigidbody.velocity = new Vector3(m_Rigidbody.velocity.x, m_JumpPower, m_Rigidbody.velocity.z);
			isGrounded = false;
			animator.applyRootMotion = false;
			m_GroundCheckDistance = 0.1f;
		}
	}

	public void OnAnimatorMove()
	{
		// we implement this function to override the default root motion.
		// this allows us to modify the positional speed before it's applied.
		if (isGrounded && Time.deltaTime > 0)
		{
			Vector3 v = (animator.deltaPosition * m_MoveSpeedMultiplier) / Time.deltaTime;

			// we preserve the existing y part of the current velocity.
			v.y = m_Rigidbody.velocity.y;
			m_Rigidbody.velocity = v;
		}
	}


	private void CheckGroundStatus()
	{
		RaycastHit hitInfo;

		if (Physics.Raycast(transform.position + (Vector3.up * 0.1f), Vector3.down, out hitInfo, m_GroundCheckDistance))
		{
			groundNormal = hitInfo.normal;
			isGrounded = true;
			animator.applyRootMotion = true;
		}
		else
		{
			isGrounded = false;
			groundNormal = Vector3.up;
			animator.applyRootMotion = false;
		}
	}
}
