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

            // constructing MainMenuView (MainMenuView1)
            MainMenuView1 = new MainMenuView(this, this, "MainMenuView1", MainMenuView1Template);
            this.AfterInitializeInternal();
        }

        public MainMenuScene() : this(null)
        {
        }

        static MainMenuScene()
        {
            var dependencyProperties = new List<DependencyProperty>();
            DependencyProperties.Add(MainMenuSceneTemplates.Default, dependencyProperties);

            dependencyProperties.Add(MainMenuView1Property);
            dependencyProperties.Add(MainMenuView1TemplateProperty);
        }

        #endregion

        #region Properties

        public readonly static DependencyProperty<MainMenuView> MainMenuView1Property = new DependencyProperty<MainMenuView>("MainMenuView1");
        public MainMenuView MainMenuView1
        {
            get { return MainMenuView1Property.GetValue(this); }
            set { MainMenuView1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> MainMenuView1TemplateProperty = new DependencyProperty<Template>("MainMenuView1Template");
        public Template MainMenuView1Template
        {
            get { return MainMenuView1TemplateProperty.GetValue(this); }
            set { MainMenuView1TemplateProperty.SetValue(this, value); }
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
                    Delight.MainMenuScene.MainMenuView1TemplateProperty.SetDefault(_mainMenuScene, MainMenuSceneMainMenuView1);
                }
                return _mainMenuScene;
            }
        }

        private static Template _mainMenuSceneMainMenuView1;
        public static Template MainMenuSceneMainMenuView1
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1 == null || _mainMenuSceneMainMenuView1.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1 == null)
#endif
                {
                    _mainMenuSceneMainMenuView1 = new Template(MainMenuViewTemplates.MainMenuView);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1.Name = "MainMenuSceneMainMenuView1";
                    _mainMenuSceneMainMenuView1.LineNumber = 2;
                    _mainMenuSceneMainMenuView1.LinePosition = 4;
#endif
                    Delight.MainMenuView.SubmenuSwitcherTemplateProperty.SetDefault(_mainMenuSceneMainMenuView1, MainMenuSceneMainMenuView1SubmenuSwitcher);
                    Delight.MainMenuView.MainMenuWindowTemplateProperty.SetDefault(_mainMenuSceneMainMenuView1, MainMenuSceneMainMenuView1MainMenuWindow);
                    Delight.MainMenuView.Group1TemplateProperty.SetDefault(_mainMenuSceneMainMenuView1, MainMenuSceneMainMenuView1Group1);
                    Delight.MainMenuView.Button1TemplateProperty.SetDefault(_mainMenuSceneMainMenuView1, MainMenuSceneMainMenuView1Button1);
                    Delight.MainMenuView.Button2TemplateProperty.SetDefault(_mainMenuSceneMainMenuView1, MainMenuSceneMainMenuView1Button2);
                    Delight.MainMenuView.Button3TemplateProperty.SetDefault(_mainMenuSceneMainMenuView1, MainMenuSceneMainMenuView1Button3);
                    Delight.MainMenuView.PlayWindowTemplateProperty.SetDefault(_mainMenuSceneMainMenuView1, MainMenuSceneMainMenuView1PlayWindow);
                    Delight.MainMenuView.Group2TemplateProperty.SetDefault(_mainMenuSceneMainMenuView1, MainMenuSceneMainMenuView1Group2);
                    Delight.MainMenuView.ToggleGroup1TemplateProperty.SetDefault(_mainMenuSceneMainMenuView1, MainMenuSceneMainMenuView1ToggleGroup1);
                    Delight.MainMenuView.Label1TemplateProperty.SetDefault(_mainMenuSceneMainMenuView1, MainMenuSceneMainMenuView1Label1);
                    Delight.MainMenuView.Button4TemplateProperty.SetDefault(_mainMenuSceneMainMenuView1, MainMenuSceneMainMenuView1Button4);
                    Delight.MainMenuView.Button5TemplateProperty.SetDefault(_mainMenuSceneMainMenuView1, MainMenuSceneMainMenuView1Button5);
                    Delight.MainMenuView.Button6TemplateProperty.SetDefault(_mainMenuSceneMainMenuView1, MainMenuSceneMainMenuView1Button6);
                    Delight.MainMenuView.Button7TemplateProperty.SetDefault(_mainMenuSceneMainMenuView1, MainMenuSceneMainMenuView1Button7);
                    Delight.MainMenuView.Button8TemplateProperty.SetDefault(_mainMenuSceneMainMenuView1, MainMenuSceneMainMenuView1Button8);
                    Delight.MainMenuView.OptionsWindowTemplateProperty.SetDefault(_mainMenuSceneMainMenuView1, MainMenuSceneMainMenuView1OptionsWindow);
                    Delight.MainMenuView.Button9TemplateProperty.SetDefault(_mainMenuSceneMainMenuView1, MainMenuSceneMainMenuView1Button9);
                }
                return _mainMenuSceneMainMenuView1;
            }
        }

        private static Template _mainMenuSceneMainMenuView1SubmenuSwitcher;
        public static Template MainMenuSceneMainMenuView1SubmenuSwitcher
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1SubmenuSwitcher == null || _mainMenuSceneMainMenuView1SubmenuSwitcher.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1SubmenuSwitcher == null)
#endif
                {
                    _mainMenuSceneMainMenuView1SubmenuSwitcher = new Template(MainMenuViewTemplates.MainMenuViewSubmenuSwitcher);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1SubmenuSwitcher.Name = "MainMenuSceneMainMenuView1SubmenuSwitcher";
                    _mainMenuSceneMainMenuView1SubmenuSwitcher.LineNumber = 2;
                    _mainMenuSceneMainMenuView1SubmenuSwitcher.LinePosition = 4;
#endif
                }
                return _mainMenuSceneMainMenuView1SubmenuSwitcher;
            }
        }

        private static Template _mainMenuSceneMainMenuView1MainMenuWindow;
        public static Template MainMenuSceneMainMenuView1MainMenuWindow
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1MainMenuWindow == null || _mainMenuSceneMainMenuView1MainMenuWindow.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1MainMenuWindow == null)
#endif
                {
                    _mainMenuSceneMainMenuView1MainMenuWindow = new Template(MainMenuViewTemplates.MainMenuViewMainMenuWindow);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1MainMenuWindow.Name = "MainMenuSceneMainMenuView1MainMenuWindow";
                    _mainMenuSceneMainMenuView1MainMenuWindow.LineNumber = 5;
                    _mainMenuSceneMainMenuView1MainMenuWindow.LinePosition = 6;
#endif
                }
                return _mainMenuSceneMainMenuView1MainMenuWindow;
            }
        }

        private static Template _mainMenuSceneMainMenuView1Group1;
        public static Template MainMenuSceneMainMenuView1Group1
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1Group1 == null || _mainMenuSceneMainMenuView1Group1.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1Group1 == null)
#endif
                {
                    _mainMenuSceneMainMenuView1Group1 = new Template(MainMenuViewTemplates.MainMenuViewGroup1);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1Group1.Name = "MainMenuSceneMainMenuView1Group1";
                    _mainMenuSceneMainMenuView1Group1.LineNumber = 6;
                    _mainMenuSceneMainMenuView1Group1.LinePosition = 8;
#endif
                }
                return _mainMenuSceneMainMenuView1Group1;
            }
        }

        private static Template _mainMenuSceneMainMenuView1Button1;
        public static Template MainMenuSceneMainMenuView1Button1
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1Button1 == null || _mainMenuSceneMainMenuView1Button1.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1Button1 == null)
#endif
                {
                    _mainMenuSceneMainMenuView1Button1 = new Template(MainMenuViewTemplates.MainMenuViewButton1);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1Button1.Name = "MainMenuSceneMainMenuView1Button1";
                    _mainMenuSceneMainMenuView1Button1.LineNumber = 7;
                    _mainMenuSceneMainMenuView1Button1.LinePosition = 10;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuSceneMainMenuView1Button1, MainMenuSceneMainMenuView1Button1Label);
                }
                return _mainMenuSceneMainMenuView1Button1;
            }
        }

        private static Template _mainMenuSceneMainMenuView1Button1Label;
        public static Template MainMenuSceneMainMenuView1Button1Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1Button1Label == null || _mainMenuSceneMainMenuView1Button1Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1Button1Label == null)
