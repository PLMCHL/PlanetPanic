// Internal view logic generated from "MainMenuView.xml"
#region Using Statements
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
#endregion

namespace Delight
{
    public partial class MainMenuView : UIView
    {
        #region Constructors

        public MainMenuView(View parent, View layoutParent = null, string id = null, Template template = null, bool deferInitialization = false) :
            base(parent, layoutParent, id, template ?? MainMenuViewTemplates.Default, deferInitialization)
        {
            if (deferInitialization)
                return;

            // constructing ViewSwitcher (SubmenuSwitcher)
            SubmenuSwitcher = new ViewSwitcher(this, this, "SubmenuSwitcher", SubmenuSwitcherTemplate);
            MainMenuWindow = new Region(this, SubmenuSwitcher.Content, "MainMenuWindow", MainMenuWindowTemplate);
            Group1 = new Group(this, MainMenuWindow.Content, "Group1", Group1Template);
            Button1 = new Button(this, Group1.Content, "Button1", Button1Template);
            Button1.Click.RegisterHandler(this, "Play");
            Button2 = new Button(this, Group1.Content, "Button2", Button2Template);
            Button2.Click.RegisterHandler(this, "ShowOptions");
            Button3 = new Button(this, Group1.Content, "Button3", Button3Template);
            Button3.Click.RegisterHandler(this, "Quit");
            PlayWindow = new Region(this, SubmenuSwitcher.Content, "PlayWindow", PlayWindowTemplate);
            Group2 = new Group(this, PlayWindow.Content, "Group2", Group2Template);
            ToggleGroup1 = new ToggleGroup(this, Group2.Content, "ToggleGroup1", ToggleGroup1Template);
            Label1 = new Label(this, ToggleGroup1.Content, "Label1", Label1Template);
            Button4 = new Button(this, ToggleGroup1.Content, "Button4", Button4Template);
            Button4.Click.RegisterHandler(() => @PlayerCount = 2);
            Button5 = new Button(this, ToggleGroup1.Content, "Button5", Button5Template);
            Button5.Click.RegisterHandler(() => @PlayerCount = 3);
            Button6 = new Button(this, ToggleGroup1.Content, "Button6", Button6Template);
            Button6.Click.RegisterHandler(() => @PlayerCount = 4);
            Button7 = new Button(this, Group2.Content, "Button7", Button7Template);
            Button7.Click.RegisterHandler(this, "StartGame");
            Button8 = new Button(this, Group2.Content, "Button8", Button8Template);
            Button8.Click.RegisterHandler(this, "NavigateToMainMenu");
            OptionsWindow = new Region(this, SubmenuSwitcher.Content, "OptionsWindow", OptionsWindowTemplate);
            Button9 = new Button(this, OptionsWindow.Content, "Button9", Button9Template);
            Button9.Click.RegisterHandler(this, "NavigateToMainMenu");
            this.AfterInitializeInternal();
        }

        public MainMenuView() : this(null)
        {
        }

