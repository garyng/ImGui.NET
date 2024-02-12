namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiMultiSelectFlags
    {
        None = 0,
        SingleSelect = 1,
        NoSelectAll = 2,
        NoRangeSelect = 4,
        BoxSelect = 8,
        BoxSelect2d = 16,
        BoxSelectNoScroll = 32,
        ClearOnEscape = 64,
        ClearOnClickVoid = 128,
        ScopeWindow = 256,
        ScopeRect = 512,
        SelectOnClick = 1024,
        SelectOnClickRelease = 2048,
    }
}
