using FFXIVClientStructs.FFXIV.Client.System.String;

namespace FFXIVClientStructs.FFXIV.Client.UI.Info;
[StructLayout(LayoutKind.Explicit, Size = 0x1F8)]
[GenerateInterop]
[Inherits<InfoProxyInterface>]
public unsafe partial struct InfoProxy17 {
    //0x20 bytes
    [FieldOffset(0x38)] public Utf8String UnkString0;
    [FieldOffset(0xA0)] public Utf8String UnkString1;

}