        static MainMenuView()
        {
            var dependencyProperties = new List<DependencyProperty>();
            DependencyProperties.Add(MainMenuViewTemplates.Default, dependencyProperties);

            dependencyProperties.Add(SubmenuSwitcherProperty);
            dependencyProperties.Add(SubmenuSwitcherTemplateProperty);
            dependencyProperties.Add(MainMenuWindowProperty);
            dependencyProperties.Add(MainMenuWindowTemplateProperty);
            dependencyProperties.Add(Group1Property);
            dependencyProperties.Add(Group1TemplateProperty);
            dependencyProperties.Add(Button1Property);
            dependencyProperties.Add(Button1TemplateProperty);
            dependencyProperties.Add(Button2Property);
            dependencyProperties.Add(Button2TemplateProperty);
            dependencyProperties.Add(Button3Property);
            dependencyProperties.Add(Button3TemplateProperty);
            dependencyProperties.Add(PlayWindowProperty);
            dependencyProperties.Add(PlayWindowTemplateProperty);
            dependencyProperties.Add(Group2Property);
            dependencyProperties.Add(Group2TemplateProperty);
            dependencyProperties.Add(ToggleGroup1Property);
            dependencyProperties.Add(ToggleGroup1TemplateProperty);
            dependencyProperties.Add(Label1Property);
            dependencyProperties.Add(Label1TemplateProperty);
            dependencyProperties.Add(Button4Property);
            dependencyProperties.Add(Button4TemplateProperty);
            dependencyProperties.Add(Button5Property);
            dependencyProperties.Add(Button5TemplateProperty);
            dependencyProperties.Add(Button6Property);
            dependencyProperties.Add(Button6TemplateProperty);
            dependencyProperties.Add(Button7Property);
            dependencyProperties.Add(Button7TemplateProperty);
            dependencyProperties.Add(Button8Property);
            dependencyProperties.Add(Button8TemplateProperty);
            dependencyProperties.Add(OptionsWindowProperty);
            dependencyProperties.Add(OptionsWindowTemplateProperty);
            dependencyProperties.Add(Button9Property);
            dependencyProperties.Add(Button9TemplateProperty);
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

        public readonly static DependencyProperty<Region> PlayWindowProperty = new DependencyProperty<Region>("PlayWindow");
        public Region PlayWindow
        {
            get { return PlayWindowProperty.GetValue(this); }
            set { PlayWindowProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> PlayWindowTemplateProperty = new DependencyProperty<Template>("PlayWindowTemplate");
        public Template PlayWindowTemplate
        {
            get { return PlayWindowTemplateProperty.GetValue(this); }
            set { PlayWindowTemplateProperty.SetValue(this, value); }
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

        public readonly static DependencyProperty<ToggleGroup> ToggleGroup1Property = new DependencyProperty<ToggleGroup>("ToggleGroup1");
        public ToggleGroup ToggleGroup1
        {
            get { return ToggleGroup1Property.GetValue(this); }
            set { ToggleGroup1Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> ToggleGroup1TemplateProperty = new DependencyProperty<Template>("ToggleGroup1Template");
        public Template ToggleGroup1Template
        {
            get { return ToggleGroup1TemplateProperty.GetValue(this); }
            set { ToggleGroup1TemplateProperty.SetValue(this, value); }
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

        public readonly static DependencyProperty<Button> Button7Property = new DependencyProperty<Button>("Button7");
        public Button Button7
        {
            get { return Button7Property.GetValue(this); }
            set { Button7Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Button7TemplateProperty = new DependencyProperty<Template>("Button7Template");
        public Template Button7Template
        {
            get { return Button7TemplateProperty.GetValue(this); }
            set { Button7TemplateProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Button> Button8Property = new DependencyProperty<Button>("Button8");
        public Button Button8
        {
            get { return Button8Property.GetValue(this); }
            set { Button8Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Button8TemplateProperty = new DependencyProperty<Template>("Button8Template");
        public Template Button8Template
        {
            get { return Button8TemplateProperty.GetValue(this); }
            set { Button8TemplateProperty.SetValue(this, value); }
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

        public readonly static DependencyProperty<Button> Button9Property = new DependencyProperty<Button>("Button9");
        public Button Button9
        {
            get { return Button9Property.GetValue(this); }
            set { Button9Property.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Template> Button9TemplateProperty = new DependencyProperty<Template>("Button9Template");
        public Template Button9Template
        {
            get { return Button9TemplateProperty.GetValue(this); }
            set { Button9TemplateProperty.SetValue(this, value); }
        }

        #endregion
    }

    #region Data Templates

    public static class MainMenuViewTemplates
    {
        #region Properties

        public static Template Default
        {
            get
            {
                return MainMenuView;
            }
        }

        private static Template _mainMenuView;
        public static Template MainMenuView
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuView == null || _mainMenuView.CurrentVersion != Template.Version)
#else
                if (_mainMenuView == null)
#endif
                {
                    _mainMenuView = new Template(UIViewTemplates.UIView);
#if UNITY_EDITOR
                    _mainMenuView.Name = "MainMenuView";
                    _mainMenuView.LineNumber = 0;
                    _mainMenuView.LinePosition = 0;
#endif
                    Delight.MainMenuView.SubmenuSwitcherTemplateProperty.SetDefault(_mainMenuView, MainMenuViewSubmenuSwitcher);
                    Delight.MainMenuView.MainMenuWindowTemplateProperty.SetDefault(_mainMenuView, MainMenuViewMainMenuWindow);
                    Delight.MainMenuView.Group1TemplateProperty.SetDefault(_mainMenuView, MainMenuViewGroup1);
                    Delight.MainMenuView.Button1TemplateProperty.SetDefault(_mainMenuView, MainMenuViewButton1);
                    Delight.MainMenuView.Button2TemplateProperty.SetDefault(_mainMenuView, MainMenuViewButton2);
                    Delight.MainMenuView.Button3TemplateProperty.SetDefault(_mainMenuView, MainMenuViewButton3);
                    Delight.MainMenuView.PlayWindowTemplateProperty.SetDefault(_mainMenuView, MainMenuViewPlayWindow);
                    Delight.MainMenuView.Group2TemplateProperty.SetDefault(_mainMenuView, MainMenuViewGroup2);
                    Delight.MainMenuView.ToggleGroup1TemplateProperty.SetDefault(_mainMenuView, MainMenuViewToggleGroup1);
                    Delight.MainMenuView.Label1TemplateProperty.SetDefault(_mainMenuView, MainMenuViewLabel1);
                    Delight.MainMenuView.Button4TemplateProperty.SetDefault(_mainMenuView, MainMenuViewButton4);
                    Delight.MainMenuView.Button5TemplateProperty.SetDefault(_mainMenuView, MainMenuViewButton5);
                    Delight.MainMenuView.Button6TemplateProperty.SetDefault(_mainMenuView, MainMenuViewButton6);
                    Delight.MainMenuView.Button7TemplateProperty.SetDefault(_mainMenuView, MainMenuViewButton7);
                    Delight.MainMenuView.Button8TemplateProperty.SetDefault(_mainMenuView, MainMenuViewButton8);
                    Delight.MainMenuView.OptionsWindowTemplateProperty.SetDefault(_mainMenuView, MainMenuViewOptionsWindow);
                    Delight.MainMenuView.Button9TemplateProperty.SetDefault(_mainMenuView, MainMenuViewButton9);
                }
                return _mainMenuView;
            }
        }

        private static Template _mainMenuViewSubmenuSwitcher;
        public static Template MainMenuViewSubmenuSwitcher
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewSubmenuSwitcher == null || _mainMenuViewSubmenuSwitcher.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewSubmenuSwitcher == null)
#endif
                {
                    _mainMenuViewSubmenuSwitcher = new Template(ViewSwitcherTemplates.ViewSwitcher);
#if UNITY_EDITOR
                    _mainMenuViewSubmenuSwitcher.Name = "MainMenuViewSubmenuSwitcher";
                    _mainMenuViewSubmenuSwitcher.LineNumber = 2;
                    _mainMenuViewSubmenuSwitcher.LinePosition = 4;
#endif
                }
                return _mainMenuViewSubmenuSwitcher;
            }
        }

        private static Template _mainMenuViewMainMenuWindow;
        public static Template MainMenuViewMainMenuWindow
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewMainMenuWindow == null || _mainMenuViewMainMenuWindow.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewMainMenuWindow == null)
#endif
                {
                    _mainMenuViewMainMenuWindow = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _mainMenuViewMainMenuWindow.Name = "MainMenuViewMainMenuWindow";
                    _mainMenuViewMainMenuWindow.LineNumber = 5;
                    _mainMenuViewMainMenuWindow.LinePosition = 6;
#endif
                }
                return _mainMenuViewMainMenuWindow;
            }
        }

        private static Template _mainMenuViewGroup1;
        public static Template MainMenuViewGroup1
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewGroup1 == null || _mainMenuViewGroup1.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewGroup1 == null)
#endif
                {
                    _mainMenuViewGroup1 = new Template(GroupTemplates.Group);
#if UNITY_EDITOR
                    _mainMenuViewGroup1.Name = "MainMenuViewGroup1";
                    _mainMenuViewGroup1.LineNumber = 6;
                    _mainMenuViewGroup1.LinePosition = 8;
#endif
                    Delight.Group.SpacingProperty.SetDefault(_mainMenuViewGroup1, new ElementSize(10f, ElementSizeUnit.Pixels));
                    Delight.Group.OffsetProperty.SetDefault(_mainMenuViewGroup1, new ElementMargin(new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(25f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels), new ElementSize(0f, ElementSizeUnit.Pixels)));
                }
                return _mainMenuViewGroup1;
            }
        }

        private static Template _mainMenuViewButton1;
        public static Template MainMenuViewButton1
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewButton1 == null || _mainMenuViewButton1.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewButton1 == null)
#endif
                {
                    _mainMenuViewButton1 = new Template(ButtonTemplates.Button);
#if UNITY_EDITOR
                    _mainMenuViewButton1.Name = "MainMenuViewButton1";
                    _mainMenuViewButton1.LineNumber = 7;
                    _mainMenuViewButton1.LinePosition = 10;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuViewButton1, MainMenuViewButton1Label);
                }
                return _mainMenuViewButton1;
            }
        }

