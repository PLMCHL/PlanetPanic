// Internal view logic generated from "MainMenuScene.xml"
#region Using Statements
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
#endregion

namespace Delight
{
    public partial class MainMenuScene : UIView
    {
        #region Constructors

        public MainMenuScene(View parent, View layoutParent = null, string id = null, Template template = null, bool deferInitialization = false) :
            base(parent, layoutParent, id, template ?? MainMenuSceneTemplates.Default, deferInitialization)
        {
            if (deferInitialization)
                return;

            // constructing MainMenu (MainMenu1)
            MainMenu1 = new MainMenu(this, this, "MainMenu1", MainMenu1Template);
            this.AfterInitializeInternal();
        }

        public MainMenuScene() : this(null)
        {
        }

        static MainMenuScene()
        {
            var dependencyProperties = new List<DependencyProperty>();
            DependencyProperties.Add(MainMenuSceneTemplates.Default, dependencyProperties);

            dependencyProperties.Add(MainMenu1Property);
            dependencyProperties.Add(MainMenu1TemplateProperty);
        }

        #endregion

        #region Properties

        public readonly static DependencyProperty<MainMenu> MainMenu1Property = new DependencyProperty<MainMenu>("MainMenu1");
        public MainMenu MainMenu1
        {
            get { return MainMenu1Property.GetValue(this); }
            set { MainMenu1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> MainMenu1TemplateProperty = new DependencyProperty<Template>("MainMenu1Template");
        public Template MainMenu1Template
        {
            get { return MainMenu1TemplateProperty.GetValue(this); }
            set { MainMenu1TemplateProperty.SetValue(this, value); }
        }

        #endregion
    }

    #region Data Templates

    public static class MainMenuSceneTemplates
    {
        #region Properties

        public static Template Default
        {
            get
            {
                return MainMenuScene;
            }
        }

        private static Template _mainMenuScene;
        public static Template MainMenuScene
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuScene == null || _mainMenuScene.CurrentVersion != Template.Version)
#else
                if (_mainMenuScene == null)
#endif
                {
                    _mainMenuScene = new Template(UIViewTemplates.UIView);
#if UNITY_EDITOR
                    _mainMenuScene.Name = "MainMenuScene";
                    _mainMenuScene.LineNumber = 0;
                    _mainMenuScene.LinePosition = 0;
#endif
                    Delight.MainMenuScene.MainMenu1TemplateProperty.SetDefault(_mainMenuScene, MainMenuSceneMainMenu1);
                }
                return _mainMenuScene;
            }
        }

