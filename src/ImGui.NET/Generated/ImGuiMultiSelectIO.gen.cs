using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiMultiSelectIO
    {
        public ImVector Requests;
        public ImGuiSelectionUserData RangeSrcItem;
        public ImGuiSelectionUserData NavIdItem;
        public byte NavIdSelected;
        public byte RangeSrcReset;
    }
    public unsafe partial struct ImGuiMultiSelectIOPtr
    {
        public ImGuiMultiSelectIO* NativePtr { get; }
        public ImGuiMultiSelectIOPtr(ImGuiMultiSelectIO* nativePtr) => NativePtr = nativePtr;
        public ImGuiMultiSelectIOPtr(IntPtr nativePtr) => NativePtr = (ImGuiMultiSelectIO*)nativePtr;
        public static implicit operator ImGuiMultiSelectIOPtr(ImGuiMultiSelectIO* nativePtr) => new ImGuiMultiSelectIOPtr(nativePtr);
        public static implicit operator ImGuiMultiSelectIO* (ImGuiMultiSelectIOPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiMultiSelectIOPtr(IntPtr nativePtr) => new ImGuiMultiSelectIOPtr(nativePtr);
        public ImPtrVector<ImGuiSelectionRequestPtr> Requests => new ImPtrVector<ImGuiSelectionRequestPtr>(NativePtr->Requests, Unsafe.SizeOf<ImGuiSelectionRequest>());
        public ref ImGuiSelectionUserData RangeSrcItem => ref Unsafe.AsRef<ImGuiSelectionUserData>(&NativePtr->RangeSrcItem);
        public ref ImGuiSelectionUserData NavIdItem => ref Unsafe.AsRef<ImGuiSelectionUserData>(&NativePtr->NavIdItem);
        public ref bool NavIdSelected => ref Unsafe.AsRef<bool>(&NativePtr->NavIdSelected);
        public ref bool RangeSrcReset => ref Unsafe.AsRef<bool>(&NativePtr->RangeSrcReset);
    }
}
