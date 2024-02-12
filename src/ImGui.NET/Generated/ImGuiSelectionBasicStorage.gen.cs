using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiSelectionBasicStorage
    {
        public ImGuiStorage Storage;
        public int Size;
        public void* AdapterData;
        public IntPtr AdapterIndexToStorageId;
    }
    public unsafe partial struct ImGuiSelectionBasicStoragePtr
    {
        public ImGuiSelectionBasicStorage* NativePtr { get; }
        public ImGuiSelectionBasicStoragePtr(ImGuiSelectionBasicStorage* nativePtr) => NativePtr = nativePtr;
        public ImGuiSelectionBasicStoragePtr(IntPtr nativePtr) => NativePtr = (ImGuiSelectionBasicStorage*)nativePtr;
        public static implicit operator ImGuiSelectionBasicStoragePtr(ImGuiSelectionBasicStorage* nativePtr) => new ImGuiSelectionBasicStoragePtr(nativePtr);
        public static implicit operator ImGuiSelectionBasicStorage* (ImGuiSelectionBasicStoragePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiSelectionBasicStoragePtr(IntPtr nativePtr) => new ImGuiSelectionBasicStoragePtr(nativePtr);
        public ref ImGuiStorage Storage => ref Unsafe.AsRef<ImGuiStorage>(&NativePtr->Storage);
        public ref int Size => ref Unsafe.AsRef<int>(&NativePtr->Size);
        public IntPtr AdapterData { get => (IntPtr)NativePtr->AdapterData; set => NativePtr->AdapterData = (void*)value; }
        public ref IntPtr AdapterIndexToStorageId => ref Unsafe.AsRef<IntPtr>(&NativePtr->AdapterIndexToStorageId);
        public void AddItem(uint key)
        {
            ImGuiNative.ImGuiSelectionBasicStorage_AddItem((ImGuiSelectionBasicStorage*)(NativePtr), key);
        }
        public void ApplyRequests(ImGuiMultiSelectIOPtr ms_io, int items_count)
        {
            ImGuiMultiSelectIO* native_ms_io = ms_io.NativePtr;
            ImGuiNative.ImGuiSelectionBasicStorage_ApplyRequests((ImGuiSelectionBasicStorage*)(NativePtr), native_ms_io, items_count);
        }
        public void Clear()
        {
            ImGuiNative.ImGuiSelectionBasicStorage_Clear((ImGuiSelectionBasicStorage*)(NativePtr));
        }
        public bool Contains(uint key)
        {
            byte ret = ImGuiNative.ImGuiSelectionBasicStorage_Contains((ImGuiSelectionBasicStorage*)(NativePtr), key);
            return ret != 0;
        }
        public void Destroy()
        {
            ImGuiNative.ImGuiSelectionBasicStorage_destroy((ImGuiSelectionBasicStorage*)(NativePtr));
        }
        public void RemoveItem(uint key)
        {
            ImGuiNative.ImGuiSelectionBasicStorage_RemoveItem((ImGuiSelectionBasicStorage*)(NativePtr), key);
        }
        public void Swap(ImGuiSelectionBasicStoragePtr r)
        {
            ImGuiSelectionBasicStorage* native_r = r.NativePtr;
            ImGuiNative.ImGuiSelectionBasicStorage_Swap((ImGuiSelectionBasicStorage*)(NativePtr), native_r);
        }
        public void UpdateItem(uint key, bool v)
        {
            byte native_v = v ? (byte)1 : (byte)0;
            ImGuiNative.ImGuiSelectionBasicStorage_UpdateItem((ImGuiSelectionBasicStorage*)(NativePtr), key, native_v);
        }
    }
}
