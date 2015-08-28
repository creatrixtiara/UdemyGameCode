using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
	int guess;
	
	void Start () {
		StartGame();
	}
	
	void StartGame () {
		max = 1000;
		min = 1;
		guess = 500;
		
		print ("*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell meeeeeee");
		
		print ("You can pick a number between " + min + " and " + max);
		
		print ("Is the number higher or lower than " + guess + " ?");
		print ("Up = higher, down = lower, return/enter = equals");	
		
		max = max + 1;
	}

	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			// print ("Up! Going higher!");
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			// print ("Down! Getting lower!");
			max = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print ("w00t I AM WINRAR");
			print ("Play again? Y for Yes, N for No");
			if (Input.GetKeyDown(KeyCode.Y)) {
			StartGame();
			} else if (Input.GetKeyDown (KeyCode.N)) {
			print ("OK bye!");
			}
		}
	}
	
	void NextGuess () {
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess + " ?");
		print ("Up = higher, down = lower, return/enter = equals");	
	}
}