#endif
                {
                    _mainMenuSceneMainMenuView1Button1Label = new Template(MainMenuViewTemplates.MainMenuViewButton1Label);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1Button1Label.Name = "MainMenuSceneMainMenuView1Button1Label";
                    _mainMenuSceneMainMenuView1Button1Label.LineNumber = 15;
                    _mainMenuSceneMainMenuView1Button1Label.LinePosition = 4;
#endif
                }
                return _mainMenuSceneMainMenuView1Button1Label;
            }
        }

        private static Template _mainMenuSceneMainMenuView1Button2;
        public static Template MainMenuSceneMainMenuView1Button2
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1Button2 == null || _mainMenuSceneMainMenuView1Button2.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1Button2 == null)
#endif
                {
                    _mainMenuSceneMainMenuView1Button2 = new Template(MainMenuViewTemplates.MainMenuViewButton2);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1Button2.Name = "MainMenuSceneMainMenuView1Button2";
                    _mainMenuSceneMainMenuView1Button2.LineNumber = 8;
                    _mainMenuSceneMainMenuView1Button2.LinePosition = 10;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuSceneMainMenuView1Button2, MainMenuSceneMainMenuView1Button2Label);
                }
                return _mainMenuSceneMainMenuView1Button2;
            }
        }

        private static Template _mainMenuSceneMainMenuView1Button2Label;
        public static Template MainMenuSceneMainMenuView1Button2Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1Button2Label == null || _mainMenuSceneMainMenuView1Button2Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1Button2Label == null)
