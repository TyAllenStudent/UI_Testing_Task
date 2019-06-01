namespace CodedUITestProject1
{
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;
    using System.Diagnostics.CodeAnalysis;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public partial class UIMap
    {


        /// <summary>
        /// RecordedMethod1 - Use 'RecordedMethod1Params' to pass parameters into this method.
        /// </summary>
        public void NewRecordedMethod1()
        {
            #region Variable Declarations
            WpfButton uIButtOnButton = this.UIMainWindowWindow.UIButtOnButton;
            WpfCheckBox uICheckBoxCheckBox = this.UIMainWindowWindow.UICheckBoxCheckBox;
            WinTitleBar uIMainWindowTitleBar = this.UIMainWindowWindow1.UIMainWindowTitleBar;
            #endregion

            // Launch '%USERPROFILE%\source\repos\UI_Testing_102058205\UI_Testing_102058205\bin\Debug\UI_Testing_102058205.exe'
            ApplicationUnderTest uIMainWindowWindow = ApplicationUnderTest.Launch(this.RecordedMethod1Params.UIMainWindowWindowExePath, this.RecordedMethod1Params.UIMainWindowWindowAlternateExePath);

            // Click 'Butt On' button
            Mouse.Click(uIButtOnButton, new Point(46, 28));

            // Select 'CheckBox' check box

            uICheckBoxCheckBox.WaitForControlEnabled();
            uICheckBoxCheckBox.Checked = this.RecordedMethod1Params.UICheckBoxCheckBoxChecked;

            // Click 'MainWindow' title bar
            Mouse.Click(uIMainWindowTitleBar, new Point(767, 15));
        }

        public virtual RecordedMethod1Params RecordedMethod1Params
        {
            get
            {
                if ((this.mRecordedMethod1Params == null))
                {
                    this.mRecordedMethod1Params = new RecordedMethod1Params();
                }
                return this.mRecordedMethod1Params;
            }
        }

        private RecordedMethod1Params mRecordedMethod1Params;
    }
    /// <summary>
    /// Parameters to be passed into 'RecordedMethod1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "16.0.28315.86")]
    public class RecordedMethod1Params
    {

        #region Fields
        /// <summary>
        /// Launch '%USERPROFILE%\source\repos\UI_Testing_102058205\UI_Testing_102058205\bin\Debug\UI_Testing_102058205.exe'
        /// </summary>
        public string UIMainWindowWindowExePath = "C:\\Users\\Ty\\source\\repos\\UI_Testing_102058205\\UI_Testing_102058205\\bin\\Debug\\UI_T" +
            "esting_102058205.exe";

        /// <summary>
        /// Launch '%USERPROFILE%\source\repos\UI_Testing_102058205\UI_Testing_102058205\bin\Debug\UI_Testing_102058205.exe'
        /// </summary>
        public string UIMainWindowWindowAlternateExePath = "%USERPROFILE%\\source\\repos\\UI_Testing_102058205\\UI_Testing_102058205\\bin\\Debug\\UI" +
            "_Testing_102058205.exe";

        /// <summary>
        /// Select 'CheckBox' check box
        /// </summary>
        public bool UICheckBoxCheckBoxChecked = true;
        #endregion
    }
}
