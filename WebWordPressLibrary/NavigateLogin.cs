﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace WebWordPressLibrary
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The NavigateLogin recording.
    /// </summary>
    [TestModule("b4cae198-64a2-4954-82aa-3fe351ea32b7", ModuleType.Recording, 1)]
    public partial class NavigateLogin : ITestModule
    {
        /// <summary>
        /// Holds an instance of the WebWordPressLibraryRepository repository.
        /// </summary>
        public static WebWordPressLibraryRepository repo = WebWordPressLibraryRepository.Instance;

        static NavigateLogin instance = new NavigateLogin();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public NavigateLogin()
        {
            varLoginURL = "http://webtest.ranorex.org/wp-admin/edit.php";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static NavigateLogin Instance
        {
            get { return instance; }
        }

#region Variables

        string _varLoginURL;

        /// <summary>
        /// Gets or sets the value of variable varLoginURL.
        /// </summary>
        [TestVariable("85c891b6-0dfe-44fa-8217-27af232359e7")]
        public string varLoginURL
        {
            get { return _varLoginURL; }
            set { _varLoginURL = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Set value", "Setting attribute PageUrl to '$varLoginURL' on item 'WordPress_Demo'.", repo.WordPress_Demo.SelfInfo, new RecordItemIndex(0));
            repo.WordPress_Demo.Self.Element.SetAttributeValue("PageUrl", varLoginURL);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