        private static Template _mainMenuViewButton1Label;
        public static Template MainMenuViewButton1Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewButton1Label == null || _mainMenuViewButton1Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewButton1Label == null)
#endif
                {
                    _mainMenuViewButton1Label = new Template(ButtonTemplates.ButtonLabel);
#if UNITY_EDITOR
                    _mainMenuViewButton1Label.Name = "MainMenuViewButton1Label";
                    _mainMenuViewButton1Label.LineNumber = 15;
                    _mainMenuViewButton1Label.LinePosition = 4;
#endif
                    Delight.Label.TextProperty.SetDefault(_mainMenuViewButton1Label, "Play");
                }
                return _mainMenuViewButton1Label;
            }
        }

        private static Template _mainMenuViewButton2;
        public static Template MainMenuViewButton2
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewButton2 == null || _mainMenuViewButton2.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewButton2 == null)
#endif
                {
                    _mainMenuViewButton2 = new Template(ButtonTemplates.Button);
#if UNITY_EDITOR
                    _mainMenuViewButton2.Name = "MainMenuViewButton2";
                    _mainMenuViewButton2.LineNumber = 8;
                    _mainMenuViewButton2.LinePosition = 10;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuViewButton2, MainMenuViewButton2Label);
                }
                return _mainMenuViewButton2;
            }
        }

        private static Template _mainMenuViewButton2Label;
        public static Template MainMenuViewButton2Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewButton2Label == null || _mainMenuViewButton2Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewButton2Label == null)
