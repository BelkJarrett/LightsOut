using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LODiagnosticGameManager : MonoBehaviour
{
    //LO ARRAY ARRANGEMENT
    //[00][01][02][03][04] // if value is <5 don't do above
    //[05][06][07][08][09]
    //[10][11][12][13][14]
    //[15][16][17][18][19]
    //[20][21][22][23][24] // if value is >=20 don't do blow

    ///UNCOMMENT between ========== and fill out information accordingly
    /// <summary>
    /// GLOBAL SCOPE CLASS MEMBER VARIABLES
    //	Project Name: LightsOut
    //	Date:	ENTERDATE
    //	Links:	https://youtu.be/xSEFaKuaFYM
    /// </summary>
    //==========

    public bool[] gridArray;//change VARIABLETYPE to correct type
	public bool puzzleSolved = false;//change VARIABLETYPE to correct type
	public int turnCounter = 0;
    public GameObject[] gameObjectArray; //change VARIABLETYPE to correct type
    //==========


    //This function should be called each time a player enters a move
    public bool checkWinFunction()
    {
        //THIS IS ONE RULE, complete the other rules and for the other player.
        //	Remove true and /**/ comment codes and edit/modify VARUABLETYPE_PLAYER1VALUE to its correct value
        bool winState = false;
        
        for (int i = 0; i < gridArray.Length; i++)
        {
            if(gridArray[i] == true)
            {
                winState = false;
                break;
            }
        }

        return winState;
	}

	// Start is called before the first frame update
	void Start()
    {

        int tempRandom = 0;
        bool randomValue = false;
        for (int i =0; i< gameObjectArray.Length; i++)
        {
            tempRandom = Random.Range((int)0, 9);
            if (tempRandom == 0)
            {
                randomValue = false;
            }
            else
            {
                randomValue = true;
            }
            gridArray[i] = randomValue;
            gameObjectArray[i].GetComponent<LODiagnosticButton>().init(randomValue);
        }

    }

    public void toggleGridLocation(int _index)
    {
            gridArray[_index] = !gridArray[_index];
            gameObjectArray[_index].GetComponent<LODiagnosticButton>().setOnOff(gridArray[_index]);

        bool checkIfPlayerWon = checkWinFunction();

        if (checkIfPlayerWon == false /*&& turnCounter >= ????? */)
        {
            Debug.Log("we won");
        }
    }

    public void enterMove(int _index)
	{
        turnCounter = turnCounter + 1;
        //THIS TESTS IF THE ARRAY'S SPACE/LOCATION HAS BEEN INTERACTED WITH BEFORE
        //	IF so, which means that it isn't empty or default value, allow the array space as determined by the _index variable in line 49
        //		to be set to the value that represents the first player or the second player respectively
        //	Remove true and /**/ comment codes and edit/modify VARUABLETYPE_PLAYER1VALUE to its correct value
       
        int tempLocationInt = -1;

        //<TODO
        //TOGGLE CLICKED
        tempLocationInt = _index;
        if (tempLocationInt >= 0 && tempLocationInt < 25)
        {
            gridArray[tempLocationInt] = !gridArray[tempLocationInt];
            gameObjectArray[tempLocationInt].GetComponent<LODiagnosticButton>().setOnOff(gridArray[tempLocationInt]);
        }
        //TOGGLE LEFT
        tempLocationInt = _index % 5;
        if (tempLocationInt != 0)
        {
            tempLocationInt = _index - 1;
            gridArray[tempLocationInt] = !gridArray[tempLocationInt];
            gameObjectArray[tempLocationInt].GetComponent<LODiagnosticButton>().setOnOff(gridArray[tempLocationInt]);
        }

        //TOGGLE RIGHT
        tempLocationInt = _index;
        tempLocationInt = (_index + 1) % 5;
        if(tempLocationInt != 0)
        {
            tempLocationInt = _index + 1;
            gridArray[tempLocationInt] = !gridArray[tempLocationInt];
            gameObjectArray[tempLocationInt].GetComponent<LODiagnosticButton>().setOnOff(gridArray[tempLocationInt]);
        }
        //TOGGLE ABOVE
        tempLocationInt = _index;
        if(tempLocationInt >= 5)
        {
            tempLocationInt = _index - 5;
            gridArray[tempLocationInt] = !gridArray[tempLocationInt];
            gameObjectArray[tempLocationInt].GetComponent<LODiagnosticButton>().setOnOff(gridArray[tempLocationInt]);
        }
        //TOGGLE BELOW: if
        tempLocationInt = _index;
        if (tempLocationInt < 20)
        {
            tempLocationInt = _index + 5;
            gridArray[tempLocationInt] = !gridArray[tempLocationInt];
            gameObjectArray[tempLocationInt].GetComponent<LODiagnosticButton>().setOnOff(gridArray[tempLocationInt]);
        }


        //if(_index == 0)
        //{
        //    tempLocationInt = 1;
        //    gridArray[tempLocationInt] = !gridArray[tempLocationInt];
        //   gameObjectArray[tempLocationInt].GetComponent<LODiagnosticButton>().setOnOff(gridArray[tempLocationInt]);
        //   tempLocationInt = 0;
        //    gridArray[tempLocationInt] = !gridArray[tempLocationInt];
        //    gameObjectArray[tempLocationInt].GetComponent<LODiagnosticButton>().setOnOff(gridArray[tempLocationInt]);
        //    tempLocationInt = 5;
        //    gridArray[tempLocationInt] = !gridArray[tempLocationInt];
        //    gameObjectArray[tempLocationInt].GetComponent<LODiagnosticButton>().setOnOff(gridArray[tempLocationInt]);
        //}
        //if (_index == 1)
        //{
        //    tempLocationInt = 0;
        //    gridArray[tempLocationInt] = !gridArray[tempLocationInt];
        //    gameObjectArray[tempLocationInt].GetComponent<LODiagnosticButton>().setOnOff(gridArray[tempLocationInt]);
        //    tempLocationInt = 1;
        //    gridArray[tempLocationInt] = !gridArray[tempLocationInt];
        //    gameObjectArray[tempLocationInt].GetComponent<LODiagnosticButton>().setOnOff(gridArray[tempLocationInt]);
        //    tempLocationInt = 2;
        //    gridArray[tempLocationInt] = !gridArray[tempLocationInt];
        //    gameObjectArray[tempLocationInt].GetComponent<LODiagnosticButton>().setOnOff(gridArray[tempLocationInt]);
        //    tempLocationInt = 6;
        //    gridArray[tempLocationInt] = !gridArray[tempLocationInt];
        //    gameObjectArray[tempLocationInt].GetComponent<LODiagnosticButton>().setOnOff(gridArray[tempLocationInt]);
        //}

        bool checkIfPlayerWon = checkWinFunction();


		//SET TURN TO THE OTHER PLAYER'S TURNTYPE

	}

    public void enterMoveEvent(int _index)
    {
        turnCounter = turnCounter + 1;
        //THIS TESTS IF THE ARRAY'S SPACE/LOCATION HAS BEEN INTERACTED WITH BEFORE
        //	IF so, which means that it isn't empty or default value, allow the array space as determined by the _index variable in line 49
        //		to be set to the value that represents the first player or the second player respectively
        //	Remove true and /**/ comment codes and edit/modify VARUABLETYPE_PLAYER1VALUE to its correct value

        int tempLocationInt = -1;

        //<TODO
        //TOGGLE CLICKED
        tempLocationInt = _index;
        if (tempLocationInt >= 0 && tempLocationInt < 25)
        {
            gridArray[tempLocationInt] = !gridArray[tempLocationInt];
            gameObjectArray[tempLocationInt].GetComponent<LODiagnosticButton>().setOnOff(gridArray[tempLocationInt]);
        }


        bool checkIfPlayerWon = checkWinFunction();

        if (checkIfPlayerWon == false /*&& turnCounter >= ????? */)
        {
        	Debug.Log("we won");
        }

        //SET TURN TO THE OTHER PLAYER'S TURNTYPE

    }

    //remove void and REPLACE VARIABLETYPE with correct datatype from currentTurn above
    public bool getTurn()
	{

        return false; //currentTurn;
	}

	// Update is called once per frame
	void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
          checkWinFunction();
        }
    }
}
