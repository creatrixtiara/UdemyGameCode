using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {welcome, beginning, inBowl, climb, run, dog, dogClimb, dogRun, dogThrow, umbrellaDog, umbrella, umbrellaClimb, umbrellaRun, umbrellaThrow, umbrellaThrowDog, umbrellaThrowDogClimb, umbrellaThrowDogRun, umbrellaThrowDogThrow, umbrellaThrowClimb, umbrellaThrowClimbDog, umbrellaThrowClimbUmbrella, umbrellaThrowRun,  umbrellaDogClimb, umbrellaDogRun, umbrellaDogThrow};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.welcome;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.welcome) 							{state_welcome();}
		else if (myState == States.beginning) 					{state_beginning();}
		else if (myState == States.inBowl) 						{state_inBowl();} 
		else if (myState == States.climb) 						{state_climb();}
		else if (myState == States.run) 						{state_run();}
		else if (myState == States.dog) 						{state_dog();}
		else if (myState == States.dogClimb) 					{state_dogClimb();}
		else if (myState == States.dogRun) 						{state_dogRun();}
		else if (myState == States.dogThrow) 					{state_dogThrow();}
		else if (myState == States.umbrellaDog) 				{state_umbrellaDog();}
		else if (myState == States.umbrella) 					{state_umbrella();}
		else if (myState == States.umbrellaClimb) 				{state_umbrellaClimb();}
		else if (myState == States.umbrellaRun) 				{state_umbrellaRun();}
		else if (myState == States.umbrellaThrow) 				{state_umbrellaThrow();}
		else if (myState == States.umbrellaThrowDog) 			{state_umbrellaThrowDog();}
		else if (myState == States.umbrellaThrowDogClimb)		{state_umbrellaThrowDogClimb();}
		else if (myState == States.umbrellaThrowDogRun) 		{state_umbrellaThrowDogRun();}
		else if (myState == States.umbrellaThrowDogThrow) 		{state_umbrellaThrowDogThrow();}
		else if (myState == States.umbrellaThrowClimb) 			{state_umbrellaThrowClimb();}
		else if (myState == States.umbrellaThrowClimbDog) 		{state_umbrellaThrowClimbDog();}
		else if (myState == States.umbrellaThrowClimbUmbrella) 	{state_umbrellaThrowClimbUmbrella();}
		else if (myState == States.umbrellaThrowRun) 			{state_umbrellaThrowRun();}
		else if (myState == States.umbrellaDogClimb) 			{state_umbrellaDogClimb();}
		else if (myState == States.umbrellaDogRun) 				{state_umbrellaDogRun();}
		else if (myState == States.umbrellaDogThrow) 			{state_umbrellaDogThrow();}
	}
	
	void state_welcome () {
		text.text = "A game inspired by Ryan North and Chompsky's adventures in August 2015\n" +
					"Art by Michael Firman\n" +
					"No relation to Man in a Hole by Ronka\n" +
					"Made by Creatrix Tiara as part of Udemy's Learn to Code by Making Games\n\n" +
					"Press [Space] to Begin";
		if (Input.GetKeyDown (KeyCode.Space)) 					{myState = States.beginning;}
	}
	
	void state_beginning () {
		text.text = "Your name is RYAN NORTH. You were taking your DOG, CHOMPSKY out for a walk one day when you found a really cool SKATE BOWL.\n" + 
					"You decided to CLIMB INTO the skate bowl to take photos.\n" +
					"But when you tried to CLIMB OUT, you found that the walls were SLIPPERY - and now you’re STUCK.\n" +
					"How do you and Chompsky GET OUT?\n\n" +
					"Press [C] to [C]ontinue";
		if (Input.GetKeyDown(KeyCode.C)) 						{myState = States.inBowl;}
	}
	
	void state_inBowl () {
		text.text = "You have YOURSELF, your DOG (which is on a leash), and your UMBRELLA.\n\n" +
					"Do you [C]limb the wall, [R]un up the wall, grab your [D]og, or grab your [U]mbrella?";
		if (Input.GetKeyDown(KeyCode.C)) 						{myState = States.climb;}
		else if (Input.GetKeyDown(KeyCode.R))					{myState = States.run;}
		else if (Input.GetKeyDown(KeyCode.D))					{myState = States.dog;}
		else if (Input.GetKeyDown(KeyCode.U))					{myState = States.umbrella;}
	}
	
	void state_climb () {
		text.text = "You somehow made it out, but you don’t have Chompsky or your umbrella with you, and you can’t reach them here...\n\n" +
					"You need to get back [I]n and try again";
		if (Input.GetKeyDown(KeyCode.I)) 						{myState = States.inBowl;}
	}
	
	void state_run () {
		text.text = "You thought you'd get enough momentum to fly out - but the walls are too slippery and curvy!\n\n" +
					"Chompsky watches as you fall back [I]n - now try again.";
		if (Input.GetKeyDown(KeyCode.I)) 						{myState = States.inBowl;}
	}
	
	void state_dog () {
		text.text = "You have Chompsky in your arms. He is curled up against you. What now?\n\n" +
					"[C]limb with Chompsky, [R]un with Chompsky, [T]hrow Chompsky over wall, grab [U]mbrella, or [D]rop Chompsky";
		if (Input.GetKeyDown(KeyCode.C)) 						{myState = States.dogClimb;}
		else if (Input.GetKeyDown(KeyCode.R))					{myState = States.dogRun;}
		else if (Input.GetKeyDown(KeyCode.T))					{myState = States.dogThrow;}
		else if (Input.GetKeyDown(KeyCode.U))					{myState = States.umbrellaDog;}
		else if (Input.GetKeyDown(KeyCode.D))					{myState = States.inBowl;}
	}
	
	void state_dogClimb () {
		text.text = "You can’t carry Chompsky and climb out at the same time! You need both your arms free.\n\n" +
					"[D]rop Chompsky (gently) and start again.";
		if (Input.GetKeyDown(KeyCode.D)) 						{myState = States.inBowl;}
	}
	
	void state_dogRun () {
		text.text = "You hold on to Chompsky's leash and try to run, but he wouldn't really budge.\n\n" +
					"[D]rop Chompsky's leash and start again.";
		if (Input.GetKeyDown(KeyCode.D)) 						{myState = States.inBowl;}
	}
	
	void state_dogThrow () {
		text.text = "As funny as the mental image is of you whirling Chompsky around like a lasso, his sad eyes make you reconsider the idea. Damn puppydog eyes getting in the way of your Wonder Woman dreams.\n\n" +
					"[D]rop the fantasy and start again.";
		if (Input.GetKeyDown(KeyCode.D)) 						{myState = States.inBowl;}
	}
	
	void state_umbrella () {
		text.text = "You have your umbrella - long and sturdy, with a good hook at the end. What now?\n\n" +
					"[C]limb with umbrella, [R]un with umbrella, [T]hrow umbrella over wall, grab [D]og, or drop [U]mbrella?";
		if (Input.GetKeyDown(KeyCode.C)) 						{myState = States.umbrellaClimb;}
		else if (Input.GetKeyDown(KeyCode.R))					{myState = States.umbrellaRun;}
		else if (Input.GetKeyDown(KeyCode.T))					{myState = States.umbrellaThrow;}
		else if (Input.GetKeyDown(KeyCode.U))					{myState = States.umbrellaDog;}
		else if (Input.GetKeyDown(KeyCode.D))					{myState = States.inBowl;}
	}
	
	void state_umbrellaClimb () {
		text.text = "You try to use your umbrella to hoist yourself out. You hook it over the edge, but it’s not quite enough - you need both hands free!\n\n" +
					"[D]rop the umbrella and start again.";
		if (Input.GetKeyDown(KeyCode.D)) 						{myState = States.inBowl;}
	}
	
	void state_umbrellaRun () {
		text.text = "You decide to do a little bit of jousting. might as well have some fun. Though this isn’t really going to get you out any quicker.\n\n" +
					"[D]rop the shenanigans, Mx Wannabe Mary Poppins.";
		if (Input.GetKeyDown(KeyCode.D)) 						{myState = States.inBowl;}
	}
	
	void state_umbrellaThrow () {
		text.text = "You toss the umbrella and it lands on the grass! Now what?\n\n" +
					"Grab the [D]og, [C]limb up, or [R]un up?";
		if (Input.GetKeyDown(KeyCode.D)) 						{myState = States.umbrellaThrowDog;}
		else if (Input.GetKeyDown (KeyCode.C))					{myState = States.umbrellaThrowClimb;}
		else if (Input.GetKeyDown (KeyCode.R))					{myState = States.umbrellaThrowRun;}
	}
	
	void state_umbrellaThrowDog () {
		text.text = "Your umbrella's on land and Chompsky is in your hands. Now what?\n\n" +
					"[C]limb, [R]un, or [T]hrow Chompsky over and onto land?";
		if (Input.GetKeyDown(KeyCode.C)) 						{myState = States.umbrellaThrowDogClimb;}
		else if (Input.GetKeyDown (KeyCode.R))					{myState = States.umbrellaThrowDogRun;}
		else if (Input.GetKeyDown (KeyCode.T))					{myState = States.umbrellaThrowDogThrow;}
	}
	
	void state_umbrellaThrowDogClimb () {
		text.text = "You can't climb the wall while holding Chompsky at the same time!\n\n" +
					"[D]rop the dog and try again.";
		if (Input.GetKeyDown(KeyCode.D)) 						{myState = States.umbrellaThrowDog;}
	}
	
	void state_umbrellaThrowDogRun () {
		text.text = "You nearly slip and fall, but catch yourself. Chompsky had a bit of a flight, and is now a little freaked out. Poor pup.\n\n" +
					"Set your [D]og down (very very gently) and try again.";
		if (Input.GetKeyDown(KeyCode.D)) 						{myState = States.umbrellaThrowDog;}
	}
	
	void state_umbrellaThrowDogThrow () {
		text.text = "Chompsky may be a fluffball, but he is not a basketball!.\n\n" +
					"[D]rop (don't dribble) the dude and try again.";
		if (Input.GetKeyDown(KeyCode.D)) 						{myState = States.umbrellaThrowDog;}
	}
	
	void state_umbrellaThrowClimb () {
		text.text = "You climb the wall and plop yourself right next to the umbrella! Chompsky watches you from below, his leash dangling.\n\n" +
					"Do you try to reach for your [D]og or the [U]mbrella?";
		if (Input.GetKeyDown(KeyCode.D)) 						{myState = States.umbrellaThrowClimbDog;}
		else if (Input.GetKeyDown(KeyCode.U)) 					{myState = States.umbrellaThrowClimbUmbrella;}
	}
	
	void state_umbrellaThrowClimbDog () {
		text.text = "Chompsky is just a liiiiiiitle too far away, but the leash gives you an idea.\n\n" +
					"Try the [U]mbrella.";
		if (Input.GetKeyDown(KeyCode.U)) 						{myState = States.umbrellaThrowClimbUmbrella;}
	}
	
	void state_umbrellaThrowClimbUmbrella () {
		text.text = "You stretch out as far as possible and hook the umbrella onto Chompsky's leash. Tugging it, you see Chompsky running up towards you, and eventually you manage to hoist him up on land.\n\n" +
					"YOU WIN! Press [Space] to Play Again";
		if (Input.GetKeyDown(KeyCode.Space)) 					{myState = States.beginning;}
	}
	
	void state_umbrellaThrowRun () {
		text.text = "You weren't Mary Poppins with the umbrella and you definitely aren't Peter Pan now. You're not going to fly outta here.\n\n" +
					"Settle [D]own and try again.";
		if (Input.GetKeyDown(KeyCode.D)) 						{myState = States.umbrellaThrow;}
	}
	
	void state_umbrellaDog () {
		text.text = "OK, you're now holding both Chompsky and your umbrella. Now what?\n\n" +
					"[C]limb the wall, [R]un up the wall, [T]hrow them both overland, drop the [D]og, or drop the [U]mbrella?";
		if (Input.GetKeyDown(KeyCode.C)) 						{myState = States.umbrellaDogClimb;}
		else if (Input.GetKeyDown(KeyCode.R)) 					{myState = States.umbrellaDogRun;}
		else if (Input.GetKeyDown(KeyCode.T)) 					{myState = States.umbrellaDogThrow;}
		else if (Input.GetKeyDown(KeyCode.D)) 					{myState = States.umbrella;}
		else if (Input.GetKeyDown(KeyCode.U)) 					{myState = States.dog;}
	}
	
	void state_umbrellaDogClimb () {
		text.text = "You try hoisting yourself up with the umbrella, but can barely keep your balance while holding on to Chompsky.\n\n" +
					"[T]ry again.";
		if (Input.GetKeyDown(KeyCode.T)) 						{myState = States.umbrellaDog;}
	}
	
	void state_umbrellaDogRun () {
		text.text = "Something tells you this would be a terrible idea. You swear you can read Chompsky's mind.\n\n" +
					"[T]ry again.";
		if (Input.GetKeyDown(KeyCode.T)) 						{myState = States.umbrellaDog;}
	}
	
	void state_umbrellaDogThrow () {
		text.text = "You consider wrapping the leash around the umbrella to give it some heft, and have visions of an umbrella plane with your dog as pilot.\n" +
					"Then you picture the leash wrapped around your dog as the umbrella-plane crashes. Maybe not. \n\n" +
					"[T]ry again.";
		if (Input.GetKeyDown(KeyCode.T)) 						{myState = States.umbrellaDog;}
	}
	
	}