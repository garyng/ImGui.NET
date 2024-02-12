using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiSelectionRequest
    {
        public ImGuiSelectionRequestType Type;
        public byte RangeSelected;
        public ImGuiSelectionUserData RangeFirstItem;
        public ImGuiSelectionUserData RangeLastItem;
    }
    public unsafe partial struct ImGuiSelectionRequestPtr
    {
        public ImGuiSelectionRequest* NativePtr { get; }
        public ImGuiSelectionRequestPtr(ImGuiSelectionRequest* nativePtr) => NativePtr = nativePtr;
        public ImGuiSelectionRequestPtr(IntPtr nativePtr) => NativePtr = (ImGuiSelectionRequest*)nativePtr;
        public static implicit operator ImGuiSelectionRequestPtr(ImGuiSelectionRequest* nativePtr) => new ImGuiSelectionRequestPtr(nativePtr);
        public static implicit operator ImGuiSelectionRequest* (ImGuiSelectionRequestPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiSelectionRequestPtr(IntPtr nativePtr) => new ImGuiSelectionRequestPtr(nativePtr);
        public ref ImGuiSelectionRequestType Type => ref Unsafe.AsRef<ImGuiSelectionRequestType>(&NativePtr->Type);
        public ref bool RangeSelected => ref Unsafe.AsRef<bool>(&NativePtr->RangeSelected);
        public ref ImGuiSelectionUserData RangeFirstItem => ref Unsafe.AsRef<ImGuiSelectionUserData>(&NativePtr->RangeFirstItem);
        public ref ImGuiSelectionUserData RangeLastItem => ref Unsafe.AsRef<ImGuiSelectionUserData>(&NativePtr->RangeLastItem);
    }
}