#endif
                {
                    _mainMenuViewButton2Label = new Template(ButtonTemplates.ButtonLabel);
#if UNITY_EDITOR
                    _mainMenuViewButton2Label.Name = "MainMenuViewButton2Label";
                    _mainMenuViewButton2Label.LineNumber = 15;
                    _mainMenuViewButton2Label.LinePosition = 4;
#endif
                    Delight.Label.TextProperty.SetDefault(_mainMenuViewButton2Label, "Options");
                }
                return _mainMenuViewButton2Label;
            }
        }

        private static Template _mainMenuViewButton3;
        public static Template MainMenuViewButton3
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewButton3 == null || _mainMenuViewButton3.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewButton3 == null)
#endif
                {
                    _mainMenuViewButton3 = new Template(ButtonTemplates.Button);
#if UNITY_EDITOR
                    _mainMenuViewButton3.Name = "MainMenuViewButton3";
                    _mainMenuViewButton3.LineNumber = 9;
                    _mainMenuViewButton3.LinePosition = 10;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuViewButton3, MainMenuViewButton3Label);
                }
                return _mainMenuViewButton3;
            }
        }

        private static Template _mainMenuViewButton3Label;
        public static Template MainMenuViewButton3Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewButton3Label == null || _mainMenuViewButton3Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewButton3Label == null)
