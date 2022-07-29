// Internal view logic generated from "MainMenu.xml"
#region Using Statements
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
#endregion

namespace Delight
{
    public partial class MainMenu : UIView
    {
        #region Constructors

        public MainMenu(View parent, View layoutParent = null, string id = null, Template template = null, bool deferInitialization = false) :
            base(parent, layoutParent, id, template ?? MainMenuTemplates.Default, deferInitialization)
        {
            if (deferInitialization)
                return;

            // constructing ViewSwitcher (SubmenuSwitcher)
            SubmenuSwitcher = new ViewSwitcher(this, this, "SubmenuSwitcher", SubmenuSwitcherTemplate);
            MainMenuWindow = new Region(this, SubmenuSwitcher.Content, "MainMenuWindow", MainMenuWindowTemplate);
            Image1 = new Image(this, MainMenuWindow.Content, "Image1", Image1Template);
            Label1 = new Label(this, MainMenuWindow.Content, "Label1", Label1Template);
            Group1 = new Group(this, MainMenuWindow.Content, "Group1", Group1Template);
            Button1 = new Button(this, Group1.Content, "Button1", Button1Template);
            Button1.Click.RegisterHandler(this, "Play");
            Button2 = new Button(this, Group1.Content, "Button2", Button2Template);
            Button2.Click.RegisterHandler(this, "ShowOptions");
            Button3 = new Button(this, Group1.Content, "Button3", Button3Template);
            Button3.Click.RegisterHandler(this, "Quit");
            PlayerSelectWindow = new Region(this, SubmenuSwitcher.Content, "PlayerSelectWindow", PlayerSelectWindowTemplate);
            Group2 = new Group(this, PlayerSelectWindow.Content, "Group2", Group2Template);
            Button4 = new Button(this, Group2.Content, "Button4", Button4Template);
            Button4.Click.RegisterHandler(this, "StartGame");
            Button5 = new Button(this, Group2.Content, "Button5", Button5Template);
            Button5.Click.RegisterHandler(this, "NavigateToMainMenu");
            OptionsWindow = new Region(this, SubmenuSwitcher.Content, "OptionsWindow", OptionsWindowTemplate);
            Button6 = new Button(this, OptionsWindow.Content, "Button6", Button6Template);
            Button6.Click.RegisterHandler(this, "NavigateToMainMenu");
            this.AfterInitializeInternal();
        }

        public MainMenu() : this(null)
        {
        }

        static MainMenu()
        {
            var dependencyProperties = new List<DependencyProperty>();
            DependencyProperties.Add(MainMenuTemplates.Default, dependencyProperties);

            dependencyProperties.Add(SubmenuSwitcherProperty);
            dependencyProperties.Add(SubmenuSwitcherTemplateProperty);
            dependencyProperties.Add(MainMenuWindowProperty);
            dependencyProperties.Add(MainMenuWindowTemplateProperty);
            dependencyProperties.Add(Image1Property);
            dependencyProperties.Add(Image1TemplateProperty);
            dependencyProperties.Add(Label1Property);
            dependencyProperties.Add(Label1TemplateProperty);
            dependencyProperties.Add(Group1Property);
            dependencyProperties.Add(Group1TemplateProperty);
            dependencyProperties.Add(Button1Property);
            dependencyProperties.Add(Button1TemplateProperty);
            dependencyProperties.Add(Button2Property);
            dependencyProperties.Add(Button2TemplateProperty);
            dependencyProperties.Add(Button3Property);
            dependencyProperties.Add(Button3TemplateProperty);
            dependencyProperties.Add(PlayerSelectWindowProperty);
            dependencyProperties.Add(PlayerSelectWindowTemplateProperty);
            dependencyProperties.Add(Group2Property);
            dependencyProperties.Add(Group2TemplateProperty);
            dependencyProperties.Add(Button4Property);
            dependencyProperties.Add(Button4TemplateProperty);
            dependencyProperties.Add(Button5Property);
            dependencyProperties.Add(Button5TemplateProperty);
            dependencyProperties.Add(OptionsWindowProperty);
            dependencyProperties.Add(OptionsWindowTemplateProperty);
            dependencyProperties.Add(Button6Property);
            dependencyProperties.Add(Button6TemplateProperty);
        }

        #endregion

        #region Properties

