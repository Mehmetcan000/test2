using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;




public class LevelMenuManager : MonoBehaviour
{
    public QuestionObject[] questionObject;
   
    public void HangiOyunAcilsin() //Hangi Scriptable Obje A��lacak
    {
       
        
       



    }

    public void TurnBack()
    {

        SceneManager.LoadScene("MainMenu");

    }



}
