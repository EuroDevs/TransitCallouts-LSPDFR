using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rage;
using LSPD_First_Response.Mod.API;
using System.Reflection;

namespace TransitCallouts {

    public class Main : Plugin {

        public override void Initialize() {

            Functions.OnOnDutyStateChanged += OnOnDutyStateChangedHandler;
            Game.LogTrivial("Plugin LSPDFR_API_Guide " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + " has been initialised.");
            Game.LogTrivial("Go on duty to fully load LSPDFR_API_Guide.");

        }

        public override void Finally() {

            Game.LogTrivial("LSPDFR_API_Guide has been cleaned up.");
        }

        private static void OnOnDutyStateChangedHandler(bool OnDuty) {

            if (OnDuty) {

                RegisterCallouts();
            }
        }

        private static void RegisterCallouts() {

            Functions.RegisterCallout(typeof(Callouts.PersonBusStop));
            //Functions.RegisterCallout(typeof(Callouts.ADDNAMEHERE!!!!!!!));
        }


        //   Albo's  Stuff From Here:

        public static bool IsLSPDFRPluginRunning(string Plugin, Version minversion = null) {

            foreach (Assembly assembly in Functions.GetAllUserPlugins()) {

                AssemblyName an = assembly.GetName(); if (an.Name.ToLower() == Plugin.ToLower()) {

                    if (minversion == null || an.Version.CompareTo(minversion) >= 0) {
                        return true;
                    }
                }
            }
            return false;
        }

        //  To here.

    }
}