#endif
                {
                    _mainMenuViewButton3Label = new Template(ButtonTemplates.ButtonLabel);
#if UNITY_EDITOR
                    _mainMenuViewButton3Label.Name = "MainMenuViewButton3Label";
                    _mainMenuViewButton3Label.LineNumber = 15;
                    _mainMenuViewButton3Label.LinePosition = 4;
#endif
                    Delight.Label.TextProperty.SetDefault(_mainMenuViewButton3Label, "Quit");
                }
                return _mainMenuViewButton3Label;
            }
        }

        private static Template _mainMenuViewPlayWindow;
        public static Template MainMenuViewPlayWindow
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewPlayWindow == null || _mainMenuViewPlayWindow.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewPlayWindow == null)
#endif
                {
                    _mainMenuViewPlayWindow = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _mainMenuViewPlayWindow.Name = "MainMenuViewPlayWindow";
                    _mainMenuViewPlayWindow.LineNumber = 15;
                    _mainMenuViewPlayWindow.LinePosition = 6;
#endif
                }
                return _mainMenuViewPlayWindow;
            }
        }

        private static Template _mainMenuViewGroup2;
        public static Template MainMenuViewGroup2
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewGroup2 == null || _mainMenuViewGroup2.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewGroup2 == null)
#endif
                {
                    _mainMenuViewGroup2 = new Template(GroupTemplates.Group);
#if UNITY_EDITOR
                    _mainMenuViewGroup2.Name = "MainMenuViewGroup2";
                    _mainMenuViewGroup2.LineNumber = 16;
                    _mainMenuViewGroup2.LinePosition = 8;
#endif
                    Delight.Group.SpacingProperty.SetDefault(_mainMenuViewGroup2, new ElementSize(10f, ElementSizeUnit.Pixels));
                }
                return _mainMenuViewGroup2;
            }
        }

        private static Template _mainMenuViewToggleGroup1;
        public static Template MainMenuViewToggleGroup1
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewToggleGroup1 == null || _mainMenuViewToggleGroup1.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewToggleGroup1 == null)
#endif
                {
                    _mainMenuViewToggleGroup1 = new Template(ToggleGroupTemplates.ToggleGroup);
#if UNITY_EDITOR
                    _mainMenuViewToggleGroup1.Name = "MainMenuViewToggleGroup1";
                    _mainMenuViewToggleGroup1.LineNumber = 17;
                    _mainMenuViewToggleGroup1.LinePosition = 10;
#endif
                    Delight.ToggleGroup.OrientationProperty.SetDefault(_mainMenuViewToggleGroup1, Delight.ElementOrientation.Horizontal);
                    Delight.ToggleGroup.SpacingProperty.SetDefault(_mainMenuViewToggleGroup1, new ElementSize(4f, ElementSizeUnit.Pixels));
                    Delight.ToggleGroup.ContentAlignmentProperty.SetDefault(_mainMenuViewToggleGroup1, Delight.ElementAlignment.Top);
                }
                return _mainMenuViewToggleGroup1;
            }
        }

        private static Template _mainMenuViewLabel1;
        public static Template MainMenuViewLabel1
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewLabel1 == null || _mainMenuViewLabel1.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewLabel1 == null)
#endif
                {
                    _mainMenuViewLabel1 = new Template(LabelTemplates.Label);
#if UNITY_EDITOR
                    _mainMenuViewLabel1.Name = "MainMenuViewLabel1";
                    _mainMenuViewLabel1.LineNumber = 18;
                    _mainMenuViewLabel1.LinePosition = 12;
#endif
                    Delight.Label.TextProperty.SetDefault(_mainMenuViewLabel1, "Player Count:");
                    Delight.Label.FontColorProperty.SetDefault(_mainMenuViewLabel1, new UnityEngine.Color(1f, 1f, 1f, 1f));
                    Delight.Label.WidthProperty.SetDefault(_mainMenuViewLabel1, new ElementSize(100f, ElementSizeUnit.Pixels));
                }
                return _mainMenuViewLabel1;
            }
        }

        private static Template _mainMenuViewButton4;
        public static Template MainMenuViewButton4
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewButton4 == null || _mainMenuViewButton4.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewButton4 == null)
#endif
                {
                    _mainMenuViewButton4 = new Template(ButtonTemplates.Button);
#if UNITY_EDITOR
                    _mainMenuViewButton4.Name = "MainMenuViewButton4";
                    _mainMenuViewButton4.LineNumber = 19;
                    _mainMenuViewButton4.LinePosition = 12;
#endif
                    Delight.Button.ToggleValueProperty.SetDefault(_mainMenuViewButton4, true);
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuViewButton4, MainMenuViewButton4Label);
                }
                return _mainMenuViewButton4;
            }
        }

        private static Template _mainMenuViewButton4Label;
        public static Template MainMenuViewButton4Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewButton4Label == null || _mainMenuViewButton4Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewButton4Label == null)
