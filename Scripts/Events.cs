using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Events : MonoBehaviour
{
    public void ReplayGame()
    {

        SceneManager.LoadScene("Final");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void CharactersSelection()
    {

        SceneManager.LoadScene("CharacterSelection");
    }

    public void Defa()
    {

        SceneManager.LoadScene("Default");
    }

    public void chargame2()
    {

        SceneManager.LoadScene("Character2GamePlay");
    }

    public void charsel2()
    {

        SceneManager.LoadScene("Default");
    }


    public void charsel3()
    {

        SceneManager.LoadScene("CharacterSelection");
    }
    public void charsel4()
    {

        SceneManager.LoadScene("CharacterSelection1");
    }

    public void charsel5()
    {

        SceneManager.LoadScene("CharacterSelection2");
    }


    public void charsel6()
    {

        SceneManager.LoadScene("CharacterSelection3");
    }
    public void charsel7()
    {

        SceneManager.LoadScene("CharacterSelection4");
    }












    public void chargame3()
    {

        SceneManager.LoadScene("Character3GamePlay");
    }

    public void chargame4()
    {

        SceneManager.LoadScene("Character4GamePlay");
    }

    public void chargame5()
    {

        SceneManager.LoadScene("Character5GamePlay");
    }
    public void chargame6()
    {

        SceneManager.LoadScene("Character6GamePlay");
    }
    public void Store()
    {
        SceneManager.LoadScene("Store");
    }
}
