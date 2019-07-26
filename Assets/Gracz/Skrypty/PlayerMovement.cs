using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    
    //Zmieniono nazwy na angielski B.Liss
    public CharacterController characterControler;
	public float movementSpeed = 9.0f;
	public float jumpHeight = 7.0f;
	public float currentJumpHeight = 0f;
	public float runningSpeed = 7.0f;

	public float mouseSensitivity = 3.0f;	
	public float mouseUpDown = 0.0f;
	public float mouseUpDownRange = 90.0f;

    public Stats Stats; //Kondzio
	private float EnergyTimer = 0; //K

    //Bartek A.
    public TabReading TR;
    public bool canWalk = true;
    public bool canJump = true;
    public bool canLookAround = true;

	void Start () {
		characterControler = GetComponent<CharacterController>();
	}
	
	
	void Update() {
        EnergyTimer += Time.deltaTime; //K
        if(Stats.Sprint == true) //K
        {
            Sprint();
        }
        keyboard();
        if(canLookAround) //dodanie zmiennej bool(Bartek A.)
		    mouse();
        Read(); // Bartek A.
	}

	
	private void keyboard(){
		
		float movementFrontBack = Input.GetAxis("Vertical") * movementSpeed;
		
		float movementLeftRight = Input.GetAxis("Horizontal") * movementSpeed;
		
	
		
		if(characterControler.isGrounded && Input.GetButton("Jump") && canJump){ //dodanie zmiennej bool(Bartek A.)
			currentJumpHeight = jumpHeight;
		} else if (!characterControler.isGrounded ){
			
			currentJumpHeight += Physics.gravity.y * Time.deltaTime;
		}
		
		Debug.Log (Physics.gravity.y);

        

            if (Input.GetKey("left shift") && Stats.Energy >= 2)
            {
                movementSpeed = runningSpeed;

                Stats.Sprint = true; //K


            }
            else
            {
                Stats.Sprint = false; //K
                movementSpeed = 9.0f;
            }
        if (canWalk) // dodanie zmiennej bool (Bartek A.)
        {
            Vector3 movement = new Vector3(movementLeftRight, currentJumpHeight, movementFrontBack);

            movement = transform.rotation * movement;

            characterControler.Move(movement * Time.deltaTime);
        }
	}

	
	private void mouse(){
		
		float mouseLeftRight = Input.GetAxis("Mouse X") * mouseSensitivity;	
		transform.Rotate(0, mouseLeftRight, 0);
		
		
		mouseUpDown -= Input.GetAxis("Mouse Y") * mouseSensitivity;
		
		
		mouseUpDown = Mathf.Clamp(mouseUpDown, -mouseUpDownRange, mouseUpDownRange);
		
		Camera.main.transform.localRotation = Quaternion.Euler(mouseUpDown, 0, 0);
	}

    private void Sprint()
    {
        if (EnergyTimer > 0.1) //K
        {
            Stats.Energy -= 1;
            EnergyTimer = 0;
        }
    }
    //Bartek A.
    public void Read()
    {
        if (TR.canRead) {
            if (Input.GetKey(KeyCode.R) && TR.Tabs < 1 && !TR.TabCreated) //Tworznie obrazka i odejmowanie kontroli nad postacią
            {
                TR.TabToRead = Instantiate(TR.TabToReadPrefab, TR.canvas);
                TR.Tabs++;
                TR.TabCreated = true;
                canWalk = false;
                canJump = false;
                canLookAround = false;
            }
            else if (TR.TabCreated)
            {
                if (Input.GetKey(KeyCode.T)) //Niszczenie obrazka i oddawanie kontroli nad postacią
                {
                    Destroy(TR.TabToRead);
                    TR.Tabs--;
                    TR.TabCreated = false;
                    canWalk = true;
                    canJump = true;
                    canLookAround = true;
                }
            }
        }
    }
    //Bartek A.
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Tab")
            TR.canRead = true;
    }
    //Bartek A.
    private void OnTriggerExit(Collider other)
    {
        if(other.name == "Tab")
        {
            TR.canRead = false;
        }
    }
}
