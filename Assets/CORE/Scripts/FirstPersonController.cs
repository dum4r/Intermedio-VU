using UnityEngine;

public class FirstPersonController : MonoBehaviour {
	private CharacterController controller;
	public float speed = 5.0f;
	public float mouseSensitivity = 2.0f;

	public float alcance = 5f;

	private float verticalRotation = 0f;
	
	public float jumpForce = 5.0f;
	public float gravity = 9.8f;
	public bool  isGrounded = false;

	void Start() {
		controller = GetComponent<CharacterController>();
		Cursor.lockState = CursorLockMode.Locked;
	}

	void Update()	{
		// Movimiento del personaje
		float horizontalMovement = Input.GetAxis("Horizontal") * speed;
		float verticalMovement   = Input.GetAxis("Vertical")   * speed;

		Vector3 movement = transform.forward * verticalMovement + transform.right * horizontalMovement;

		// Aplicar gravedad
		if (isGrounded) {
			if (Input.GetButtonDown("Jump"))
				movement.y = jumpForce;
	 } else movement.y -= gravity * Time.deltaTime;

		controller.Move(movement * Time.deltaTime);

		// Rotación de la cámara (movimiento del ratón)
		float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
		float mouseY = -Input.GetAxis("Mouse Y") * mouseSensitivity;

		verticalRotation += mouseY;
		verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f);

		transform.Rotate(Vector3.up * mouseX);
		Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);

	if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.E)) {
			// Lanzar un rayo desde la posición de la cámara en la dirección de la mira.
			Ray rayo = new Ray(transform.position, transform.forward);
			RaycastHit hitInfo; // Almacenará información sobre el objeto golpeado por el rayo.

			// Verificar si el rayo golpea un objeto interactuable.
			if (Physics.Raycast(rayo, out hitInfo, alcance)) {
				// Verificar si el objeto golpeado tiene un componente interactuable.
				Interactuable interactuable = hitInfo.collider.GetComponent<Interactuable>();

				if (interactuable != null) // Realizar la interacción con el objeto interactuable. 
					interactuable.Interactuar();
			}
		}
	}
}
