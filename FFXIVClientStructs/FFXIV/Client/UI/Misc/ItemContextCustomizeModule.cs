using UserFileEvent = FFXIVClientStructs.FFXIV.Client.UI.Misc.UserFileManager.UserFileEvent;

namespace FFXIVClientStructs.FFXIV.Client.UI.Misc;

// Client::UI::Misc::ItemContextCustomizeModule
//   Client::UI::Misc::UserFileManager::UserFileEvent
// ctor "E8 ?? ?? ?? ?? 48 8D 8F ?? ?? ?? ?? E8 ?? ?? ?? ?? 48 8D 8F ?? ?? ?? ?? 49 8B D4 E8 ?? ?? ?? ?? 48 8D 8F ?? ?? ?? ?? 48 8B D7 E8 ?? ?? ?? ?? 48 8D 8F ?? ?? ?? ?? 48 8B D7 E8 ?? ?? ?? ?? 48 8D 8F"
[GenerateInterop]
[Inherits<UserFileEvent>]
[StructLayout(LayoutKind.Explicit, Size = 0x190)]
public unsafe partial struct ItemContextCustomizeModule {
    public static ItemContextCustomizeModule* Instance() {
        var uiModule = UIModule.Instance();
        return uiModule == null ? null : uiModule->GetItemContextCustomizeModule();
    }

    [FieldOffset(0x48), FixedSizeArray] internal FixedSizeArray128<byte> _firstTier;
    [FieldOffset(0xC8), FixedSizeArray] internal FixedSizeArray128<byte> _secondTier;

    [MemberFunction("E8 ?? ?? ?? ?? 8D 73 02 0F 1F 80 ?? ?? ?? ??")]
    public partial void ResetAll();
}
