#region Using Statements
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
#endregion

namespace Delight
{
    public partial class MainMenu
    {
        public void StartGame()
        {
            SceneManager.LoadScene("GameScene");
        }

        public void Play()
        {
            SubmenuSwitcher.SwitchTo(PlayerSelectWindow);
        }

        public void ShowOptions()
        {
            Debug.Log("Options clicked");
            SubmenuSwitcher.SwitchTo(OptionsWindow);
        }

        public void Quit()
        {
            Debug.Log("Quit clicked");
            Application.Quit();
        }

        public void NavigateToMainMenu()
        {
            SubmenuSwitcher.SwitchTo(MainMenuWindow);
        }

    }
}
