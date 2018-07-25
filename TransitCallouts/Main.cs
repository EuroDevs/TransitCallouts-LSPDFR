using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSPD_First_Response.Mod.API;
using Rage;

namespace TransitCallouts
{
    public class Main : Plugin
    {
        public override void Initialize()
        {
            Functions.OnOnDutyStateChanged += OnOndutyStateChangedHandler;
            Game.LogTrivial("Transit Callouts for LSPDFR " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + " has loaded up!");
            
        }

        public override void Finally()
        {
            Game.LogTrivial("Tranit Callouts has been terminated");
        }

        private static void OnOndutyStateChangedHandler(bool OnDuty)
        {
            if (OnDuty)
            {
                Game.DisplayNotification("Test - Transit Callouts has loaded up");
                RegisterCallouts();
            }
        }

        private static void RegisterCallouts()
        {
            ThisIsSoThatWeWontForgetToPutCalloutsHere
        }
    }
}