        private static Template _mainMenuSceneMainMenu1;
        public static Template MainMenuSceneMainMenu1
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenu1 == null || _mainMenuSceneMainMenu1.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenu1 == null)
#endif
                {
                    _mainMenuSceneMainMenu1 = new Template(MainMenuTemplates.MainMenu);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenu1.Name = "MainMenuSceneMainMenu1";
                    _mainMenuSceneMainMenu1.LineNumber = 2;
                    _mainMenuSceneMainMenu1.LinePosition = 4;
#endif
                    Delight.MainMenu.SubmenuSwitcherTemplateProperty.SetDefault(_mainMenuSceneMainMenu1, MainMenuSceneMainMenu1SubmenuSwitcher);
                    Delight.MainMenu.MainMenuWindowTemplateProperty.SetDefault(_mainMenuSceneMainMenu1, MainMenuSceneMainMenu1MainMenuWindow);
                    Delight.MainMenu.Image1TemplateProperty.SetDefault(_mainMenuSceneMainMenu1, MainMenuSceneMainMenu1Image1);
                    Delight.MainMenu.Label1TemplateProperty.SetDefault(_mainMenuSceneMainMenu1, MainMenuSceneMainMenu1Label1);
                    Delight.MainMenu.Group1TemplateProperty.SetDefault(_mainMenuSceneMainMenu1, MainMenuSceneMainMenu1Group1);
                    Delight.MainMenu.Button1TemplateProperty.SetDefault(_mainMenuSceneMainMenu1, MainMenuSceneMainMenu1Button1);
                    Delight.MainMenu.Button2TemplateProperty.SetDefault(_mainMenuSceneMainMenu1, MainMenuSceneMainMenu1Button2);
                    Delight.MainMenu.Button3TemplateProperty.SetDefault(_mainMenuSceneMainMenu1, MainMenuSceneMainMenu1Button3);
                    Delight.MainMenu.PlayerSelectWindowTemplateProperty.SetDefault(_mainMenuSceneMainMenu1, MainMenuSceneMainMenu1PlayerSelectWindow);
                    Delight.MainMenu.Group2TemplateProperty.SetDefault(_mainMenuSceneMainMenu1, MainMenuSceneMainMenu1Group2);
                    Delight.MainMenu.Button4TemplateProperty.SetDefault(_mainMenuSceneMainMenu1, MainMenuSceneMainMenu1Button4);
                    Delight.MainMenu.Button5TemplateProperty.SetDefault(_mainMenuSceneMainMenu1, MainMenuSceneMainMenu1Button5);
                    Delight.MainMenu.OptionsWindowTemplateProperty.SetDefault(_mainMenuSceneMainMenu1, MainMenuSceneMainMenu1OptionsWindow);
                    Delight.MainMenu.Button6TemplateProperty.SetDefault(_mainMenuSceneMainMenu1, MainMenuSceneMainMenu1Button6);
                }
                return _mainMenuSceneMainMenu1;
            }
        }

        private static Template _mainMenuSceneMainMenu1SubmenuSwitcher;
        public static Template MainMenuSceneMainMenu1SubmenuSwitcher
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenu1SubmenuSwitcher == null || _mainMenuSceneMainMenu1SubmenuSwitcher.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenu1SubmenuSwitcher == null)
#endif
                {
                    _mainMenuSceneMainMenu1SubmenuSwitcher = new Template(MainMenuTemplates.MainMenuSubmenuSwitcher);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenu1SubmenuSwitcher.Name = "MainMenuSceneMainMenu1SubmenuSwitcher";
                    _mainMenuSceneMainMenu1SubmenuSwitcher.LineNumber = 2;
                    _mainMenuSceneMainMenu1SubmenuSwitcher.LinePosition = 4;
#endif
                }
                return _mainMenuSceneMainMenu1SubmenuSwitcher;
            }
        }

        private static Template _mainMenuSceneMainMenu1MainMenuWindow;
        public static Template MainMenuSceneMainMenu1MainMenuWindow
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenu1MainMenuWindow == null || _mainMenuSceneMainMenu1MainMenuWindow.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenu1MainMenuWindow == null)
#endif
                {
                    _mainMenuSceneMainMenu1MainMenuWindow = new Template(MainMenuTemplates.MainMenuMainMenuWindow);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenu1MainMenuWindow.Name = "MainMenuSceneMainMenu1MainMenuWindow";
                    _mainMenuSceneMainMenu1MainMenuWindow.LineNumber = 5;
                    _mainMenuSceneMainMenu1MainMenuWindow.LinePosition = 6;
#endif
                }
                return _mainMenuSceneMainMenu1MainMenuWindow;
            }
        }

        private static Template _mainMenuSceneMainMenu1Image1;
        public static Template MainMenuSceneMainMenu1Image1
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenu1Image1 == null || _mainMenuSceneMainMenu1Image1.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenu1Image1 == null)
#endif
                {
                    _mainMenuSceneMainMenu1Image1 = new Template(MainMenuTemplates.MainMenuImage1);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenu1Image1.Name = "MainMenuSceneMainMenu1Image1";
                    _mainMenuSceneMainMenu1Image1.LineNumber = 6;
                    _mainMenuSceneMainMenu1Image1.LinePosition = 8;
#endif
                }
                return _mainMenuSceneMainMenu1Image1;
            }
        }

        private static Template _mainMenuSceneMainMenu1Label1;
        public static Template MainMenuSceneMainMenu1Label1
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenu1Label1 == null || _mainMenuSceneMainMenu1Label1.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenu1Label1 == null)
#endif
                {
                    _mainMenuSceneMainMenu1Label1 = new Template(MainMenuTemplates.MainMenuLabel1);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenu1Label1.Name = "MainMenuSceneMainMenu1Label1";
                    _mainMenuSceneMainMenu1Label1.LineNumber = 7;
                    _mainMenuSceneMainMenu1Label1.LinePosition = 8;
#endif
                }
                return _mainMenuSceneMainMenu1Label1;
            }
        }

        private static Template _mainMenuSceneMainMenu1Group1;
        public static Template MainMenuSceneMainMenu1Group1
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenu1Group1 == null || _mainMenuSceneMainMenu1Group1.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenu1Group1 == null)
#endif
                {
                    _mainMenuSceneMainMenu1Group1 = new Template(MainMenuTemplates.MainMenuGroup1);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenu1Group1.Name = "MainMenuSceneMainMenu1Group1";
                    _mainMenuSceneMainMenu1Group1.LineNumber = 8;
                    _mainMenuSceneMainMenu1Group1.LinePosition = 8;
#endif
                }
                return _mainMenuSceneMainMenu1Group1;
            }
        }

        private static Template _mainMenuSceneMainMenu1Button1;
        public static Template MainMenuSceneMainMenu1Button1
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenu1Button1 == null || _mainMenuSceneMainMenu1Button1.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenu1Button1 == null)
#endif
                {
                    _mainMenuSceneMainMenu1Button1 = new Template(MainMenuTemplates.MainMenuButton1);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenu1Button1.Name = "MainMenuSceneMainMenu1Button1";
                    _mainMenuSceneMainMenu1Button1.LineNumber = 9;
                    _mainMenuSceneMainMenu1Button1.LinePosition = 10;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuSceneMainMenu1Button1, MainMenuSceneMainMenu1Button1Label);
                }
                return _mainMenuSceneMainMenu1Button1;
            }
        }

        private static Template _mainMenuSceneMainMenu1Button1Label;
        public static Template MainMenuSceneMainMenu1Button1Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenu1Button1Label == null || _mainMenuSceneMainMenu1Button1Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenu1Button1Label == null)
