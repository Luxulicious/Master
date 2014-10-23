using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {


	private Rect char1 = new Rect ((float)Screen.width / 30f * 1.5f, (float)Screen.height / 30f * 2f, (float)Screen.width / 30f * 2.75f, (float)Screen.height / 30f * 11.75f);
	private Rect char2 = new Rect ((float)Screen.width / 30f * 4.75f, (float)Screen.height / 30f * 2f, (float)Screen.width / 30f * 2.75f, (float)Screen.height / 30f * 11.75f);
	private Rect char3 = new Rect ((float)Screen.width / 30f * 8f, (float)Screen.height / 30f * 2f, (float)Screen.width / 30f * 2.75f, (float)Screen.height / 30f * 11.75f);
	private Rect char4 = new Rect ((float)Screen.width / 30f * 11.25f, (float)Screen.height / 30f * 2f, (float)Screen.width / 30f * 2.75f, (float)Screen.height / 30f * 11.75f);
	private Rect char5 = new Rect ((float)Screen.width / 30f*14.5f,(float)Screen.height/30f*2f,(float)Screen.width/30f*2.75f,(float)Screen.height/30f*11.75f);
	private Rect char6 = new Rect((float)Screen.width / 30f*17.75f,(float)Screen.height/30f*2f,(float)Screen.width/30f*2.75f,(float)Screen.height/30f*11.75f);

	private Rect char1B = new Rect ((float)Screen.width / 30f * 1.5f, (float)Screen.height / 30f * 2f, (float)Screen.width / 30f * 2.75f, (float)Screen.height / 30f * 11.75f);
	private Rect char2B = new Rect ((float)Screen.width / 30f * 4.75f, (float)Screen.height / 30f * 2f, (float)Screen.width / 30f * 2.75f, (float)Screen.height / 30f * 11.75f);
	private Rect char3B = new Rect ((float)Screen.width / 30f * 8f, (float)Screen.height / 30f * 2f, (float)Screen.width / 30f * 2.75f, (float)Screen.height / 30f * 11.75f);
	private Rect char4B = new Rect ((float)Screen.width / 30f * 11.25f, (float)Screen.height / 30f * 2f, (float)Screen.width / 30f * 2.75f, (float)Screen.height / 30f * 11.75f);
	private Rect char5B = new Rect ((float)Screen.width / 30f*14.5f,(float)Screen.height/30f*2f,(float)Screen.width/30f*2.75f,(float)Screen.height/30f*11.75f);
	private Rect char6B = new Rect((float)Screen.width / 30f*17.75f,(float)Screen.height/30f*2f,(float)Screen.width/30f*2.75f,(float)Screen.height/30f*11.75f);

	private Rect start = new Rect ((float)Screen.width / 30f * 21.5f, (float)Screen.height / 30f * 8.75f, (float)Screen.width / 30f * 2.25f, (float)Screen.height / 30f * 2f);
	private Rect quit = new Rect ((float)Screen.width / 30f * 21.5f, (float)Screen.height / 30f * 11.25f, (float)Screen.width / 30f * 2.25f, (float)Screen.height / 30f * 2f);
	private Rect mission = new Rect ((float)Screen.width / 30f * 24.25f, (float)Screen.height / 30f * 8f, (float)Screen.width / 30f * 4f, (float)Screen.height / 30f * 6f);
	private Rect characters = new Rect ((float)Screen.width / 30f * 21.5f, (float)Screen.height / 30f * 2f, (float)Screen.width / 30f * 6.75f, (float)Screen.height / 30f * 5f);
	private Rect mission1 = new Rect ((float)Screen.width / 30f * 1.5f, (float)Screen.height / 30f * 16.25f, (float)Screen.width / 30f * 6f, (float)Screen.height / 30f * 11.75f);
	private Rect mission2 = new Rect ((float)Screen.width / 30f * 8f, (float)Screen.height / 30f * 16.25f, (float)Screen.width / 30f * 6f, (float)Screen.height / 30f * 11.75f);
	private Rect mission3 = new Rect ((float)Screen.width / 30f * 14.5f, (float)Screen.height / 30f * 16.25f, (float)Screen.width / 30f * 6f, (float)Screen.height / 30f * 11.75f);
	private Rect missionSelect = new Rect ((float)Screen.width / 30f * 22f, (float)Screen.height / 30f * 16.25f, (float)Screen.width / 30f * 6f, (float)Screen.height / 30f * 11.75f);
	private Rect mission1pickt = new Rect ((float)Screen.width / 30f * 24.25f, (float)Screen.height / 30f * 8f, (float)Screen.width / 30f * 4f, (float)Screen.height / 30f * 6f);
	private Rect mission2pickt = new Rect ((float)Screen.width / 30f * 24.25f, (float)Screen.height / 30f * 8f, (float)Screen.width / 30f * 4f, (float)Screen.height / 30f * 6f);
	private Rect mission3pickt = new Rect ((float)Screen.width / 30f * 24.25f, (float)Screen.height / 30f * 8f, (float)Screen.width / 30f * 4f, (float)Screen.height / 30f * 6f);




	private bool movetomiddle;
	private bool selectchar1 = false;
	private bool selectchar2= false;
	private bool selectchar3= false;
	private bool selectchar4= false;
	private bool selectchar5= false;
	private bool selectchar6= false;

	private bool alltaken = false;
	private float a;
	private bool spot11 = false;
	private bool spot12 = false;
	private bool spot13 = false;
	private bool spot14 = false;
	private bool spot15 = false;
	private bool spot16 = false;

	private bool spot21 = false;
	private bool spot22 = false;
	private bool spot23 = false;
	private bool spot24 = false;
	private bool spot25 = false;
	private bool spot26 = false;

	private bool spot31 = false;
	private bool spot32 = false;
	private bool spot33 = false;
	private bool spot34 = false;
	private bool spot35 = false;
	private bool spot36 = false;

	private bool missionSelected = false;
	private bool mission1Selected = false;
	private bool mission2Selected = false;
	private bool mission3Selected = false;
	private bool infoShowing = false;

	private Vector2 mousePosition;

	private bool spotoneTaken = false;
	private bool spottwoTaken = false;
	private bool spotthreeTaken = false;
	private float chosenCharacter1x = (float)Screen.width / 30f * 21.5f;
	private float chosenCharacter2x = (float)Screen.width / 30f * 23.75f;
	private float chosenCharacter3x = (float)Screen.width / 30f * 26f;


	public GUISkin mainSkin ;
	public GUIStyle char1Skin;
	public GUIStyle char2Skin;
	public GUIStyle char3Skin;
	public GUIStyle char4Skin;
	public GUIStyle char5Skin;
	public GUIStyle char6Skin;

	public GUIStyle mission1skin;
	public GUIStyle mission2skin;
	public GUIStyle mission3skin;
	public GUIStyle mission4skin;
	public GUIStyle mission5skin;
	public GUIStyle mission6skin;



	void Start () {


		char1Skin = mainSkin.GetStyle ("char1Skin");
		char1Skin.fixedHeight = (int)char1.height;
		char1Skin.fixedWidth = (int)char1.width;

		char2Skin = mainSkin.GetStyle ("char2Skin");
		char2Skin.fixedHeight = (int)char2.height;
		char2Skin.fixedWidth = (int)char2.width;

		char3Skin = mainSkin.GetStyle ("char3Skin");
		char3Skin.fixedHeight = (int)char3.height;
		char3Skin.fixedWidth = (int)char3.width;

		char4Skin = mainSkin.GetStyle ("char4Skin");
		char4Skin.fixedHeight = (int)char4.height;
		char4Skin.fixedWidth = (int)char4.width;

		char5Skin = mainSkin.GetStyle ("char5Skin");
		char5Skin.fixedHeight = (int)char5.height;
		char5Skin.fixedWidth = (int)char5.width;

		char6Skin = mainSkin.GetStyle ("char6Skin");
		char6Skin.fixedHeight = (int)char6.height;
		char6Skin.fixedWidth = (int)char6.width;



		mission1skin = mainSkin.GetStyle ("mission1skin");
		mission1skin.fixedHeight = (int)mission1.height;
		mission1skin.fixedWidth = (int)mission1.width;

		mission2skin = mainSkin.GetStyle ("mission2skin");
		mission2skin.fixedHeight = (int)mission2.height;
		mission2skin.fixedWidth = (int)mission2.width;

		mission3skin = mainSkin.GetStyle ("mission3skin");
		mission3skin.fixedHeight = (int)mission3.height;
		mission3skin.fixedWidth = (int)mission3.width;

		mission4skin = mainSkin.GetStyle ("mission4skin");
		mission4skin.fixedHeight = (int)mission1pickt.height;
		mission4skin.fixedWidth = (int)mission1pickt.width;

		mission5skin = mainSkin.GetStyle ("mission5skin");
		mission5skin.fixedHeight = (int)mission1pickt.height;
		mission5skin.fixedWidth = (int)mission1pickt.width;

		mission6skin = mainSkin.GetStyle ("mission6skin");
		mission6skin.fixedHeight = (int)mission1pickt.height;
		mission6skin.fixedWidth = (int)mission1pickt.width;

		}

		void OnGUI(){

		GUI.skin = mainSkin;
		if (!missionSelected) {
					GUI.Box (new Rect (mission), "No Mission Selected.");
				}
		GUI.Box(new Rect((float)Screen.width/30f,(float)Screen.height/30f,(float)Screen.width/30*20f,(float)Screen.height/30*13.75f), "");
		GUI.Box(new Rect((float)Screen.width/30f,(float)Screen.height/30*15.25f,(float)Screen.width/30*20f,(float)Screen.height/30*13.75f), "");
		GUI.Box(new Rect((float)Screen.width/30f * 21.25f,(float)Screen.height/30f,(float)Screen.width/30*7.5f,(float)Screen.height/30*13.75f), "");
		GUI.Box(new Rect((float)Screen.width/30f * 21.25f,(float)Screen.height/30f*15.25f,(float)Screen.width/30f*7.5f,(float)Screen.height/30f*13.75f), "");

		if (GUI.Button (new Rect (start), "Start")) { if(spotoneTaken && spottwoTaken && spotthreeTaken &&  (mission1Selected || mission2Selected || mission3Selected) && missionSelected) {Application.LoadLevel(1);  } else { }			}
		
		
		if (GUI.Button (new Rect (quit), "Quit")) { Application.Quit();	}


		// MISIONS START 



		if (GUI.Button (new Rect (mission1), "", mission1skin))
			{	mission1Selected = true; mission2Selected = false; mission3Selected = false;	}

		if (GUI.Button (new Rect (mission2), "",mission2skin))
			{	mission2Selected = true; mission1Selected = false; mission3Selected = false;		}

		if (GUI.Button (new Rect (mission3), "",mission3skin))
			{	mission3Selected = true; mission2Selected = false; mission1Selected = false;		}


		if (mission1Selected) {
						GUI.Button (new Rect (mission1pickt), "",mission4skin);
			missionSelected = true;
				}
		if (mission2Selected) {
			GUI.Button (new Rect (mission2pickt), "", mission5skin);
			missionSelected = false;
			//missionSelected = true;
		}
		if (mission3Selected) {
			GUI.Button (new Rect (mission3pickt), "" ,mission6skin);
			//missionSelected = true;
			missionSelected = false;
		}


		if (!infoShowing) {
						if (GUI.Button (new Rect (missionSelect), "MouseOver a Mission For More Information"))
								;
				}
						
	
		if(mission1.Contains(mousePosition))
		{GUI.TextArea(new Rect(missionSelect),"Find and explore the Comet that recently fell on Mars, Be carefull though there might be some disruption of th earth one your way there caused by the impact");infoShowing = true;}
		else if(mission2.Contains(mousePosition))
		{GUI.TextArea(new Rect(missionSelect),"Complete Mission 1 to unlock this mission"); infoShowing = true;}
		else if(mission3.Contains(mousePosition))
		{GUI.TextArea(new Rect(missionSelect),"Complete Mission 1 & 2 to unlock this mission"); infoShowing = true;}
		else { infoShowing = false;} 	
		//Misions END


		//  CHARACTERS  start !


		if (GUI.Button (new Rect (char1),"",char1Skin)) {
			if(selectchar1)
			{selectchar1 = false;
				if(spot11){ spotoneTaken = false ;spot11 = false;}
				if(spot21){spottwoTaken =false; spot21 = false;}
				if(spot31){spotthreeTaken = false;spot31 = false;}
			
				alltaken = false;
			
			} else {


				selectchar1 = true;  

				if(!spotoneTaken)
				{spotoneTaken = true; spot11 = true; spot12 = false; spot13 = false; spot14 = false; spot15 = false; spot16 = false;}
				else if (!spottwoTaken)
				{ spottwoTaken = true; spot21 = true; spot22 = false; spot23 = false; spot24 = false; spot25 = false; spot26 = false;} 
				else if ( !spotthreeTaken)
				{ spotthreeTaken = true; spot31 = true; spot32 = false; spot33 = false; spot34 = false; spot35 = false; spot36 = false;	}
				else { alltaken= true;}
			}  

			}




		if(GUI.Button (new Rect (char2), "",char2Skin)){
			if(selectchar2)
			{selectchar2 = false;
				if(spot12){ spotoneTaken = false ;spot12 = false;}
				if(spot22){spottwoTaken =false; spot22 = false;}
				if(spot32){spotthreeTaken = false;spot32 = false;}
				alltaken = false;
			}else {selectchar2 = true;
			
				if(!spotoneTaken)
				{spotoneTaken = true; spot11 = false; spot12 = true; spot13 = false; spot14 = false; spot15 = false; spot16 = false;}
				else if (!spottwoTaken)
				{ spottwoTaken = true; spot21 = false; spot22 = true; spot23 = false; spot24 = false; spot25 = false; spot26 = false;} 
				else if ( !spotthreeTaken)
				{ spotthreeTaken = true; spot31 = false; spot32 = true; spot33 = false; spot34 = false; spot35 = false; spot36 = false;	}
				else { alltaken= true;}
			
			
			}
				
			
			}
		if(GUI.Button (new Rect (char3), "", char3Skin)){
			if(selectchar3)
			{selectchar3 = false;
				if(spot13){ spotoneTaken = false ;spot13 = false;}
				if(spot23){spottwoTaken =false; spot23 = false;}
				if(spot33){spotthreeTaken = false;spot33 = false;}
				alltaken = false;
			}else {selectchar3 = true;
			
			
				if(!spotoneTaken)
				{spotoneTaken = true; spot11 = false; spot12 = false; spot13 = true; spot14 = false; spot15 = false; spot16 = false;}
				else if (!spottwoTaken)
				{ spottwoTaken = true; spot21 = false; spot22 = false; spot23 = true; spot24 = false; spot25 = false; spot26 = false;} 
				else if ( !spotthreeTaken)
				{ spotthreeTaken = true; spot31 = false; spot32 = false; spot33 = true; spot34 = false; spot35 = false; spot36 = false;	}
				else { alltaken= true;}
			
			}
				

			}

		if(GUI.Button (new Rect (char4), "" , char4Skin)){
			if(selectchar4)
			{selectchar4 = false;
				if(spot14){ spotoneTaken = false ;spot14 = false;}
				if(spot24){spottwoTaken =false; spot24 = false;}
				if(spot34){spotthreeTaken = false;spot34 = false;}
				alltaken = false;
			}else {selectchar4 = true;
			
				if(!spotoneTaken)
				{spotoneTaken = true; spot11 = false; spot12 = false; spot13 = false; spot14 = true; spot15 = false; spot16 = false;}
				else if (!spottwoTaken)
				{ spottwoTaken = true; spot21 = false; spot22 = false; spot23 = false; spot24 = true; spot25 = false; spot26 = false;} 
				else if ( !spotthreeTaken)
				{ spotthreeTaken = true; spot31 = false; spot32 = false; spot33 = false; spot34 = true; spot35 = false; spot36 = false;	}
				else { alltaken= true;}
			
			}
				
			
			}

		if(GUI.Button (new Rect (char5), "" , char5Skin)){
			if(selectchar5)
			{selectchar5 = false;

				if(spot15){ spotoneTaken = false ;spot15 = false;}
				if(spot25){spottwoTaken =false; spot25 = false;}
				if(spot35){spotthreeTaken = false;spot35 = false;}
			
				alltaken = false;
			}else {selectchar5 = true;

				if(!spotoneTaken)
				{spotoneTaken = true; spot11 = false; spot12 = false; spot13 = false; spot14 = false; spot15 = true; spot16 = false;}
				else if (!spottwoTaken)
				{ spottwoTaken = true; spot21 = false; spot22 = false; spot23 = false; spot24 = false; spot25 = true; spot26 = false;} 
				else if ( !spotthreeTaken)
				{ spotthreeTaken = true; spot31 = false; spot32 = false; spot33 = false; spot34 = false; spot35 = true; spot36 = false;	}
				else { alltaken= true;}
			
			
			}
		}
			
		if(GUI.Button (new Rect (char6), "", char6Skin)){
			if(selectchar6)
			{selectchar6 = false;
			
				if(spot16){ spotoneTaken = false ;spot16 = false;}
				if(spot26){spottwoTaken =false; spot26 = false;}
				if(spot36){spotthreeTaken = false;spot36 = false;}
				alltaken = false;
			}else {selectchar6 = true;
			
				if(!spotoneTaken)
				{spotoneTaken = true; spot11 = false; spot12 = false; spot13 = false; spot14 = false; spot15 = false; spot16 = true;}
				else if (!spottwoTaken)
				{ spottwoTaken = true; spot21 = false; spot22 = false; spot23 = false; spot24 = false; spot25 = false; spot26 = true;} 
				else if ( !spotthreeTaken)
				{ spotthreeTaken = true; spot31 = false; spot32 = false; spot33 = false; spot34 = false; spot35 = false; spot36 = true;	}
				else { alltaken= true;}
			
			}

			
			}

		//  CHARACTERS  END !


		if (!selectchar1 && !selectchar2 && !selectchar3 && !selectchar4 && !selectchar5 && !selectchar6) {
				
			GUI.TextArea (new Rect(characters),"Please Select Your 3 Characters");

		} 

		}

	void Update(){

		mousePosition = Input.mousePosition;
		mousePosition.y = Screen.height - mousePosition.y;
		moveChars ((float)Screen.width / 30f * 1.5f,  selectchar1, char1);
		moveChars ((float)Screen.width / 30f * 4.75f,  selectchar2, char2);
		moveChars ((float)Screen.width / 30f * 8f,  selectchar3, char3);
		moveChars ((float)Screen.width / 30f * 11.25f, selectchar4, char4);
		moveChars ((float)Screen.width / 30f*14.5f,  selectchar5, char5);
		moveChars ((float)Screen.width / 30f*17.75f,  selectchar6, char6);

		char1Skin.fixedHeight = (int)char1.height;
		char1Skin.fixedWidth = (int)char1.width;

		char2Skin.fixedHeight = (int)char2.height;
		char2Skin.fixedWidth = (int)char2.width;

		char3Skin.fixedHeight = (int)char3.height;
		char3Skin.fixedWidth = (int)char3.width;

		char4Skin.fixedHeight = (int)char4.height;
		char4Skin.fixedWidth = (int)char4.width;

		char5Skin.fixedHeight = (int)char5.height;
		char5Skin.fixedWidth = (int)char5.width;

		char6Skin.fixedHeight = (int)char6.height;
		char6Skin.fixedWidth = (int)char6.width;


							}
		


	void moveChars( float b, bool character, Rect charRect)
	{


				

						if (character) {

						
								

							if(spot11 || spot21 || spot31)
							{	
					if(spot11){a = chosenCharacter1x; } else if (spot21){a = chosenCharacter2x;}else if(spot31){a = chosenCharacter3x;}
								if (char1.x < a) {
								

										if (selectchar1) {
										

												char1.x += 30;
												char1.width = ((float)Screen.width / 30f * 2f);
												char1.height = (float)Screen.height / 30f * 5f;
										}
								}
							}
				if(spot12 || spot22 || spot32)
				{	
					if(spot12){a = chosenCharacter1x; } else if (spot22){a = chosenCharacter2x;}else if(spot32){a = chosenCharacter3x;}
								if (char2.x < a) {
										if (selectchar2) {
												char2.x += 30;
												char2.width = ((float)Screen.width / 30f * 2f);
												char2.height = (float)Screen.height / 30f * 5f;
										}
					}}

				if(spot13 || spot23 || spot33)
				{	
					if(spot13){a = chosenCharacter1x; } else if (spot23){a = chosenCharacter2x;}else if(spot33){a = chosenCharacter3x;}
								if (char3.x < a) {
										if (selectchar3) {
												char3.x += 30;
												char3.width = ((float)Screen.width / 30f * 2f);
												char3.height = (float)Screen.height / 30f * 5f;
										}
								}
				}
					if(spot14 || spot24 || spot34)
					{	
						if(spot14){a = chosenCharacter1x; } else if (spot24){a = chosenCharacter2x;}else if(spot34){a = chosenCharacter3x;}
								if (char4.x < a) {
										if (selectchar4) {
												char4.x += 30;
												char4.width = ((float)Screen.width / 30f * 2f);
												char4.height = (float)Screen.height / 30f * 5f;
										}
								}
				}
						if(spot15 || spot25 || spot35)
						{	
							if(spot15){a = chosenCharacter1x; } else if (spot25){a = chosenCharacter2x;}else if(spot35){a = chosenCharacter3x;}
								if (char5.x < a) {
										if (selectchar5) {
												char5.x += 30;
												char5.width = ((float)Screen.width / 30f * 2f);
												char5.height = (float)Screen.height / 30f * 5f;
										}
								}
					}
							if(spot16 || spot26 || spot36)
							{	
								if(spot16){a = chosenCharacter1x; } else if (spot26){a = chosenCharacter2x;}else if(spot36){a = chosenCharacter3x;}
								if (char6.x < a) {
										if (selectchar6) {
												char6.x += 30;
												char6.width = ((float)Screen.width / 30f * 2f);
												char6.height = (float)Screen.height / 30f * 5f;
										}
								}
							}
						
				}
				 else {

			if(char1.x > char1B.x ) {

				if(!selectchar1 ){
				char1.x -= 30;
				char1.width = ((float)Screen.width / 30f * 2.75f);
				char1.height = (float)Screen.height / 30f * 11.75f;
				}}
			if(char2.x > char2B.x ) {
				if(!selectchar2 ){
					char2.x -= 30;
					char2.width = ((float)Screen.width / 30f * 2.75f);
					char2.height = (float)Screen.height / 30f * 11.75f;
				}}
			if(char3.x > char3B.x ) {
				if(!selectchar3 ){
					char3.x -= 30;
					char3.width = ((float)Screen.width / 30f * 2.75f);
					char3.height = (float)Screen.height / 30f * 11.75f;
				}}
			if(char4.x > char4B.x ) {
				if(!selectchar4 ){
					char4.x -= 30;
					char4.width = ((float)Screen.width / 30f * 2.75f);
					char4.height = (float)Screen.height / 30f * 11.75f;
				}}
			if(char5.x > char5B.x ) {
				if(!selectchar5 ){
					char5.x -= 30;
					char5.width = ((float)Screen.width / 30f * 2.75f);
					char5.height = (float)Screen.height / 30f * 11.75f;
				}}
			if(char6.x > char6B.x ) {
				if(!selectchar6 ){
					char6.x -= 30;
					char6.width = ((float)Screen.width / 30f * 2.75f);
					char6.height = (float)Screen.height / 30f * 11.75f;
				}}
			}

				



	}

}

