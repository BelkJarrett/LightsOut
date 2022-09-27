using UnityEngine;

[SelectionBase]
public class LODiagnosticButton : MonoBehaviour
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
    //	Date:	4/19/2021
    //	Links:	https://youtu.be/xSEFaKuaFYM
    /// </summary>
    //==========

    public int myNumericID;//change VARIABLETYPE to correct type
    //public bool puzzleSolved = false;//change VARIABLETYPE to correct type
	//public VARIABLETYPE myValue;

	//DROP THE GAMEMANAGEROBJECT INTO THE FOLLOWING VARIABLE REFERENCE IN THE INSPECTOR; 
	//	REPEAT FOR EACH BUTTON OBJECT IN HIERARCHY
	public LODiagnosticGameManager myGameManager; //change VARIABLETYPE to correct type
    public GameObject mngr;
	//==========

	private void OnMouseDown()
	{

        if (myGameManager.puzzleSolved == false)
        {
            //Debug.Log("OnMouseDown:" + gameObject.name);
            myGameManager.enterMove(myNumericID);
            
        }
        
    }

    public void toggleValue()
    {
        myGameManager.toggleGridLocation(myNumericID);
    }

    public void setOnOff(bool _value = false)
    {
                        
            if (_value == false)
            {
                gameObject.transform.GetChild(0).gameObject.SetActive(true);
                gameObject.transform.GetChild(1).gameObject.SetActive(false);
            }
            else
            {
                gameObject.transform.GetChild(0).gameObject.SetActive(false);
                gameObject.transform.GetChild(1).gameObject.SetActive(true);
            }
            //myGameManager.enterMove(_indexID);
            //mngr.GetComponent<LODiagnosticGameManager>().enterMove(_indexID);
     
    }

    //public void interactiveFunctionDeprecated(int _indexID = -1)
	//{
		
	//	if (_indexID >= 0 && puzzleSolved == false)
	//	{
    //        bool currentPlayerTurn = myGameManager.getTurn();
    //        if (currentPlayerTurn == false)
    //        {
     //           gameObject.transform.GetChild(0).gameObject.SetActive(true);
     //     }
      //    else
      //    {
      //         gameObject.transform.GetChild(1).gameObject.SetActive(true);
      //    }
      //   //myGameManager.enterMove(_indexID);
      //    mngr.GetComponent<LODiagnosticGameManager>().enterMove(_indexID);
     //
     //}
     //puzzleSolved = true;
	//}

    public void init(bool _whichChildvalue)
    {
        setOnOff(_whichChildvalue);
        
    //gameObject.transform.GetChild(_whichChildvalue).gameObject.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
        gameObject.transform.GetChild(1).gameObject.SetActive(false);

        //for (int i = 0; i < 2; i++)
        //{
        //  gameObject.transform.GetChild(i).gameObject.SetActive(false);
        //}


    }

   // Update is called once per frame
    void Update()
    {
        
    }
}