#endif
                {
                    _mainMenuSceneMainMenuView1Button2Label = new Template(MainMenuViewTemplates.MainMenuViewButton2Label);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1Button2Label.Name = "MainMenuSceneMainMenuView1Button2Label";
                    _mainMenuSceneMainMenuView1Button2Label.LineNumber = 15;
                    _mainMenuSceneMainMenuView1Button2Label.LinePosition = 4;
#endif
                }
                return _mainMenuSceneMainMenuView1Button2Label;
            }
        }

        private static Template _mainMenuSceneMainMenuView1Button3;
        public static Template MainMenuSceneMainMenuView1Button3
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1Button3 == null || _mainMenuSceneMainMenuView1Button3.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1Button3 == null)
#endif
                {
                    _mainMenuSceneMainMenuView1Button3 = new Template(MainMenuViewTemplates.MainMenuViewButton3);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1Button3.Name = "MainMenuSceneMainMenuView1Button3";
                    _mainMenuSceneMainMenuView1Button3.LineNumber = 9;
                    _mainMenuSceneMainMenuView1Button3.LinePosition = 10;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuSceneMainMenuView1Button3, MainMenuSceneMainMenuView1Button3Label);
                }
                return _mainMenuSceneMainMenuView1Button3;
            }
        }

        private static Template _mainMenuSceneMainMenuView1Button3Label;
        public static Template MainMenuSceneMainMenuView1Button3Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1Button3Label == null || _mainMenuSceneMainMenuView1Button3Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1Button3Label == null)