#endif
                {
                    _mainMenuViewButton4Label = new Template(ButtonTemplates.ButtonLabel);
#if UNITY_EDITOR
                    _mainMenuViewButton4Label.Name = "MainMenuViewButton4Label";
                    _mainMenuViewButton4Label.LineNumber = 15;
                    _mainMenuViewButton4Label.LinePosition = 4;
#endif
                    Delight.Label.TextProperty.SetDefault(_mainMenuViewButton4Label, "2");
                }
                return _mainMenuViewButton4Label;
            }
        }

        private static Template _mainMenuViewButton5;
        public static Template MainMenuViewButton5
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewButton5 == null || _mainMenuViewButton5.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewButton5 == null)
#endif
                {
                    _mainMenuViewButton5 = new Template(ButtonTemplates.Button);
#if UNITY_EDITOR
                    _mainMenuViewButton5.Name = "MainMenuViewButton5";
                    _mainMenuViewButton5.LineNumber = 20;
                    _mainMenuViewButton5.LinePosition = 12;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuViewButton5, MainMenuViewButton5Label);
                }
                return _mainMenuViewButton5;
            }
        }

        private static Template _mainMenuViewButton5Label;
        public static Template MainMenuViewButton5Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewButton5Label == null || _mainMenuViewButton5Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewButton5Label == null)
#endif
                {
                    _mainMenuViewButton5Label = new Template(ButtonTemplates.ButtonLabel);
#if UNITY_EDITOR
                    _mainMenuViewButton5Label.Name = "MainMenuViewButton5Label";
                    _mainMenuViewButton5Label.LineNumber = 15;
                    _mainMenuViewButton5Label.LinePosition = 4;
#endif
                    Delight.Label.TextProperty.SetDefault(_mainMenuViewButton5Label, "3");
                }
                return _mainMenuViewButton5Label;
            }
        }

        private static Template _mainMenuViewButton6;
        public static Template MainMenuViewButton6
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewButton6 == null || _mainMenuViewButton6.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewButton6 == null)
#endif
                {
                    _mainMenuViewButton6 = new Template(ButtonTemplates.Button);
#if UNITY_EDITOR
                    _mainMenuViewButton6.Name = "MainMenuViewButton6";
                    _mainMenuViewButton6.LineNumber = 21;
                    _mainMenuViewButton6.LinePosition = 12;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuViewButton6, MainMenuViewButton6Label);
                }
                return _mainMenuViewButton6;
            }
        }

        private static Template _mainMenuViewButton6Label;
        public static Template MainMenuViewButton6Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewButton6Label == null || _mainMenuViewButton6Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewButton6Label == null)
#endif
                {
                    _mainMenuViewButton6Label = new Template(ButtonTemplates.ButtonLabel);
#if UNITY_EDITOR
                    _mainMenuViewButton6Label.Name = "MainMenuViewButton6Label";
                    _mainMenuViewButton6Label.LineNumber = 15;
                    _mainMenuViewButton6Label.LinePosition = 4;
#endif
                    Delight.Label.TextProperty.SetDefault(_mainMenuViewButton6Label, "4");
                }
                return _mainMenuViewButton6Label;
            }
        }

        private static Template _mainMenuViewButton7;
        public static Template MainMenuViewButton7
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewButton7 == null || _mainMenuViewButton7.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewButton7 == null)
#endif
                {
                    _mainMenuViewButton7 = new Template(ButtonTemplates.Button);
#if UNITY_EDITOR
                    _mainMenuViewButton7.Name = "MainMenuViewButton7";
                    _mainMenuViewButton7.LineNumber = 23;
                    _mainMenuViewButton7.LinePosition = 10;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuViewButton7, MainMenuViewButton7Label);
                }
                return _mainMenuViewButton7;
            }
        }

        private static Template _mainMenuViewButton7Label;
        public static Template MainMenuViewButton7Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewButton7Label == null || _mainMenuViewButton7Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewButton7Label == null)