#endif
                {
                    _mainMenuSceneMainMenu1Button1Label = new Template(MainMenuTemplates.MainMenuButton1Label);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenu1Button1Label.Name = "MainMenuSceneMainMenu1Button1Label";
                    _mainMenuSceneMainMenu1Button1Label.LineNumber = 15;
                    _mainMenuSceneMainMenu1Button1Label.LinePosition = 4;
#endif
                }
                return _mainMenuSceneMainMenu1Button1Label;
            }
        }

        private static Template _mainMenuSceneMainMenu1Button2;
        public static Template MainMenuSceneMainMenu1Button2
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenu1Button2 == null || _mainMenuSceneMainMenu1Button2.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenu1Button2 == null)
#endif
                {
                    _mainMenuSceneMainMenu1Button2 = new Template(MainMenuTemplates.MainMenuButton2);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenu1Button2.Name = "MainMenuSceneMainMenu1Button2";
                    _mainMenuSceneMainMenu1Button2.LineNumber = 10;
                    _mainMenuSceneMainMenu1Button2.LinePosition = 10;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuSceneMainMenu1Button2, MainMenuSceneMainMenu1Button2Label);
                }
                return _mainMenuSceneMainMenu1Button2;
            }
        }

        private static Template _mainMenuSceneMainMenu1Button2Label;
        public static Template MainMenuSceneMainMenu1Button2Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenu1Button2Label == null || _mainMenuSceneMainMenu1Button2Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenu1Button2Label == null)