#endif
                {
                    _mainMenuSceneMainMenuView1Button3Label = new Template(MainMenuViewTemplates.MainMenuViewButton3Label);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1Button3Label.Name = "MainMenuSceneMainMenuView1Button3Label";
                    _mainMenuSceneMainMenuView1Button3Label.LineNumber = 15;
                    _mainMenuSceneMainMenuView1Button3Label.LinePosition = 4;
#endif
                }
                return _mainMenuSceneMainMenuView1Button3Label;
            }
        }

        private static Template _mainMenuSceneMainMenuView1PlayWindow;
        public static Template MainMenuSceneMainMenuView1PlayWindow
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1PlayWindow == null || _mainMenuSceneMainMenuView1PlayWindow.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1PlayWindow == null)
#endif
                {
                    _mainMenuSceneMainMenuView1PlayWindow = new Template(MainMenuViewTemplates.MainMenuViewPlayWindow);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1PlayWindow.Name = "MainMenuSceneMainMenuView1PlayWindow";
                    _mainMenuSceneMainMenuView1PlayWindow.LineNumber = 15;
                    _mainMenuSceneMainMenuView1PlayWindow.LinePosition = 6;
#endif
                }
                return _mainMenuSceneMainMenuView1PlayWindow;
            }
        }

        private static Template _mainMenuSceneMainMenuView1Group2;
        public static Template MainMenuSceneMainMenuView1Group2
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1Group2 == null || _mainMenuSceneMainMenuView1Group2.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1Group2 == null)
#endif
                {
                    _mainMenuSceneMainMenuView1Group2 = new Template(MainMenuViewTemplates.MainMenuViewGroup2);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1Group2.Name = "MainMenuSceneMainMenuView1Group2";
                    _mainMenuSceneMainMenuView1Group2.LineNumber = 16;
                    _mainMenuSceneMainMenuView1Group2.LinePosition = 8;
#endif
                }
                return _mainMenuSceneMainMenuView1Group2;
            }
        }

        private static Template _mainMenuSceneMainMenuView1ToggleGroup1;
        public static Template MainMenuSceneMainMenuView1ToggleGroup1
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1ToggleGroup1 == null || _mainMenuSceneMainMenuView1ToggleGroup1.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1ToggleGroup1 == null)
#endif
                {
                    _mainMenuSceneMainMenuView1ToggleGroup1 = new Template(MainMenuViewTemplates.MainMenuViewToggleGroup1);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1ToggleGroup1.Name = "MainMenuSceneMainMenuView1ToggleGroup1";
                    _mainMenuSceneMainMenuView1ToggleGroup1.LineNumber = 17;
                    _mainMenuSceneMainMenuView1ToggleGroup1.LinePosition = 10;
#endif
                }
                return _mainMenuSceneMainMenuView1ToggleGroup1;
            }
        }

        private static Template _mainMenuSceneMainMenuView1Label1;
        public static Template MainMenuSceneMainMenuView1Label1
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1Label1 == null || _mainMenuSceneMainMenuView1Label1.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1Label1 == null)
#endif
                {
                    _mainMenuSceneMainMenuView1Label1 = new Template(MainMenuViewTemplates.MainMenuViewLabel1);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1Label1.Name = "MainMenuSceneMainMenuView1Label1";
                    _mainMenuSceneMainMenuView1Label1.LineNumber = 18;
                    _mainMenuSceneMainMenuView1Label1.LinePosition = 12;
#endif
                }
                return _mainMenuSceneMainMenuView1Label1;
            }
        }

        private static Template _mainMenuSceneMainMenuView1Button4;
        public static Template MainMenuSceneMainMenuView1Button4
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1Button4 == null || _mainMenuSceneMainMenuView1Button4.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1Button4 == null)
#endif
                {
                    _mainMenuSceneMainMenuView1Button4 = new Template(MainMenuViewTemplates.MainMenuViewButton4);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1Button4.Name = "MainMenuSceneMainMenuView1Button4";
                    _mainMenuSceneMainMenuView1Button4.LineNumber = 19;
                    _mainMenuSceneMainMenuView1Button4.LinePosition = 12;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuSceneMainMenuView1Button4, MainMenuSceneMainMenuView1Button4Label);
                }
                return _mainMenuSceneMainMenuView1Button4;
            }
        }

        private static Template _mainMenuSceneMainMenuView1Button4Label;
        public static Template MainMenuSceneMainMenuView1Button4Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1Button4Label == null || _mainMenuSceneMainMenuView1Button4Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1Button4Label == null)
