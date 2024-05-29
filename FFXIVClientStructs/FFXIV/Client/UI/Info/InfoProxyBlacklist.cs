using FFXIVClientStructs.FFXIV.Client.System.String;

namespace FFXIVClientStructs.FFXIV.Client.UI.Info;

[InfoProxy(InfoProxyId.Blacklist)]
[StructLayout(LayoutKind.Explicit, Size = 0x1A00)]
[GenerateInterop]
[Inherits<InfoProxyPageInterface>]
public unsafe partial struct InfoProxyBlacklist {
    [FieldOffset(0x20), FixedSizeArray] internal FixedSizeArray200<long> _contentIdArray;
    [FieldOffset(0x660)] public Utf8String Unk660;
    [FieldOffset(0x6C8)] public Utf8String Unk6C8;

}
