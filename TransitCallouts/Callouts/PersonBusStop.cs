using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rage;
using Rage.Native;
using LSPD_First_Response.Mod.API;
using LSPD_First_Response.Mod.Callouts;
using LSPD_First_Response.Engine.Scripting.Entities;
using Traffic_Policer;
using Traffic_Policer.API;
using Arrest_Manager;
using Arrest_Manager.API;



namespace TransitCallouts.Callouts {

    [CalloutInfo("PersonBusStop", CalloutProbability.VeryHigh)]

    class PersonBusStop : Callout {

        private Ped Suspect;
        private Vector3 SpawnPoint;
        private Blip SuspectsBlip;
        private LHandle Pursuit;
        private bool PursuitCreated = false;


        public override bool OnBeforeCalloutDisplayed() {
            return base.OnBeforeCalloutDisplayed();
        }

        public override bool OnCalloutAccepted() {
            return base.OnCalloutAccepted();
        }

        public override void Process() {
            base.Process();
        }

        public override void End() {
            base.End();
        }

    }
}
