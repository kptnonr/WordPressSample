/*
 * Created by Ranorex
 * User: renzinger
 * Date: 27.08.2014
 * Time: 14 Uhr
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
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

namespace WebWordPressLibrary
{
    /// <summary>
    /// Description of InitPopupWatcher.
    /// </summary>
    [TestModule("77069F78-66FA-41EE-9BC3-A658DA488AD8", ModuleType.UserCode, 1)]
    public class StartWatchingPopup : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartWatchingPopup()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            WatchAutoComplete.DoWatchAutoComplete.WatchAndClick (WebWordPressLibraryRepository.Instance.IE_Popup,WebWordPressLibraryRepository.Instance.IE_Popup.ButtonNoInfo );
            WatchAutoComplete.DoWatchAutoComplete.Start();
            
        }
    }
}
