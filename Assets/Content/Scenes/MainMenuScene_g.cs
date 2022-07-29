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
                    Delight.MainMenu.Group1TemplateProperty.SetDefault(_mainMenuSceneMainMenu1, MainMenuSceneMainMenu1Group1);
                    Delight.MainMenu.Button1TemplateProperty.SetDefault(_mainMenuSceneMainMenu1, MainMenuSceneMainMenu1Button1);
                    Delight.MainMenu.Button2TemplateProperty.SetDefault(_mainMenuSceneMainMenu1, MainMenuSceneMainMenu1Button2);
                    Delight.MainMenu.Button3TemplateProperty.SetDefault(_mainMenuSceneMainMenu1, MainMenuSceneMainMenu1Button3);
                    Delight.MainMenu.PlayWindowTemplateProperty.SetDefault(_mainMenuSceneMainMenu1, MainMenuSceneMainMenu1PlayWindow);
                    Delight.MainMenu.Group2TemplateProperty.SetDefault(_mainMenuSceneMainMenu1, MainMenuSceneMainMenu1Group2);
                    Delight.MainMenu.ToggleGroup1TemplateProperty.SetDefault(_mainMenuSceneMainMenu1, MainMenuSceneMainMenu1ToggleGroup1);
                    Delight.MainMenu.Label1TemplateProperty.SetDefault(_mainMenuSceneMainMenu1, MainMenuSceneMainMenu1Label1);
                    Delight.MainMenu.Button4TemplateProperty.SetDefault(_mainMenuSceneMainMenu1, MainMenuSceneMainMenu1Button4);
                    Delight.MainMenu.Button5TemplateProperty.SetDefault(_mainMenuSceneMainMenu1, MainMenuSceneMainMenu1Button5);
                    Delight.MainMenu.Button6TemplateProperty.SetDefault(_mainMenuSceneMainMenu1, MainMenuSceneMainMenu1Button6);
                    Delight.MainMenu.Button7TemplateProperty.SetDefault(_mainMenuSceneMainMenu1, MainMenuSceneMainMenu1Button7);
                    Delight.MainMenu.Button8TemplateProperty.SetDefault(_mainMenuSceneMainMenu1, MainMenuSceneMainMenu1Button8);
                    Delight.MainMenu.OptionsWindowTemplateProperty.SetDefault(_mainMenuSceneMainMenu1, MainMenuSceneMainMenu1OptionsWindow);
                    Delight.MainMenu.Button9TemplateProperty.SetDefault(_mainMenuSceneMainMenu1, MainMenuSceneMainMenu1Button9);
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
                    _mainMenuSceneMainMenu1Group1.LineNumber = 6;
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
                    _mainMenuSceneMainMenu1Button1.LineNumber = 7;
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
                    _mainMenuSceneMainMenu1Button2.LineNumber = 8;
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
                    _mainMenuSceneMainMenu1Button3.LineNumber = 9;
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

        private static Template _mainMenuSceneMainMenu1PlayWindow;
        public static Template MainMenuSceneMainMenu1PlayWindow
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenu1PlayWindow == null || _mainMenuSceneMainMenu1PlayWindow.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenu1PlayWindow == null)
#endif
                {
                    _mainMenuSceneMainMenu1PlayWindow = new Template(MainMenuTemplates.MainMenuPlayWindow);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenu1PlayWindow.Name = "MainMenuSceneMainMenu1PlayWindow";
                    _mainMenuSceneMainMenu1PlayWindow.LineNumber = 15;
                    _mainMenuSceneMainMenu1PlayWindow.LinePosition = 6;
#endif
                }
                return _mainMenuSceneMainMenu1PlayWindow;
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
                    _mainMenuSceneMainMenu1Group2.LineNumber = 16;
                    _mainMenuSceneMainMenu1Group2.LinePosition = 8;
#endif
                }
                return _mainMenuSceneMainMenu1Group2;
            }
        }

        private static Template _mainMenuSceneMainMenu1ToggleGroup1;
        public static Template MainMenuSceneMainMenu1ToggleGroup1
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenu1ToggleGroup1 == null || _mainMenuSceneMainMenu1ToggleGroup1.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenu1ToggleGroup1 == null)
#endif
                {
                    _mainMenuSceneMainMenu1ToggleGroup1 = new Template(MainMenuTemplates.MainMenuToggleGroup1);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenu1ToggleGroup1.Name = "MainMenuSceneMainMenu1ToggleGroup1";
                    _mainMenuSceneMainMenu1ToggleGroup1.LineNumber = 17;
                    _mainMenuSceneMainMenu1ToggleGroup1.LinePosition = 10;
#endif
                }
                return _mainMenuSceneMainMenu1ToggleGroup1;
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
                    _mainMenuSceneMainMenu1Label1.LineNumber = 18;
                    _mainMenuSceneMainMenu1Label1.LinePosition = 12;
