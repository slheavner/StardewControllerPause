using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace ControllerMultiplayerPause
{
    /// <summary>The mod entry point.</summary>
    public class ModEntry : Mod
    {
        /*********
        ** Public methods
        *********/
        /// <summary>The mod entry point, called after the mod is first loaded.</summary>
        /// <param name="helper">Provides simplified APIs for writing mods.</param>
        public override void Entry(IModHelper helper)
        {
            helper.Events.Input.ButtonPressed += this.OnButtonPressed;
        }


        /*********
        ** Private methods
        *********/
        /// <summary>Raised after the player presses a button on the keyboard, controller, or mouse.</summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event data.</param>
        private void OnButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            // ignore if player hasn't loaded a save yet
            if (!Context.IsWorldReady)
                return;
            
            // print button presses to the console window
            this.Monitor.Log($"{Game1.player.Name} pressed {e.Button}.", LogLevel.Debug);
            this.Monitor.Log($"is multiplayer = {Game1.IsMultiplayer}", LogLevel.Debug);
            var selectPressed = this.Helper.Input.IsDown(SButton.ControllerBack);
            var startPressed = this.Helper.Input.IsDown(SButton.ControllerStart);
            this.Monitor.Log($"selectPressed = {selectPressed}", LogLevel.Debug);
            this.Monitor.Log($"startPressed = {startPressed}", LogLevel.Debug);
            if (Game1.IsMultiplayer)
            {
                if (Game1.menuUp = StardewValley.Menus.)
                {
                    Game1.chatBox.textBoxEnter("/pause");
                }
            }
        }
    }
}