        public readonly static DependencyProperty<ViewSwitcher> SubmenuSwitcherProperty = new DependencyProperty<ViewSwitcher>("SubmenuSwitcher");
        public ViewSwitcher SubmenuSwitcher
        {
            get { return SubmenuSwitcherProperty.GetValue(this); }
            set { SubmenuSwitcherProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> SubmenuSwitcherTemplateProperty = new DependencyProperty<Template>("SubmenuSwitcherTemplate");
        public Template SubmenuSwitcherTemplate
        {
            get { return SubmenuSwitcherTemplateProperty.GetValue(this); }
            set { SubmenuSwitcherTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> MainMenuWindowProperty = new DependencyProperty<Region>("MainMenuWindow");
        public Region MainMenuWindow
        {
            get { return MainMenuWindowProperty.GetValue(this); }
            set { MainMenuWindowProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> MainMenuWindowTemplateProperty = new DependencyProperty<Template>("MainMenuWindowTemplate");
        public Template MainMenuWindowTemplate
        {
            get { return MainMenuWindowTemplateProperty.GetValue(this); }
            set { MainMenuWindowTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Image> Image1Property = new DependencyProperty<Image>("Image1");
        public Image Image1
        {
            get { return Image1Property.GetValue(this); }
            set { Image1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Image1TemplateProperty = new DependencyProperty<Template>("Image1Template");
        public Template Image1Template
        {
            get { return Image1TemplateProperty.GetValue(this); }
            set { Image1TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Label> Label1Property = new DependencyProperty<Label>("Label1");
        public Label Label1
        {
            get { return Label1Property.GetValue(this); }
            set { Label1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Label1TemplateProperty = new DependencyProperty<Template>("Label1Template");
        public Template Label1Template
        {
            get { return Label1TemplateProperty.GetValue(this); }
            set { Label1TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Group> Group1Property = new DependencyProperty<Group>("Group1");
        public Group Group1
        {
            get { return Group1Property.GetValue(this); }
            set { Group1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Group1TemplateProperty = new DependencyProperty<Template>("Group1Template");
        public Template Group1Template
        {
            get { return Group1TemplateProperty.GetValue(this); }
            set { Group1TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Button> Button1Property = new DependencyProperty<Button>("Button1");
        public Button Button1
        {
            get { return Button1Property.GetValue(this); }
            set { Button1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Button1TemplateProperty = new DependencyProperty<Template>("Button1Template");
        public Template Button1Template
        {
            get { return Button1TemplateProperty.GetValue(this); }
            set { Button1TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Button> Button2Property = new DependencyProperty<Button>("Button2");
        public Button Button2
        {
            get { return Button2Property.GetValue(this); }
            set { Button2Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Button2TemplateProperty = new DependencyProperty<Template>("Button2Template");
        public Template Button2Template
        {
            get { return Button2TemplateProperty.GetValue(this); }
            set { Button2TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Button> Button3Property = new DependencyProperty<Button>("Button3");
        public Button Button3
        {
            get { return Button3Property.GetValue(this); }
            set { Button3Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Button3TemplateProperty = new DependencyProperty<Template>("Button3Template");
        public Template Button3Template
        {
            get { return Button3TemplateProperty.GetValue(this); }
            set { Button3TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> PlayerSelectWindowProperty = new DependencyProperty<Region>("PlayerSelectWindow");
        public Region PlayerSelectWindow
        {
            get { return PlayerSelectWindowProperty.GetValue(this); }
            set { PlayerSelectWindowProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> PlayerSelectWindowTemplateProperty = new DependencyProperty<Template>("PlayerSelectWindowTemplate");
        public Template PlayerSelectWindowTemplate
        {
            get { return PlayerSelectWindowTemplateProperty.GetValue(this); }
            set { PlayerSelectWindowTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Group> Group2Property = new DependencyProperty<Group>("Group2");
        public Group Group2
        {
            get { return Group2Property.GetValue(this); }
            set { Group2Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Group2TemplateProperty = new DependencyProperty<Template>("Group2Template");
        public Template Group2Template
        {
            get { return Group2TemplateProperty.GetValue(this); }
            set { Group2TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Button> Button4Property = new DependencyProperty<Button>("Button4");
        public Button Button4
        {
            get { return Button4Property.GetValue(this); }
            set { Button4Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Button4TemplateProperty = new DependencyProperty<Template>("Button4Template");
        public Template Button4Template
        {
            get { return Button4TemplateProperty.GetValue(this); }
            set { Button4TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Button> Button5Property = new DependencyProperty<Button>("Button5");
        public Button Button5
        {
            get { return Button5Property.GetValue(this); }
            set { Button5Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Button5TemplateProperty = new DependencyProperty<Template>("Button5Template");
        public Template Button5Template
        {
            get { return Button5TemplateProperty.GetValue(this); }
            set { Button5TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Region> OptionsWindowProperty = new DependencyProperty<Region>("OptionsWindow");
        public Region OptionsWindow
        {
            get { return OptionsWindowProperty.GetValue(this); }
            set { OptionsWindowProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> OptionsWindowTemplateProperty = new DependencyProperty<Template>("OptionsWindowTemplate");
        public Template OptionsWindowTemplate
        {
            get { return OptionsWindowTemplateProperty.GetValue(this); }
            set { OptionsWindowTemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Button> Button6Property = new DependencyProperty<Button>("Button6");
        public Button Button6
        {
            get { return Button6Property.GetValue(this); }
            set { Button6Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Button6TemplateProperty = new DependencyProperty<Template>("Button6Template");
        public Template Button6Template
        {
            get { return Button6TemplateProperty.GetValue(this); }
            set { Button6TemplateProperty.SetValue(this, value); }
        }

        #endregion
    }

    #region Data Templates

    public static class MainMenuTemplates
    {
        #region Properties

        public static Template Default
        {
            get
            {
                return MainMenu;
            }
        }

        private static Template _mainMenu;
        public static Template MainMenu
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenu == null || _mainMenu.CurrentVersion != Template.Version)
#else
                if (_mainMenu == null)
#endif
                {
                    _mainMenu = new Template(UIViewTemplates.UIView);
#if UNITY_EDITOR
                    _mainMenu.Name = "MainMenu";
                    _mainMenu.LineNumber = 0;
                    _mainMenu.LinePosition = 0;
#endif
                    Delight.MainMenu.SubmenuSwitcherTemplateProperty.SetDefault(_mainMenu, MainMenuSubmenuSwitcher);
                    Delight.MainMenu.MainMenuWindowTemplateProperty.SetDefault(_mainMenu, MainMenuMainMenuWindow);
                    Delight.MainMenu.Image1TemplateProperty.SetDefault(_mainMenu, MainMenuImage1);
                    Delight.MainMenu.Label1TemplateProperty.SetDefault(_mainMenu, MainMenuLabel1);
                    Delight.MainMenu.Group1TemplateProperty.SetDefault(_mainMenu, MainMenuGroup1);
                    Delight.MainMenu.Button1TemplateProperty.SetDefault(_mainMenu, MainMenuButton1);
                    Delight.MainMenu.Button2TemplateProperty.SetDefault(_mainMenu, MainMenuButton2);
                    Delight.MainMenu.Button3TemplateProperty.SetDefault(_mainMenu, MainMenuButton3);
                    Delight.MainMenu.PlayerSelectWindowTemplateProperty.SetDefault(_mainMenu, MainMenuPlayerSelectWindow);
                    Delight.MainMenu.Group2TemplateProperty.SetDefault(_mainMenu, MainMenuGroup2);
                    Delight.MainMenu.Button4TemplateProperty.SetDefault(_mainMenu, MainMenuButton4);
                    Delight.MainMenu.Button5TemplateProperty.SetDefault(_mainMenu, MainMenuButton5);
                    Delight.MainMenu.OptionsWindowTemplateProperty.SetDefault(_mainMenu, MainMenuOptionsWindow);
                    Delight.MainMenu.Button6TemplateProperty.SetDefault(_mainMenu, MainMenuButton6);
                }
                return _mainMenu;
            }
        }

        private static Template _mainMenuSubmenuSwitcher;
        public static Template MainMenuSubmenuSwitcher
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuSubmenuSwitcher == null || _mainMenuSubmenuSwitcher.CurrentVersion != Template.Version)
#else
                if (_mainMenuSubmenuSwitcher == null)
#endif
                {
                    _mainMenuSubmenuSwitcher = new Template(ViewSwitcherTemplates.ViewSwitcher);
#if UNITY_EDITOR
                    _mainMenuSubmenuSwitcher.Name = "MainMenuSubmenuSwitcher";
                    _mainMenuSubmenuSwitcher.LineNumber = 2;
                    _mainMenuSubmenuSwitcher.LinePosition = 4;
#endif
                }
                return _mainMenuSubmenuSwitcher;
            }
        }

        private static Template _mainMenuMainMenuWindow;
        public static Template MainMenuMainMenuWindow
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuMainMenuWindow == null || _mainMenuMainMenuWindow.CurrentVersion != Template.Version)
#else
                if (_mainMenuMainMenuWindow == null)
#endif
                {
                    _mainMenuMainMenuWindow = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _mainMenuMainMenuWindow.Name = "MainMenuMainMenuWindow";
                    _mainMenuMainMenuWindow.LineNumber = 5;
                    _mainMenuMainMenuWindow.LinePosition = 6;
#endif
                }
                return _mainMenuMainMenuWindow;
            }
        }

        private static Template _mainMenuImage1;
        public static Template MainMenuImage1
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuImage1 == null || _mainMenuImage1.CurrentVersion != Template.Version)
#else
                if (_mainMenuImage1 == null)
#endif
                {
                    _mainMenuImage1 = new Template(ImageTemplates.Image);
#if UNITY_EDITOR
                    _mainMenuImage1.Name = "MainMenuImage1";
                    _mainMenuImage1.LineNumber = 6;
                    _mainMenuImage1.LinePosition = 8;
#endif
                    Delight.Image.SpriteProperty.SetDefault(_mainMenuImage1, Assets.Sprites["MainMenuDemoBg"]);
                    Delight.Image.HeightProperty.SetDefault(_mainMenuImage1, new ElementSize(480f, ElementSizeUnit.Pixels));
                    Delight.Image.PreserveAspectProperty.SetDefault(_mainMenuImage1, true);
                }
                return _mainMenuImage1;
            }
        }

        private static Template _mainMenuLabel1;
        public static Template MainMenuLabel1
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuLabel1 == null || _mainMenuLabel1.CurrentVersion != Template.Version)
#else
                if (_mainMenuLabel1 == null)
#endif
                {
                    _mainMenuLabel1 = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _mainMenuLabel1.Name = "MainMenuLabel1";
                    _mainMenuLabel1.LineNumber = 7;
                    _mainMenuLabel1.LinePosition = 8;
#endif
                    Delight.Label.FontColorProperty.SetDefault(_mainMenuLabel1, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Label.FontSizeProperty.SetDefault(_mainMenuLabel1, 40);
                    Delight.Label.FontProperty.SetDefault(_mainMenuLabel1, Assets.Fonts["AveriaSansLibre-Bold SDF"]);
                    Delight.Label.AutoSizeProperty.SetDefault(_mainMenuLabel1, Delight.AutoSize.Default);
                    Delight.Label.TextProperty.SetDefault(_mainMenuLabel1, "Main Menu");
                    Delight.Label.OffsetProperty.SetDefault(_mainMenuLabel1, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(210f, ElementSizeUnit.Pixels)));
                }
                return _mainMenuLabel1;
            }
        }

        private static Template _mainMenuGroup1;
        public static Template MainMenuGroup1
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuGroup1 == null || _mainMenuGroup1.CurrentVersion != Template.Version)
#else
                if (_mainMenuGroup1 == null)
#endif
                {
                    _mainMenuGroup1 = new Template(GroupTemplates.Group);
#if UNITY_EDITOR
                    _mainMenuGroup1.Name = "MainMenuGroup1";
                    _mainMenuGroup1.LineNumber = 8;
                    _mainMenuGroup1.LinePosition = 8;
#endif
                    Delight.Group.SpacingProperty.SetDefault(_mainMenuGroup1, new ElementSize(10f, ElementSizeUnit.Pixels));
                    Delight.Group.OffsetProperty.SetDefault(_mainMenuGroup1, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(25f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                }
                return _mainMenuGroup1;
            }
        }

        private static Template _mainMenuButton1;
        public static Template MainMenuButton1
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuButton1 == null || _mainMenuButton1.CurrentVersion != Template.Version)
#else
                if (_mainMenuButton1 == null)
#endif
                {
                    _mainMenuButton1 = new Template(ButtonTemplates.Button);
#if UNITY_EDITOR
                    _mainMenuButton1.Name = "MainMenuButton1";
                    _mainMenuButton1.LineNumber = 9;
                    _mainMenuButton1.LinePosition = 10;
#endif
                    Delight.Button.BackgroundSpriteProperty.SetDefault(_mainMenuButton1, Assets.Sprites["MainMenuDemoButton"]);
                    Delight.Button.BackgroundSpriteProperty.SetStateDefault("Pressed", _mainMenuButton1, Assets.Sprites["MainMenuDemoButtonPressed"]);
                    Delight.Button.BackgroundColorProperty.SetDefault(_mainMenuButton1, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Button.BackgroundColorProperty.SetStateDefault("Highlighted", _mainMenuButton1, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Button.BackgroundColorProperty.SetStateDefault("Pressed", _mainMenuButton1, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Button.WidthProperty.SetDefault(_mainMenuButton1, new ElementSize(218f, ElementSizeUnit.Pixels));
                    Delight.Button.HeightProperty.SetDefault(_mainMenuButton1, new ElementSize(117f, ElementSizeUnit.Pixels));
                    Delight.Button.TextOffsetProperty.SetDefault(_mainMenuButton1, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(6f, ElementSizeUnit.Pixels)));
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuButton1, MainMenuButton1Label);
                }
                return _mainMenuButton1;
            }
        }

        private static Template _mainMenuButton1Label;
        public static Template MainMenuButton1Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuButton1Label == null || _mainMenuButton1Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuButton1Label == null)
#endif
                {
                    _mainMenuButton1Label = new Template(ButtonTemplates.ButtonLabel);
#if UNITY_EDITOR
                    _mainMenuButton1Label.Name = "MainMenuButton1Label";
                    _mainMenuButton1Label.LineNumber = 15;
                    _mainMenuButton1Label.LinePosition = 4;
#endif
                    Delight.Label.FontSizeProperty.SetDefault(_mainMenuButton1Label, 40);
                    Delight.Label.FontProperty.SetDefault(_mainMenuButton1Label, Assets.Fonts["AveriaSansLibre-Bold SDF"]);
                    Delight.Label.FontColorProperty.SetDefault(_mainMenuButton1Label, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Label.FontColorProperty.SetStateDefault("Highlighted", _mainMenuButton1Label, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Label.FontColorProperty.SetStateDefault("Pressed", _mainMenuButton1Label, new UnityEngine.Color(0.8f, 0.8f, 0.8f, 1f));
                    Delight.Label.TextProperty.SetDefault(_mainMenuButton1Label, "Play");
                }
                return _mainMenuButton1Label;
            }
        }

        private static Template _mainMenuButton2;
        public static Template MainMenuButton2
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuButton2 == null || _mainMenuButton2.CurrentVersion != Template.Version)
#else
                if (_mainMenuButton2 == null)
#endif
                {
                    _mainMenuButton2 = new Template(ButtonTemplates.Button);
#if UNITY_EDITOR
                    _mainMenuButton2.Name = "MainMenuButton2";
                    _mainMenuButton2.LineNumber = 10;
                    _mainMenuButton2.LinePosition = 10;
#endif
                    Delight.Button.BackgroundSpriteProperty.SetDefault(_mainMenuButton2, Assets.Sprites["MainMenuDemoButton"]);
                    Delight.Button.BackgroundSpriteProperty.SetStateDefault("Pressed", _mainMenuButton2, Assets.Sprites["MainMenuDemoButtonPressed"]);
                    Delight.Button.BackgroundColorProperty.SetDefault(_mainMenuButton2, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Button.BackgroundColorProperty.SetStateDefault("Highlighted", _mainMenuButton2, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Button.BackgroundColorProperty.SetStateDefault("Pressed", _mainMenuButton2, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Button.WidthProperty.SetDefault(_mainMenuButton2, new ElementSize(218f, ElementSizeUnit.Pixels));
                    Delight.Button.HeightProperty.SetDefault(_mainMenuButton2, new ElementSize(117f, ElementSizeUnit.Pixels));
                    Delight.Button.TextOffsetProperty.SetDefault(_mainMenuButton2, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(6f, ElementSizeUnit.Pixels)));
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuButton2, MainMenuButton2Label);
                }
                return _mainMenuButton2;
            }
        }

        private static Template _mainMenuButton2Label;
        public static Template MainMenuButton2Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuButton2Label == null || _mainMenuButton2Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuButton2Label == null)
#endif
                {
                    _mainMenuButton2Label = new Template(ButtonTemplates.ButtonLabel);
#if UNITY_EDITOR
                    _mainMenuButton2Label.Name = "MainMenuButton2Label";
                    _mainMenuButton2Label.LineNumber = 15;
                    _mainMenuButton2Label.LinePosition = 4;
#endif
                    Delight.Label.FontSizeProperty.SetDefault(_mainMenuButton2Label, 40);
                    Delight.Label.FontProperty.SetDefault(_mainMenuButton2Label, Assets.Fonts["AveriaSansLibre-Bold SDF"]);
                    Delight.Label.FontColorProperty.SetDefault(_mainMenuButton2Label, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Label.FontColorProperty.SetStateDefault("Highlighted", _mainMenuButton2Label, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Label.FontColorProperty.SetStateDefault("Pressed", _mainMenuButton2Label, new UnityEngine.Color(0.8f, 0.8f, 0.8f, 1f));
                    Delight.Label.TextProperty.SetDefault(_mainMenuButton2Label, "Options");
                }
                return _mainMenuButton2Label;
            }
        }

        private static Template _mainMenuButton3;
        public static Template MainMenuButton3
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuButton3 == null || _mainMenuButton3.CurrentVersion != Template.Version)
#else
                if (_mainMenuButton3 == null)
#endif
                {
                    _mainMenuButton3 = new Template(ButtonTemplates.Button);
#if UNITY_EDITOR
                    _mainMenuButton3.Name = "MainMenuButton3";
                    _mainMenuButton3.LineNumber = 11;
                    _mainMenuButton3.LinePosition = 10;
#endif
                    Delight.Button.BackgroundSpriteProperty.SetDefault(_mainMenuButton3, Assets.Sprites["MainMenuDemoButton"]);
                    Delight.Button.BackgroundSpriteProperty.SetStateDefault("Pressed", _mainMenuButton3, Assets.Sprites["MainMenuDemoButtonPressed"]);
                    Delight.Button.BackgroundColorProperty.SetDefault(_mainMenuButton3, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Button.BackgroundColorProperty.SetStateDefault("Highlighted", _mainMenuButton3, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Button.BackgroundColorProperty.SetStateDefault("Pressed", _mainMenuButton3, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Button.WidthProperty.SetDefault(_mainMenuButton3, new ElementSize(218f, ElementSizeUnit.Pixels));
                    Delight.Button.HeightProperty.SetDefault(_mainMenuButton3, new ElementSize(117f, ElementSizeUnit.Pixels));
                    Delight.Button.TextOffsetProperty.SetDefault(_mainMenuButton3, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(6f, ElementSizeUnit.Pixels)));
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuButton3, MainMenuButton3Label);
                }
                return _mainMenuButton3;
            }
        }

        private static Template _mainMenuButton3Label;
        public static Template MainMenuButton3Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuButton3Label == null || _mainMenuButton3Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuButton3Label == null)
#endif
                {
                    _mainMenuButton3Label = new Template(ButtonTemplates.ButtonLabel);
#if UNITY_EDITOR
                    _mainMenuButton3Label.Name = "MainMenuButton3Label";
                    _mainMenuButton3Label.LineNumber = 15;
                    _mainMenuButton3Label.LinePosition = 4;
#endif
                    Delight.Label.FontSizeProperty.SetDefault(_mainMenuButton3Label, 40);
                    Delight.Label.FontProperty.SetDefault(_mainMenuButton3Label, Assets.Fonts["AveriaSansLibre-Bold SDF"]);
                    Delight.Label.FontColorProperty.SetDefault(_mainMenuButton3Label, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Label.FontColorProperty.SetStateDefault("Highlighted", _mainMenuButton3Label, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Label.FontColorProperty.SetStateDefault("Pressed", _mainMenuButton3Label, new UnityEngine.Color(0.8f, 0.8f, 0.8f, 1f));
                    Delight.Label.TextProperty.SetDefault(_mainMenuButton3Label, "Quit");
                }
                return _mainMenuButton3Label;
            }
        }

        private static Template _mainMenuPlayerSelectWindow;
        public static Template MainMenuPlayerSelectWindow
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuPlayerSelectWindow == null || _mainMenuPlayerSelectWindow.CurrentVersion != Template.Version)
#else
                if (_mainMenuPlayerSelectWindow == null)
#endif
                {
                    _mainMenuPlayerSelectWindow = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _mainMenuPlayerSelectWindow.Name = "MainMenuPlayerSelectWindow";
                    _mainMenuPlayerSelectWindow.LineNumber = 16;
                    _mainMenuPlayerSelectWindow.LinePosition = 6;
#endif
                }
                return _mainMenuPlayerSelectWindow;
            }
        }

        private static Template _mainMenuGroup2;
        public static Template MainMenuGroup2
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuGroup2 == null || _mainMenuGroup2.CurrentVersion != Template.Version)
#else
                if (_mainMenuGroup2 == null)
#endif
                {
                    _mainMenuGroup2 = new Template(GroupTemplates.Group);
#if UNITY_EDITOR
                    _mainMenuGroup2.Name = "MainMenuGroup2";
                    _mainMenuGroup2.LineNumber = 17;
                    _mainMenuGroup2.LinePosition = 8;
#endif
                    Delight.Group.SpacingProperty.SetDefault(_mainMenuGroup2, new ElementSize(10f, ElementSizeUnit.Pixels));
                }
                return _mainMenuGroup2;
            }
        }

        private static Template _mainMenuButton4;
        public static Template MainMenuButton4
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuButton4 == null || _mainMenuButton4.CurrentVersion != Template.Version)
#else
                if (_mainMenuButton4 == null)
#endif
                {
                    _mainMenuButton4 = new Template(ButtonTemplates.Button);
#if UNITY_EDITOR
                    _mainMenuButton4.Name = "MainMenuButton4";
                    _mainMenuButton4.LineNumber = 18;
                    _mainMenuButton4.LinePosition = 10;
#endif
                    Delight.Button.BackgroundSpriteProperty.SetDefault(_mainMenuButton4, Assets.Sprites["MainMenuDemoButton"]);
                    Delight.Button.BackgroundSpriteProperty.SetStateDefault("Pressed", _mainMenuButton4, Assets.Sprites["MainMenuDemoButtonPressed"]);
                    Delight.Button.BackgroundColorProperty.SetDefault(_mainMenuButton4, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Button.BackgroundColorProperty.SetStateDefault("Highlighted", _mainMenuButton4, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Button.BackgroundColorProperty.SetStateDefault("Pressed", _mainMenuButton4, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Button.WidthProperty.SetDefault(_mainMenuButton4, new ElementSize(218f, ElementSizeUnit.Pixels));
                    Delight.Button.HeightProperty.SetDefault(_mainMenuButton4, new ElementSize(117f, ElementSizeUnit.Pixels));
                    Delight.Button.TextOffsetProperty.SetDefault(_mainMenuButton4, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(6f, ElementSizeUnit.Pixels)));
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuButton4, MainMenuButton4Label);
                }
                return _mainMenuButton4;
            }
        }

        private static Template _mainMenuButton4Label;
        public static Template MainMenuButton4Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuButton4Label == null || _mainMenuButton4Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuButton4Label == null)
#endif
                {
                    _mainMenuButton4Label = new Template(ButtonTemplates.ButtonLabel);
#if UNITY_EDITOR
                    _mainMenuButton4Label.Name = "MainMenuButton4Label";
                    _mainMenuButton4Label.LineNumber = 15;
                    _mainMenuButton4Label.LinePosition = 4;
#endif
                    Delight.Label.FontSizeProperty.SetDefault(_mainMenuButton4Label, 40);
                    Delight.Label.FontProperty.SetDefault(_mainMenuButton4Label, Assets.Fonts["AveriaSansLibre-Bold SDF"]);
                    Delight.Label.FontColorProperty.SetDefault(_mainMenuButton4Label, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Label.FontColorProperty.SetStateDefault("Highlighted", _mainMenuButton4Label, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Label.FontColorProperty.SetStateDefault("Pressed", _mainMenuButton4Label, new UnityEngine.Color(0.8f, 0.8f, 0.8f, 1f));
                    Delight.Label.TextProperty.SetDefault(_mainMenuButton4Label, "Start");
                }
                return _mainMenuButton4Label;
            }
        }

        private static Template _mainMenuButton5;
        public static Template MainMenuButton5
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuButton5 == null || _mainMenuButton5.CurrentVersion != Template.Version)
#else
                if (_mainMenuButton5 == null)
#endif
                {
                    _mainMenuButton5 = new Template(ButtonTemplates.Button);
#if UNITY_EDITOR
                    _mainMenuButton5.Name = "MainMenuButton5";
                    _mainMenuButton5.LineNumber = 19;
                    _mainMenuButton5.LinePosition = 10;
#endif
                    Delight.Button.BackgroundSpriteProperty.SetDefault(_mainMenuButton5, Assets.Sprites["MainMenuDemoButton"]);
                    Delight.Button.BackgroundSpriteProperty.SetStateDefault("Pressed", _mainMenuButton5, Assets.Sprites["MainMenuDemoButtonPressed"]);
                    Delight.Button.BackgroundColorProperty.SetDefault(_mainMenuButton5, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Button.BackgroundColorProperty.SetStateDefault("Highlighted", _mainMenuButton5, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Button.BackgroundColorProperty.SetStateDefault("Pressed", _mainMenuButton5, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Button.WidthProperty.SetDefault(_mainMenuButton5, new ElementSize(218f, ElementSizeUnit.Pixels));
                    Delight.Button.HeightProperty.SetDefault(_mainMenuButton5, new ElementSize(117f, ElementSizeUnit.Pixels));
                    Delight.Button.TextOffsetProperty.SetDefault(_mainMenuButton5, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(6f, ElementSizeUnit.Pixels)));
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuButton5, MainMenuButton5Label);
                }
                return _mainMenuButton5;
            }
        }

        private static Template _mainMenuButton5Label;
        public static Template MainMenuButton5Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuButton5Label == null || _mainMenuButton5Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuButton5Label == null)
#endif
                {
                    _mainMenuButton5Label = new Template(ButtonTemplates.ButtonLabel);
#if UNITY_EDITOR
                    _mainMenuButton5Label.Name = "MainMenuButton5Label";
                    _mainMenuButton5Label.LineNumber = 15;
                    _mainMenuButton5Label.LinePosition = 4;
#endif
                    Delight.Label.FontSizeProperty.SetDefault(_mainMenuButton5Label, 40);
                    Delight.Label.FontProperty.SetDefault(_mainMenuButton5Label, Assets.Fonts["AveriaSansLibre-Bold SDF"]);
                    Delight.Label.FontColorProperty.SetDefault(_mainMenuButton5Label, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Label.FontColorProperty.SetStateDefault("Highlighted", _mainMenuButton5Label, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Label.FontColorProperty.SetStateDefault("Pressed", _mainMenuButton5Label, new UnityEngine.Color(0.8f, 0.8f, 0.8f, 1f));
                    Delight.Label.TextProperty.SetDefault(_mainMenuButton5Label, "Back");
                }
                return _mainMenuButton5Label;
            }
        }

        private static Template _mainMenuOptionsWindow;
        public static Template MainMenuOptionsWindow
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuOptionsWindow == null || _mainMenuOptionsWindow.CurrentVersion != Template.Version)
#else
                if (_mainMenuOptionsWindow == null)
#endif
                {
                    _mainMenuOptionsWindow = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _mainMenuOptionsWindow.Name = "MainMenuOptionsWindow";
                    _mainMenuOptionsWindow.LineNumber = 24;
                    _mainMenuOptionsWindow.LinePosition = 6;
#endif
                }
                return _mainMenuOptionsWindow;
            }
        }

        private static Template _mainMenuButton6;
        public static Template MainMenuButton6
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuButton6 == null || _mainMenuButton6.CurrentVersion != Template.Version)
#else
                if (_mainMenuButton6 == null)
#endif
                {
                    _mainMenuButton6 = new Template(ButtonTemplates.Button);
#if UNITY_EDITOR
                    _mainMenuButton6.Name = "MainMenuButton6";
                    _mainMenuButton6.LineNumber = 25;
                    _mainMenuButton6.LinePosition = 8;
#endif
                    Delight.Button.BackgroundSpriteProperty.SetDefault(_mainMenuButton6, Assets.Sprites["MainMenuDemoButton"]);
                    Delight.Button.BackgroundSpriteProperty.SetStateDefault("Pressed", _mainMenuButton6, Assets.Sprites["MainMenuDemoButtonPressed"]);
                    Delight.Button.BackgroundColorProperty.SetDefault(_mainMenuButton6, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Button.BackgroundColorProperty.SetStateDefault("Highlighted", _mainMenuButton6, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Button.BackgroundColorProperty.SetStateDefault("Pressed", _mainMenuButton6, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Button.WidthProperty.SetDefault(_mainMenuButton6, new ElementSize(218f, ElementSizeUnit.Pixels));
                    Delight.Button.HeightProperty.SetDefault(_mainMenuButton6, new ElementSize(117f, ElementSizeUnit.Pixels));
                    Delight.Button.TextOffsetProperty.SetDefault(_mainMenuButton6, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(6f, ElementSizeUnit.Pixels)));
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuButton6, MainMenuButton6Label);
                }
                return _mainMenuButton6;
            }
        }

        private static Template _mainMenuButton6Label;
        public static Template MainMenuButton6Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuButton6Label == null || _mainMenuButton6Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuButton6Label == null)
#endif
                {
                    _mainMenuButton6Label = new Template(ButtonTemplates.ButtonLabel);
#if UNITY_EDITOR
                    _mainMenuButton6Label.Name = "MainMenuButton6Label";
                    _mainMenuButton6Label.LineNumber = 15;
                    _mainMenuButton6Label.LinePosition = 4;
#endif
                    Delight.Label.FontSizeProperty.SetDefault(_mainMenuButton6Label, 40);
                    Delight.Label.FontProperty.SetDefault(_mainMenuButton6Label, Assets.Fonts["AveriaSansLibre-Bold SDF"]);
                    Delight.Label.FontColorProperty.SetDefault(_mainMenuButton6Label, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Label.FontColorProperty.SetStateDefault("Highlighted", _mainMenuButton6Label, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Label.FontColorProperty.SetStateDefault("Pressed", _mainMenuButton6Label, new UnityEngine.Color(0.8f, 0.8f, 0.8f, 1f));
                    Delight.Label.TextProperty.SetDefault(_mainMenuButton6Label, "Back");
                }
                return _mainMenuButton6Label;
            }
        }

        #endregion
    }

    #endregion
}
