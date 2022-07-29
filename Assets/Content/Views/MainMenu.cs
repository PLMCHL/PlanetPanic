using UnityEngine;
using UnityEngine.SceneManagement;
using Assets.Content.Scripts.StaticContext;

namespace Delight
{
    public partial class MainMenu
    {
        int PlayerCount;

        public void StartGame()
        {
            GameSceneContext.PlayerCount = PlayerCount;
            SceneManager.LoadScene("GameScene");
        }

        public void Play()
        {
            SubmenuSwitcher.SwitchTo(PlayWindow);
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