#endif
                }
                return _mainMenuSceneMainMenu1Label1;
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
                    _mainMenuSceneMainMenu1Button4.LineNumber = 19;
                    _mainMenuSceneMainMenu1Button4.LinePosition = 12;
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
                    _mainMenuSceneMainMenu1Button5.LineNumber = 20;
                    _mainMenuSceneMainMenu1Button5.LinePosition = 12;
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
                    _mainMenuSceneMainMenu1Button6.LineNumber = 21;
                    _mainMenuSceneMainMenu1Button6.LinePosition = 12;
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

        private static Template _mainMenuSceneMainMenu1Button7;
        public static Template MainMenuSceneMainMenu1Button7
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenu1Button7 == null || _mainMenuSceneMainMenu1Button7.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenu1Button7 == null)
#endif
                {
                    _mainMenuSceneMainMenu1Button7 = new Template(MainMenuTemplates.MainMenuButton7);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenu1Button7.Name = "MainMenuSceneMainMenu1Button7";
                    _mainMenuSceneMainMenu1Button7.LineNumber = 23;
                    _mainMenuSceneMainMenu1Button7.LinePosition = 10;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuSceneMainMenu1Button7, MainMenuSceneMainMenu1Button7Label);
                }
                return _mainMenuSceneMainMenu1Button7;
            }
        }

        private static Template _mainMenuSceneMainMenu1Button7Label;
        public static Template MainMenuSceneMainMenu1Button7Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenu1Button7Label == null || _mainMenuSceneMainMenu1Button7Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenu1Button7Label == null)
#endif
                {
                    _mainMenuSceneMainMenu1Button7Label = new Template(MainMenuTemplates.MainMenuButton7Label);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenu1Button7Label.Name = "MainMenuSceneMainMenu1Button7Label";
                    _mainMenuSceneMainMenu1Button7Label.LineNumber = 15;
                    _mainMenuSceneMainMenu1Button7Label.LinePosition = 4;
#endif
                }
                return _mainMenuSceneMainMenu1Button7Label;
            }
        }

        private static Template _mainMenuSceneMainMenu1Button8;
        public static Template MainMenuSceneMainMenu1Button8
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenu1Button8 == null || _mainMenuSceneMainMenu1Button8.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenu1Button8 == null)
#endif
                {
                    _mainMenuSceneMainMenu1Button8 = new Template(MainMenuTemplates.MainMenuButton8);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenu1Button8.Name = "MainMenuSceneMainMenu1Button8";
                    _mainMenuSceneMainMenu1Button8.LineNumber = 24;
                    _mainMenuSceneMainMenu1Button8.LinePosition = 10;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuSceneMainMenu1Button8, MainMenuSceneMainMenu1Button8Label);
                }
                return _mainMenuSceneMainMenu1Button8;
            }
        }

        private static Template _mainMenuSceneMainMenu1Button8Label;
        public static Template MainMenuSceneMainMenu1Button8Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenu1Button8Label == null || _mainMenuSceneMainMenu1Button8Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenu1Button8Label == null)
#endif
                {
                    _mainMenuSceneMainMenu1Button8Label = new Template(MainMenuTemplates.MainMenuButton8Label);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenu1Button8Label.Name = "MainMenuSceneMainMenu1Button8Label";
                    _mainMenuSceneMainMenu1Button8Label.LineNumber = 15;
                    _mainMenuSceneMainMenu1Button8Label.LinePosition = 4;
#endif
                }
                return _mainMenuSceneMainMenu1Button8Label;
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
                    _mainMenuSceneMainMenu1OptionsWindow.LineNumber = 29;
                    _mainMenuSceneMainMenu1OptionsWindow.LinePosition = 6;
#endif
                }
                return _mainMenuSceneMainMenu1OptionsWindow;
            }
        }

        private static Template _mainMenuSceneMainMenu1Button9;
        public static Template MainMenuSceneMainMenu1Button9
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenu1Button9 == null || _mainMenuSceneMainMenu1Button9.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenu1Button9 == null)
#endif
                {
                    _mainMenuSceneMainMenu1Button9 = new Template(MainMenuTemplates.MainMenuButton9);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenu1Button9.Name = "MainMenuSceneMainMenu1Button9";
                    _mainMenuSceneMainMenu1Button9.LineNumber = 30;
                    _mainMenuSceneMainMenu1Button9.LinePosition = 8;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuSceneMainMenu1Button9, MainMenuSceneMainMenu1Button9Label);
                }
                return _mainMenuSceneMainMenu1Button9;
            }
        }

        private static Template _mainMenuSceneMainMenu1Button9Label;
        public static Template MainMenuSceneMainMenu1Button9Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenu1Button9Label == null || _mainMenuSceneMainMenu1Button9Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenu1Button9Label == null)
#endif
                {
                    _mainMenuSceneMainMenu1Button9Label = new Template(MainMenuTemplates.MainMenuButton9Label);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenu1Button9Label.Name = "MainMenuSceneMainMenu1Button9Label";
                    _mainMenuSceneMainMenu1Button9Label.LineNumber = 15;
                    _mainMenuSceneMainMenu1Button9Label.LinePosition = 4;
#endif
                }
                return _mainMenuSceneMainMenu1Button9Label;
            }
        }

        #endregion
    }

    #endregion
}