#endif
                {
                    _mainMenuSceneMainMenuView1Button4Label = new Template(MainMenuViewTemplates.MainMenuViewButton4Label);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1Button4Label.Name = "MainMenuSceneMainMenuView1Button4Label";
                    _mainMenuSceneMainMenuView1Button4Label.LineNumber = 15;
                    _mainMenuSceneMainMenuView1Button4Label.LinePosition = 4;
#endif
                }
                return _mainMenuSceneMainMenuView1Button4Label;
            }
        }

        private static Template _mainMenuSceneMainMenuView1Button5;
        public static Template MainMenuSceneMainMenuView1Button5
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1Button5 == null || _mainMenuSceneMainMenuView1Button5.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1Button5 == null)
#endif
                {
                    _mainMenuSceneMainMenuView1Button5 = new Template(MainMenuViewTemplates.MainMenuViewButton5);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1Button5.Name = "MainMenuSceneMainMenuView1Button5";
                    _mainMenuSceneMainMenuView1Button5.LineNumber = 20;
                    _mainMenuSceneMainMenuView1Button5.LinePosition = 12;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuSceneMainMenuView1Button5, MainMenuSceneMainMenuView1Button5Label);
                }
                return _mainMenuSceneMainMenuView1Button5;
            }
        }

        private static Template _mainMenuSceneMainMenuView1Button5Label;
        public static Template MainMenuSceneMainMenuView1Button5Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1Button5Label == null || _mainMenuSceneMainMenuView1Button5Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1Button5Label == null)
#endif
                {
                    _mainMenuSceneMainMenuView1Button5Label = new Template(MainMenuViewTemplates.MainMenuViewButton5Label);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1Button5Label.Name = "MainMenuSceneMainMenuView1Button5Label";
                    _mainMenuSceneMainMenuView1Button5Label.LineNumber = 15;
                    _mainMenuSceneMainMenuView1Button5Label.LinePosition = 4;
#endif
                }
                return _mainMenuSceneMainMenuView1Button5Label;
            }
        }

        private static Template _mainMenuSceneMainMenuView1Button6;
        public static Template MainMenuSceneMainMenuView1Button6
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1Button6 == null || _mainMenuSceneMainMenuView1Button6.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1Button6 == null)
#endif
                {
                    _mainMenuSceneMainMenuView1Button6 = new Template(MainMenuViewTemplates.MainMenuViewButton6);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1Button6.Name = "MainMenuSceneMainMenuView1Button6";
                    _mainMenuSceneMainMenuView1Button6.LineNumber = 21;
                    _mainMenuSceneMainMenuView1Button6.LinePosition = 12;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuSceneMainMenuView1Button6, MainMenuSceneMainMenuView1Button6Label);
                }
                return _mainMenuSceneMainMenuView1Button6;
            }
        }

        private static Template _mainMenuSceneMainMenuView1Button6Label;
        public static Template MainMenuSceneMainMenuView1Button6Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1Button6Label == null || _mainMenuSceneMainMenuView1Button6Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1Button6Label == null)
#endif
                {
                    _mainMenuSceneMainMenuView1Button6Label = new Template(MainMenuViewTemplates.MainMenuViewButton6Label);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1Button6Label.Name = "MainMenuSceneMainMenuView1Button6Label";
                    _mainMenuSceneMainMenuView1Button6Label.LineNumber = 15;
                    _mainMenuSceneMainMenuView1Button6Label.LinePosition = 4;
#endif
                }
                return _mainMenuSceneMainMenuView1Button6Label;
            }
        }

        private static Template _mainMenuSceneMainMenuView1Button7;
        public static Template MainMenuSceneMainMenuView1Button7
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1Button7 == null || _mainMenuSceneMainMenuView1Button7.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1Button7 == null)
#endif
                {
                    _mainMenuSceneMainMenuView1Button7 = new Template(MainMenuViewTemplates.MainMenuViewButton7);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1Button7.Name = "MainMenuSceneMainMenuView1Button7";
                    _mainMenuSceneMainMenuView1Button7.LineNumber = 23;
                    _mainMenuSceneMainMenuView1Button7.LinePosition = 10;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuSceneMainMenuView1Button7, MainMenuSceneMainMenuView1Button7Label);
                }
                return _mainMenuSceneMainMenuView1Button7;
            }
        }

        private static Template _mainMenuSceneMainMenuView1Button7Label;
        public static Template MainMenuSceneMainMenuView1Button7Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1Button7Label == null || _mainMenuSceneMainMenuView1Button7Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1Button7Label == null)