#endif
                {
                    _mainMenuViewButton7Label = new Template(ButtonTemplates.ButtonLabel);
#if UNITY_EDITOR
                    _mainMenuViewButton7Label.Name = "MainMenuViewButton7Label";
                    _mainMenuViewButton7Label.LineNumber = 15;
                    _mainMenuViewButton7Label.LinePosition = 4;
#endif
                    Delight.Label.TextProperty.SetDefault(_mainMenuViewButton7Label, "Start");
                }
                return _mainMenuViewButton7Label;
            }
        }

        private static Template _mainMenuViewButton8;
        public static Template MainMenuViewButton8
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewButton8 == null || _mainMenuViewButton8.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewButton8 == null)
#endif
                {
                    _mainMenuViewButton8 = new Template(ButtonTemplates.Button);
#if UNITY_EDITOR
                    _mainMenuViewButton8.Name = "MainMenuViewButton8";
                    _mainMenuViewButton8.LineNumber = 24;
                    _mainMenuViewButton8.LinePosition = 10;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuViewButton8, MainMenuViewButton8Label);
                }
                return _mainMenuViewButton8;
            }
        }

        private static Template _mainMenuViewButton8Label;
        public static Template MainMenuViewButton8Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewButton8Label == null || _mainMenuViewButton8Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewButton8Label == null)
#endif
                {
                    _mainMenuViewButton8Label = new Template(ButtonTemplates.ButtonLabel);
#if UNITY_EDITOR
                    _mainMenuViewButton8Label.Name = "MainMenuViewButton8Label";
                    _mainMenuViewButton8Label.LineNumber = 15;
                    _mainMenuViewButton8Label.LinePosition = 4;
#endif
                    Delight.Label.TextProperty.SetDefault(_mainMenuViewButton8Label, "Back");
                }
                return _mainMenuViewButton8Label;
            }
        }

        private static Template _mainMenuViewOptionsWindow;
        public static Template MainMenuViewOptionsWindow
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewOptionsWindow == null || _mainMenuViewOptionsWindow.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewOptionsWindow == null)
#endif
                {
                    _mainMenuViewOptionsWindow = new Template(RegionTemplates.Region);
#if UNITY_EDITOR
                    _mainMenuViewOptionsWindow.Name = "MainMenuViewOptionsWindow";
                    _mainMenuViewOptionsWindow.LineNumber = 29;
                    _mainMenuViewOptionsWindow.LinePosition = 6;
#endif
                }
                return _mainMenuViewOptionsWindow;
            }
        }

        private static Template _mainMenuViewButton9;
        public static Template MainMenuViewButton9
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewButton9 == null || _mainMenuViewButton9.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewButton9 == null)
#endif
                {
                    _mainMenuViewButton9 = new Template(ButtonTemplates.Button);
#if UNITY_EDITOR
                    _mainMenuViewButton9.Name = "MainMenuViewButton9";
                    _mainMenuViewButton9.LineNumber = 30;
                    _mainMenuViewButton9.LinePosition = 8;
#endif
                    Delight.Button.LabelTemplateProperty.SetDefault(_mainMenuViewButton9, MainMenuViewButton9Label);
                }
                return _mainMenuViewButton9;
            }
        }

        private static Template _mainMenuViewButton9Label;
        public static Template MainMenuViewButton9Label
        {
            get
            {
#if UNITY_EDITOR
                if (_mainMenuViewButton9Label == null || _mainMenuViewButton9Label.CurrentVersion != Template.Version)
#else
                if (_mainMenuViewButton9Label == null)
#endif
                {
                    _mainMenuViewButton9Label = new Template(ButtonTemplates.ButtonLabel);
#if UNITY_EDITOR
                    _mainMenuViewButton9Label.Name = "MainMenuViewButton9Label";
                    _mainMenuViewButton9Label.LineNumber = 15;
                    _mainMenuViewButton9Label.LinePosition = 4;
#endif
                    Delight.Label.TextProperty.SetDefault(_mainMenuViewButton9Label, "Back");
                }
                return _mainMenuViewButton9Label;
            }
        }

        #endregion
    }

    #endregion
}
