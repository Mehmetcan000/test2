using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;




public class LevelMenuManager : MonoBehaviour
{
    public QuestionObject[] questionObject;
   
    public void HangiOyunAcilsin() //Hangi Scriptable Obje Açýlacak
    {
       
        
       



    }

    public void TurnBack()
    {

        SceneManager.LoadScene("MainMenu");

    }



}
