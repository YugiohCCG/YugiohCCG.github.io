namespace UnityEngine;

[NativeHeader("Runtime/Export/Hashing/Hash128.bindings.h")]
[NativeHeader("Runtime/Utilities/Hash128.h")]
[UsedByNativeCode]
public struct Hash128 : IComparable, IComparable<Hash128>, IEquatable<Hash128>
{
	private const ulong kConst = 16045690984833335023; //Field offset: 0x0
	internal ulong u64_0; //Field offset: 0x0
	internal ulong u64_1; //Field offset: 0x8

	public bool isValid
	{
		[CalledBy(Type = "Coffee.UISoftMask.MaterialCache", Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Hash128), "System.Action`1<Material>"}, ReturnType = typeof(Material))]
		[CalledBy(Type = "Coffee.UISoftMask.MaterialCache", Member = "Unregister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Coffee.UISoftMask.SoftMaskable", Member = "UnityEngine.UI.IMaterialModifier.GetModifiedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
		[CallerCount(Count = 3)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 22
	}

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetupNativeRenderPassFrameData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "CreateRenderPassHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(uint)}, ReturnType = typeof(Hash128))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "CreateRenderPassHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderer+RenderPassDescriptor", typeof(uint)}, ReturnType = typeof(Hash128))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMaskable", Member = "UnityEngine.UI.IMaterialModifier.GetModifiedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
	[CallerCount(Count = 5)]
	public Hash128(uint u32_0, uint u32_1, uint u32_2, uint u32_3) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public Hash128(ulong u64_0, ulong u64_1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hash128), Member = "ShortHash4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	public void Append(int val) { }

	[CalledBy(Type = "UnityEngine.Rendering.STP+HistoryContext", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"HistoryUpdateInfo&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.STP", Member = "ComputeHistoryHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"HistoryUpdateInfo&"}, ReturnType = typeof(Hash128))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Hash128), Member = "ComputeFromPtr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(int), typeof(int), typeof(Hash128&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Append(ref T val) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override int CompareTo(object obj) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override int CompareTo(Hash128 rhs) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.SingleHistoryBase", Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RawColorHistory", Member = "IsDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RawColorHistory", Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RawColorHistory", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RawDepthHistory", Member = "IsDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RawDepthHistory", Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RawDepthHistory", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.SingleHistoryBase", Member = "IsDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.SingleHistoryBase", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TaaHistory", Member = "IsDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TaaHistory", Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TaaHistory", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(Hash128), Member = "ComputeFromPtr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(int), typeof(int), typeof(Hash128&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static Hash128 Compute(ref T val) { }

	[CalledBy(Type = "UnityEngine.Rendering.STP+HistoryContext", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"HistoryUpdateInfo&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.STP+HistoryContext", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.STP+HistoryContext", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TaaHistory", Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Hash128), Member = "ShortHash4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	public static Hash128 Compute(int val) { }

	[CalledBy(Type = typeof(Hash128), Member = "Compute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(Hash128))]
	[CalledBy(Type = typeof(Hash128), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("ComputeHash128FromScriptPointer", IsThreadSafe = True)]
	private static void ComputeFromPtr(IntPtr data, int start, int count, int elemSize, ref Hash128 hash) { }

	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(Hash128 obj) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = "Coffee.UISoftMask.MaterialCache", Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Hash128), "System.Action`1<Material>"}, ReturnType = typeof(Material))]
	[CalledBy(Type = "Coffee.UISoftMask.MaterialCache", Member = "Unregister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMaskable", Member = "UnityEngine.UI.IMaterialModifier.GetModifiedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	public bool get_isValid() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ulong), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(Hash128), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("Hash128ToString", IsThreadSafe = True)]
	private static string Hash128ToStringImpl(Hash128 hash) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Hash128ToStringImpl_Injected(in Hash128 hash, out ManagedSpanWrapper ret) { }

	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(Hash128 hash1, Hash128 hash2) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool op_GreaterThan(Hash128 x, Hash128 y) { }

	[CalledBy(Type = "UnityEngine.Rendering.STP+HistoryContext", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"HistoryUpdateInfo&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RawColorHistory", Member = "IsDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RawColorHistory", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RawDepthHistory", Member = "IsDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RawDepthHistory", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.SingleHistoryBase", Member = "IsDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.SingleHistoryBase", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TaaHistory", Member = "IsDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TaaHistory", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(Hash128 hash1, Hash128 hash2) { }

	[CalledBy(Type = "UnityEngine.Rendering.CoreUnsafeUtils", Member = "CompareHashes", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TOldValue", "TOldGetter", "TNewValue", "TNewGetter"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Void*", typeof(int), "System.Void*", "System.Int32*", "System.Int32*", typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static bool op_LessThan(Hash128 x, Hash128 y) { }

	[CalledBy(Type = "UnityEngine.UIElements.Hash128Field+Hash128Input", Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Hash128))]
	[CalledBy(Type = "UnityEngine.UIElements.Hash128Field+Hash128Input", Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Hash128))]
	[CalledBy(Type = "UnityEngine.UIElements.Hash128Field", Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Hash128))]
	[CalledBy(Type = "UnityEngine.UIElements.UxmlHash128AttributeDescription+<>c", Member = "<GetValueFromBag>b__3_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Hash128)}, ReturnType = typeof(Hash128))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("StringToHash128", IsThreadSafe = True)]
	public static Hash128 Parse(string hashString) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Parse_Injected(ref ManagedSpanWrapper hashString, out Hash128 ret) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static void Rot64(ref ulong x, int k) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static void ShortEnd(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3) { }

	[CalledBy(Type = typeof(Hash128), Member = "Compute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Hash128))]
	[CalledBy(Type = typeof(Hash128), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	private void ShortHash4(uint data) { }

	[CalledBy(Type = "UnityEngine.UIElements.Hash128Field", Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Hash128Field", Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Hash128Field", Member = "ValueToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Hash128), Member = "Hash128ToStringImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