#endif
                {
                    _mainMenuSceneMainMenuView1Button7Label = new Template(MainMenuViewTemplates.MainMenuViewButton7Label);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1Button7Label.Name = "MainMenuSceneMainMenuView1Button7Label";
                    _mainMenuSceneMainMenuView1Button7Label.LineNumber = 15;
                    _mainMenuSceneMainMenuView1Button7Label.LinePosition = 4;
#endif
                }
                return _mainMenuSceneMainMenuView1Button7Label;
            }
        }

        private static Template _mainMenuSceneMainMenuView1Button8;
        public static Template MainMenuSceneMainMenuView1Button8
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1Button8 == null || _mainMenuSceneMainMenuView1Button8.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1Button8 == null)
#endif
                {
                    _mainMenuSceneMainMenuView1Button8 = new Template(MainMenuViewTemplates.MainMenuViewButton8);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1Button8.Name = "MainMenuSceneMainMenuView1Button8";
                    _mainMenuSceneMainMenuView1Button8.LineNumber = 24;
                    _mainMenuSceneMainMenuView1Button8.LinePosition = 10;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuSceneMainMenuView1Button8, MainMenuSceneMainMenuView1Button8Label);
                }
                return _mainMenuSceneMainMenuView1Button8;
            }
        }

        private static Template _mainMenuSceneMainMenuView1Button8Label;
        public static Template MainMenuSceneMainMenuView1Button8Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1Button8Label == null || _mainMenuSceneMainMenuView1Button8Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1Button8Label == null)
#endif
                {
                    _mainMenuSceneMainMenuView1Button8Label = new Template(MainMenuViewTemplates.MainMenuViewButton8Label);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1Button8Label.Name = "MainMenuSceneMainMenuView1Button8Label";
                    _mainMenuSceneMainMenuView1Button8Label.LineNumber = 15;
                    _mainMenuSceneMainMenuView1Button8Label.LinePosition = 4;
#endif
                }
                return _mainMenuSceneMainMenuView1Button8Label;
            }
        }

        private static Template _mainMenuSceneMainMenuView1OptionsWindow;
        public static Template MainMenuSceneMainMenuView1OptionsWindow
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1OptionsWindow == null || _mainMenuSceneMainMenuView1OptionsWindow.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1OptionsWindow == null)
#endif
                {
                    _mainMenuSceneMainMenuView1OptionsWindow = new Template(MainMenuViewTemplates.MainMenuViewOptionsWindow);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1OptionsWindow.Name = "MainMenuSceneMainMenuView1OptionsWindow";
                    _mainMenuSceneMainMenuView1OptionsWindow.LineNumber = 29;
                    _mainMenuSceneMainMenuView1OptionsWindow.LinePosition = 6;
#endif
                }
                return _mainMenuSceneMainMenuView1OptionsWindow;
            }
        }

        private static Template _mainMenuSceneMainMenuView1Button9;
        public static Template MainMenuSceneMainMenuView1Button9
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1Button9 == null || _mainMenuSceneMainMenuView1Button9.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1Button9 == null)
#endif
                {
                    _mainMenuSceneMainMenuView1Button9 = new Template(MainMenuViewTemplates.MainMenuViewButton9);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1Button9.Name = "MainMenuSceneMainMenuView1Button9";
                    _mainMenuSceneMainMenuView1Button9.LineNumber = 30;
                    _mainMenuSceneMainMenuView1Button9.LinePosition = 8;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuSceneMainMenuView1Button9, MainMenuSceneMainMenuView1Button9Label);
                }
                return _mainMenuSceneMainMenuView1Button9;
            }
        }

        private static Template _mainMenuSceneMainMenuView1Button9Label;
        public static Template MainMenuSceneMainMenuView1Button9Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSceneMainMenuView1Button9Label == null || _mainMenuSceneMainMenuView1Button9Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuSceneMainMenuView1Button9Label == null)
#endif
                {
                    _mainMenuSceneMainMenuView1Button9Label = new Template(MainMenuViewTemplates.MainMenuViewButton9Label);
#if UNITY_EDITOR
                    _mainMenuSceneMainMenuView1Button9Label.Name = "MainMenuSceneMainMenuView1Button9Label";
                    _mainMenuSceneMainMenuView1Button9Label.LineNumber = 15;
                    _mainMenuSceneMainMenuView1Button9Label.LinePosition = 4;
#endif
                }
                return _mainMenuSceneMainMenuView1Button9Label;
            }
        }

        #endregion
    }

    #endregion
}
