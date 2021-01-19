using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;
using StardewValley.Menus;
using StardewValley.Objects;

namespace DoubleChest
{
    public class ModEntry : Mod, IAssetLoader
    {
        public bool CanLoad<T>(IAssetInfo asset)
        {
            if (asset.AssetNameEquals("Portraits/Leah"))
            {
                return true;
            }

            return false;
        }

        /// <summary>Load a matched asset.</summary>
        /// <param name="asset">Basic metadata about the asset being loaded.</param>
        public T Load<T>(IAssetInfo asset)
        {
            if (asset.AssetNameEquals("Portraits/Leah"))
            {
                return this.Helper.Content.Load<T>("assets/urushi.png", ContentSource.ModFolder);
            }

            throw new InvalidOperationException($"Unexpected asset '{asset.AssetName}'.");
            throw new NotImplementedException();
        }

        public override void Entry(IModHelper helper)
        {
            return;
        }
    }
}