#endif
                {
                    _mainMenuSceneMainMenu1Button2Label = new Template(MainMenuTemplates.MainMenuButton2Label);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenu1Button2Label.Name = "MainMenuSceneMainMenu1Button2Label";
                    _mainMenuSceneMainMenu1Button2Label.LineNumber = 15;
                    _mainMenuSceneMainMenu1Button2Label.LinePosition = 4;
#endif
                }
                return _mainMenuSceneMainMenu1Button2Label;
            }
        }

        private static Template _mainMenuSceneMainMenu1Button3;
        public static Template MainMenuSceneMainMenu1Button3
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenu1Button3 == null || _mainMenuSceneMainMenu1Button3.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenu1Button3 == null)
#endif
                {
                    _mainMenuSceneMainMenu1Button3 = new Template(MainMenuTemplates.MainMenuButton3);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenu1Button3.Name = "MainMenuSceneMainMenu1Button3";
                    _mainMenuSceneMainMenu1Button3.LineNumber = 11;
                    _mainMenuSceneMainMenu1Button3.LinePosition = 10;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuSceneMainMenu1Button3, MainMenuSceneMainMenu1Button3Label);
                }
                return _mainMenuSceneMainMenu1Button3;
            }
        }

        private static Template _mainMenuSceneMainMenu1Button3Label;
        public static Template MainMenuSceneMainMenu1Button3Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenu1Button3Label == null || _mainMenuSceneMainMenu1Button3Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenu1Button3Label == null)
#endif
                {
                    _mainMenuSceneMainMenu1Button3Label = new Template(MainMenuTemplates.MainMenuButton3Label);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenu1Button3Label.Name = "MainMenuSceneMainMenu1Button3Label";
                    _mainMenuSceneMainMenu1Button3Label.LineNumber = 15;
                    _mainMenuSceneMainMenu1Button3Label.LinePosition = 4;
#endif
                }
                return _mainMenuSceneMainMenu1Button3Label;
            }
        }

        private static Template _mainMenuSceneMainMenu1PlayerSelectWindow;
        public static Template MainMenuSceneMainMenu1PlayerSelectWindow
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenu1PlayerSelectWindow == null || _mainMenuSceneMainMenu1PlayerSelectWindow.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenu1PlayerSelectWindow == null)
#endif
                {
                    _mainMenuSceneMainMenu1PlayerSelectWindow = new Template(MainMenuTemplates.MainMenuPlayerSelectWindow);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenu1PlayerSelectWindow.Name = "MainMenuSceneMainMenu1PlayerSelectWindow";
                    _mainMenuSceneMainMenu1PlayerSelectWindow.LineNumber = 16;
                    _mainMenuSceneMainMenu1PlayerSelectWindow.LinePosition = 6;
#endif
                }
                return _mainMenuSceneMainMenu1PlayerSelectWindow;
            }
        }

        private static Template _mainMenuSceneMainMenu1Group2;
        public static Template MainMenuSceneMainMenu1Group2
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenu1Group2 == null || _mainMenuSceneMainMenu1Group2.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenu1Group2 == null)
#endif
                {
                    _mainMenuSceneMainMenu1Group2 = new Template(MainMenuTemplates.MainMenuGroup2);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenu1Group2.Name = "MainMenuSceneMainMenu1Group2";
                    _mainMenuSceneMainMenu1Group2.LineNumber = 17;
                    _mainMenuSceneMainMenu1Group2.LinePosition = 8;
#endif
                }
                return _mainMenuSceneMainMenu1Group2;
            }
        }

        private static Template _mainMenuSceneMainMenu1Button4;
        public static Template MainMenuSceneMainMenu1Button4
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenu1Button4 == null || _mainMenuSceneMainMenu1Button4.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenu1Button4 == null)
#endif
                {
                    _mainMenuSceneMainMenu1Button4 = new Template(MainMenuTemplates.MainMenuButton4);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenu1Button4.Name = "MainMenuSceneMainMenu1Button4";
                    _mainMenuSceneMainMenu1Button4.LineNumber = 18;
                    _mainMenuSceneMainMenu1Button4.LinePosition = 10;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuSceneMainMenu1Button4, MainMenuSceneMainMenu1Button4Label);
                }
                return _mainMenuSceneMainMenu1Button4;
            }
        }

        private static Template _mainMenuSceneMainMenu1Button4Label;
        public static Template MainMenuSceneMainMenu1Button4Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenu1Button4Label == null || _mainMenuSceneMainMenu1Button4Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenu1Button4Label == null)
