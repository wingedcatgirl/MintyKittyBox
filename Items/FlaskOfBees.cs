using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MintyKittyBox.Items
{
    public class FlaskOfBees : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.MintyKittyBox.hjson file.

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 32;
            Item.value = 10000;
            Item.rare = ItemRarityID.Orange;
            Item.accessory = true;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.BottledHoney, 5);
            recipe.AddIngredient(ItemID.Hive, 25);
            recipe.AddTile(TileID.ImbuingStation);
            recipe.Register();
        }
    }
}
