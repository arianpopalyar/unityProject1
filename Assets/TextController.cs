using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
 
 	public Text text;
 	
	private enum States {cell, mirror, cell_mirror, lock_0, sheets_0, lock_1, sheets_1, corridor_1
	, corridor_0, courtyard, floor, corridor_2, corridor_3, closet_door, in_closet, stairs_0, stairs_1, stairs_2};  
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
	print (myState);
		if 		(myState == States.cell)	{cell();}
		else if (myState == States.sheets_0) {sheets_0();}
		else if (myState == States.sheets_1) {sheets_1();}
		else if (myState == States.lock_0)	{lock_0();}
		else if (myState == States.lock_1)	{lock_1();}
		else if (myState == States.mirror)	{mirror();}
		else if (myState == States.cell_mirror)	{cell_mirror();}
		else if (myState == States.corridor_0)	{corridor_0();}
		else if (myState == States.corridor_1)	{corridor_1();}
		else if (myState == States.corridor_2)	{corridor_2();}
		else if (myState == States.corridor_3)	{corridor_3();}
		else if (myState == States.stairs_0)	{stairs_0();}
		else if (myState == States.stairs_1)	{stairs_1();}
		else if (myState == States.stairs_2)	{stairs_2();}
		else if (myState == States.courtyard)	{courtyard();}
		else if (myState == States.floor)		{floor();}
		else if (myState == States.closet_door)	{closet_door();}
		else if (myState == States.in_closet)	{in_closet();}	
	}
	

	void in_closet(){
		text.text="In the closet there is uniform of your size, its great chance to escap\n"+
			"Press D to dress as cleaner Or Press R to return to corridor";
		if(Input.GetKeyDown(KeyCode.D)){myState = States.corridor_3;}
		else if (Input.GetKeyDown(KeyCode.R)){myState = States.corridor_2;}
	}
	
	void closet_door(){
		text.text="you are looking at closet door but its locked \n may be find some thing to open it\n"+
			      "Press C to return to corridor";
		if(Input.GetKeyDown(KeyCode.C)){myState = States.corridor_0;}
	}
	
	void corridor_3(){
		text.text="You are standing back in the corridor, now convincingly dress as cleaner \n\n"+
			"Press S to clim the stairs, or Press U undress";
		if(Input.GetKeyDown(KeyCode.S)){myState = States.courtyard;}
		else if(Input.GetKeyDown(KeyCode.U)){myState = States.in_closet;}
	}
	
	void corridor_2(){
		text.text="Back in corridor, having declined to dress-up as a cleaner \n\n"+
		           "Press C to revisit the closet, or Press S to clime the stairs";
		if(Input.GetKeyDown(KeyCode.S))		{myState = States.stairs_2;}
		else if(Input.GetKeyDown(KeyCode.C)){myState = States.in_closet;}
	}
	
	void corridor_1(){
		text.text="Yare in a corridor, Hair clip is in your hand"+ 
			      "you can use hair clip to open the lock or clime the stairs\n\n"+
				  "Press P to checkout the closet lock , F to inspect the floor and S to climb the srairs";
		if(Input.GetKeyDown(KeyCode.S)){myState = States.stairs_1;}
		else if(Input.GetKeyDown(KeyCode.P)){myState = States.in_closet;}
	}
	void floor(){
		text.text = "Roaming around in the floor you find a hair clip \n\n"+
			"Press R to stand or Press H to take the hair clip";
		if(Input.GetKeyDown(KeyCode.R))		{myState = States.corridor_0;}
		else if(Input.GetKeyDown(KeyCode.H)){myState = States.corridor_1;}
	}
	void courtyard(){
		text.text = "you walk through courtyard dressed as cleaner\n\n "+
			"The guard tips his hat at you as you walk past claiming your freedom\n"+
			"Press P to play again.";
		if(Input.GetKeyDown(KeyCode.P))		{myState = States.cell;}
	}
	
	void stairs_0(){
		text.text="Prison sheets are dirty try to get out of here plann your escap\n\n"+
			"Press R to Return to roaming your cell";
		if(Input.GetKeyDown(KeyCode.R))		{myState = States.corridor_0;}
	}
	void stairs_1(){
		text.text="Prison sheets are dirty try to get out of here plann your escap\n\n"+
			"Press R to Return to roaming your cell";
		if(Input.GetKeyDown(KeyCode.R))		{myState = States.corridor_1;}
	}
	
	void stairs_2(){
		text.text="You feek smug for leaving the closet door open and still armed with"+ 
		" the clip being bend badly, but its risky to clim the stais you might get cought"+
		"\n\n Press R return to the corridor";
		if(Input.GetKeyDown(KeyCode.R))		{myState = States.corridor_2;}
	}

	void cell(){
		text.text = "Roaming around on dirty floor you find a hair clip \n\n "+
			"Press R to Return to standing or H to take the Hairclip";
		if(Input.GetKeyDown(KeyCode.R))		{myState = States.corridor_0;}
		else if(Input.GetKeyDown(KeyCode.H))		{myState = States.corridor_1;}
	}
	void mirror(){
		text.text="Mirror \n\n"+
			"Press M to Return to roaming your cell\n"+
				"Press T to Take the mirror or Press T to take the mirror";
		if(Input.GetKeyDown(KeyCode.R))			{myState = States.cell;}
		else if (Input.GetKeyDown(KeyCode.T))	{myState = States.cell_mirror;}
	}
	void cell_mirror(){
		text.text="Big Cell  \n\n"+
				   "you made it out of 1 cell brek out of this cell two\n"+
			       "Press S to view the sheetss\n L to view Lock";
		if(Input.GetKeyDown(KeyCode.L))		{myState = States.lock_1;}
		else if (Input.GetKeyDown(KeyCode.S)){ myState = States.sheets_1;}
	}
	
	void sheets_0(){
		text.text="Prison sheets are dirty try to get out of here plann your escap\n\n"+
			"Press R to Return to roaming your cell";
		if(Input.GetKeyDown(KeyCode.R))		{myState = States.cell;}
	}
	
	void sheets_1(){
		text.text="Big Cell  \n\n"+
			"Sheet will not open the door look for some thing else\n"+
				"Press R to Roam in cell and think";
		if(Input.GetKeyDown(KeyCode.R)) { myState = States.cell_mirror; }
	}
	
	void lock_0(){
		text.text="there is single lock in your cell try to open it\n\n"+
			"Press R to Return to roaming your cell";
		if(Input.GetKeyDown(KeyCode.R))		{myState = States.cell;}
	}
	void lock_1(){
		text.text="Big Cell  \n\n"+
			"Sheet will not open the door look for some thing else\n"+
				"Press R to Roam in cell and think or Press O to open";
		if(Input.GetKeyDown(KeyCode.O))		{myState = States.corridor_0;}
		else if(Input.GetKeyDown(KeyCode.R))		{myState = States.cell_mirror;}
	}
	void corridor_0() {
		text.text = "You're out of your cell, but not out of trouble." +
			"You are in the corridor, there's a closet and some stairs leading to " + "the courtyard. There's also various detritus on the floor.\n\n" +
				"C to view the Closet, F to inspect the Floor, and S to climb the stairs";
		if (Input.GetKeyDown(KeyCode.S)) {myState = States.stairs_0;}
		else if (Input.GetKeyDown(KeyCode.F)) {myState = States.floor;}
		else if (Input.GetKeyDown(KeyCode.C))  {myState = States.closet_door;}
	}

}