#endif
                {
                    _mainMenuSceneMainMenu1Button4Label = new Template(MainMenuTemplates.MainMenuButton4Label);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenu1Button4Label.Name = "MainMenuSceneMainMenu1Button4Label";
                    _mainMenuSceneMainMenu1Button4Label.LineNumber = 15;
                    _mainMenuSceneMainMenu1Button4Label.LinePosition = 4;
#endif
                }
                return _mainMenuSceneMainMenu1Button4Label;
            }
        }

        private static Template _mainMenuSceneMainMenu1Button5;
        public static Template MainMenuSceneMainMenu1Button5
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenu1Button5 == null || _mainMenuSceneMainMenu1Button5.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenu1Button5 == null)
#endif
                {
                    _mainMenuSceneMainMenu1Button5 = new Template(MainMenuTemplates.MainMenuButton5);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenu1Button5.Name = "MainMenuSceneMainMenu1Button5";
                    _mainMenuSceneMainMenu1Button5.LineNumber = 19;
                    _mainMenuSceneMainMenu1Button5.LinePosition = 10;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuSceneMainMenu1Button5, MainMenuSceneMainMenu1Button5Label);
                }
                return _mainMenuSceneMainMenu1Button5;
            }
        }

        private static Template _mainMenuSceneMainMenu1Button5Label;
        public static Template MainMenuSceneMainMenu1Button5Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenu1Button5Label == null || _mainMenuSceneMainMenu1Button5Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenu1Button5Label == null)
#endif
                {
                    _mainMenuSceneMainMenu1Button5Label = new Template(MainMenuTemplates.MainMenuButton5Label);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenu1Button5Label.Name = "MainMenuSceneMainMenu1Button5Label";
                    _mainMenuSceneMainMenu1Button5Label.LineNumber = 15;
                    _mainMenuSceneMainMenu1Button5Label.LinePosition = 4;
#endif
                }
                return _mainMenuSceneMainMenu1Button5Label;
            }
        }

        private static Template _mainMenuSceneMainMenu1OptionsWindow;
        public static Template MainMenuSceneMainMenu1OptionsWindow
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenu1OptionsWindow == null || _mainMenuSceneMainMenu1OptionsWindow.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenu1OptionsWindow == null)
#endif
                {
                    _mainMenuSceneMainMenu1OptionsWindow = new Template(MainMenuTemplates.MainMenuOptionsWindow);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenu1OptionsWindow.Name = "MainMenuSceneMainMenu1OptionsWindow";
                    _mainMenuSceneMainMenu1OptionsWindow.LineNumber = 24;
                    _mainMenuSceneMainMenu1OptionsWindow.LinePosition = 6;
#endif
                }
                return _mainMenuSceneMainMenu1OptionsWindow;
            }
        }

        private static Template _mainMenuSceneMainMenu1Button6;
        public static Template MainMenuSceneMainMenu1Button6
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenu1Button6 == null || _mainMenuSceneMainMenu1Button6.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenu1Button6 == null)
#endif
                {
                    _mainMenuSceneMainMenu1Button6 = new Template(MainMenuTemplates.MainMenuButton6);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenu1Button6.Name = "MainMenuSceneMainMenu1Button6";
                    _mainMenuSceneMainMenu1Button6.LineNumber = 25;
                    _mainMenuSceneMainMenu1Button6.LinePosition = 8;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuSceneMainMenu1Button6, MainMenuSceneMainMenu1Button6Label);
                }
                return _mainMenuSceneMainMenu1Button6;
            }
        }

        private static Template _mainMenuSceneMainMenu1Button6Label;
        public static Template MainMenuSceneMainMenu1Button6Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenu1Button6Label == null || _mainMenuSceneMainMenu1Button6Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenu1Button6Label == null)
#endif
                {
                    _mainMenuSceneMainMenu1Button6Label = new Template(MainMenuTemplates.MainMenuButton6Label);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenu1Button6Label.Name = "MainMenuSceneMainMenu1Button6Label";
                    _mainMenuSceneMainMenu1Button6Label.LineNumber = 15;
                    _mainMenuSceneMainMenu1Button6Label.LinePosition = 4;
#endif
                }
                return _mainMenuSceneMainMenu1Button6Label;
            }
        }

        #endregion
    }

    #endregion
}
