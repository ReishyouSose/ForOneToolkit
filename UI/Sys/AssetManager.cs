using Terraria.GameContent;

namespace ForOneToolkit.UI.Sys;

public static class AssetManager
{
    private static Texture2D[] _baseAssets;
    public static ref Texture2D BackGround => ref _baseAssets[0];
    public static ref Texture2D Close => ref _baseAssets[1];
    public static ref Texture2D Adjust => ref _baseAssets[2];
    public static ref Texture2D Side => ref _baseAssets[3];
    public static ref Texture2D Slot => ref _baseAssets[4];
    public static ref Texture2D VScrollBorder => ref _baseAssets[5];
    public static ref Texture2D VScrollInner => ref _baseAssets[6];
    public static ref Texture2D HScrollBDorder => ref _baseAssets[7];
    public static ref Texture2D HScrollInner => ref _baseAssets[8];
    public static ref Texture2D Unfold => ref _baseAssets[9];
    public static ref Texture2D Fold => ref _baseAssets[10];
    public static ref Texture2D VnlClose => ref _baseAssets[11];
    public static ref Texture2D VnlAdjust => ref _baseAssets[12];
    public static ref Texture2D Move => ref _baseAssets[13];
    public static ref Texture2D Increase => ref _baseAssets[14];
    public static ref Texture2D Decrease => ref _baseAssets[15];
    public static ref Texture2D VnlBg => ref _baseAssets[16];
    public static ref Texture2D VnlBd => ref _baseAssets[17];
    public static Effect EdgeBlur { get; private set; }

    /// <summary>
    /// 蓝底0，选中9
    /// <br/>红底1，选中18
    /// <br/>金底13，选中16
    /// <br/>绿2，枯绿5，暗绿7
    /// <br/>蓝紫3，深蓝8，湖蓝14，灰蓝6，暗蓝11
    /// <br/>暗红4，深红10
    /// <br/>白12，白框15，空白17
    /// </summary>
    public static Asset<Texture2D>[] InvSlot;

    public static void Load()
    {
        const string path = "ForOneToolkit/Assets/";
        string[] files =
        [
            "BackGround",
            "Close",
            "Adjust",
            "Side",
            "Slot",
            "VScrollBorder",
            "VScrollInner",
            "HScrollBorder",
            "HScrollInner",
            "Unfold",
            "Fold",
            "Close2",
            "Adjust2",
            "Move",
            "Increase",
            "Decrease"
        ];
        int count = files.Length;
        _baseAssets = new Texture2D[count + 2];
        for (int i = 0; i < count; i++)
        {
            _baseAssets[i] = T2D(path + files[i]);
        }

        VnlBg = T2D("Terraria/Images/UI/PanelBackground");
        VnlBd = T2D("Terraria/Images/UI/PanelBorder");
        InvSlot =
        [
            TextureAssets.InventoryBack,
            TextureAssets.InventoryBack2,
            TextureAssets.InventoryBack3,
            TextureAssets.InventoryBack4,
            TextureAssets.InventoryBack5,
            TextureAssets.InventoryBack6,
            TextureAssets.InventoryBack7,
            TextureAssets.InventoryBack8,
            TextureAssets.InventoryBack9,
            TextureAssets.InventoryBack10,
            TextureAssets.InventoryBack11,
            TextureAssets.InventoryBack12,
            TextureAssets.InventoryBack13,
            TextureAssets.InventoryBack14,
            TextureAssets.InventoryBack15,
            TextureAssets.InventoryBack16,
            TextureAssets.InventoryBack17,
            TextureAssets.InventoryBack18,
            TextureAssets.InventoryBack19,
        ];
        EdgeBlur = ModContent.Request<Effect>(path + "EdgeBlur", AssetRequestMode.ImmediateLoad).Value;
    }
}