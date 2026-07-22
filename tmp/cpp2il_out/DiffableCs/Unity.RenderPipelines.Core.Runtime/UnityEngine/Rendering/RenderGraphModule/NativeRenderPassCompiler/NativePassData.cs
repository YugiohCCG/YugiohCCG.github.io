namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

internal struct NativePassData
{
	public FixedAttachmentArray<LoadAudit> loadAudit; //Field offset: 0x0
	public FixedAttachmentArray<StoreAudit> storeAudit; //Field offset: 0x44
	public PassBreakAudit breakAudit; //Field offset: 0xC8
	public FixedAttachmentArray<PassFragmentData> fragments; //Field offset: 0xD0
	public FixedAttachmentArray<NativePassAttachment> attachments; //Field offset: 0x194
	public int firstGraphPass; //Field offset: 0x298
	public int lastGraphPass; //Field offset: 0x29C
	public int numGraphPasses; //Field offset: 0x2A0
	public int firstNativeSubPass; //Field offset: 0x2A4
	public int numNativeSubPasses; //Field offset: 0x2A8
	public int width; //Field offset: 0x2AC
	public int height; //Field offset: 0x2B0
	public int volumeDepth; //Field offset: 0x2B4
	public int samples; //Field offset: 0x2B8
	public bool hasDepth; //Field offset: 0x2BC
	public bool hasFoveatedRasterization; //Field offset: 0x2BD

	[CalledBy(Type = typeof(NativePassCompiler), Member = "TryMergeNativePasses", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.FixedAttachmentArray`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassFragmentData>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassFragmentData&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NativePassData), Member = "TryMergeNativeSubPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData), typeof(NativePassData&), typeof(PassData&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public NativePassData(ref PassData pass, CompilerContextData ctx) { }

	[CalledBy(Type = typeof(NativePassData), Member = "TryMerge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData), typeof(int), typeof(int)}, ReturnType = typeof(PassBreakAudit))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.FixedAttachmentArray`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassFragmentData>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassFragmentData&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(AttachmentIndexArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AttachmentIndexArray), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private void AddDepthAttachmentFirstDuringMerge(CompilerContextData contextData, in PassFragmentData depthAttachment) { }

	[CalledBy(Type = typeof(NativePassCompiler), Member = "GenerateNativeCompilerDebugData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativePassData), Member = "TryMerge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData), typeof(int), typeof(int)}, ReturnType = typeof(PassBreakAudit))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(NativePassData&))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassFragmentData>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PassFragmentData&))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.FixedAttachmentArray`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassFragmentData>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassFragmentData&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NativePassData), Member = "TotalAttachmentsSizeExceedPixelStorageLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData), typeof(NativePassData&), typeof(FixedAttachmentArray`1<PassFragmentData>&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativePassData), Member = "CanMergeNativeSubPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData), typeof(NativePassData), typeof(PassData)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 12)]
	public static PassBreakAudit CanMerge(CompilerContextData contextData, int activeNativePassId, int passIdToMerge) { }

	[CalledBy(Type = typeof(NativePassData), Member = "CanMerge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData), typeof(int), typeof(int)}, ReturnType = typeof(PassBreakAudit))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(NativePassData), Member = "GetSubPassFlagForMerging", ReturnType = typeof(SubPassFlags))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(AttachmentIndexArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private static bool CanMergeNativeSubPass(CompilerContextData contextData, NativePassData nativePass, PassData passToMerge) { }

	[CalledBy(Type = typeof(NativePassData), Member = "TryMerge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData), typeof(int), typeof(int)}, ReturnType = typeof(PassBreakAudit))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.FixedAttachmentArray`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassAttachment>), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.FixedAttachmentArray`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassFragmentData>), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(FixedAttachmentArray`1), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.Name>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Name&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[IsReadOnly]
	public void GetGraphPassNames(CompilerContextData ctx, DynamicArray<Name> dest) { }

	[CalledBy(Type = typeof(NativePassData), Member = "CanMergeNativeSubPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData), typeof(NativePassData), typeof(PassData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativePassData), Member = "TryMergeNativeSubPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData), typeof(NativePassData&), typeof(PassData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public SubPassFlags GetSubPassFlagForMerging() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[IsReadOnly]
	public ReadOnlySpan<PassData> GraphPasses(CompilerContextData ctx, out NativeArray<PassData>& actualPasses) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[IsReadOnly]
	public bool IsValid() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(NativePassData&))]
	[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[CallsUnknownMethods(Count = 1)]
	public static void SetPassStatesForNativePass(CompilerContextData contextData, int nativePassId) { }

	[CalledBy(Type = typeof(NativePassData), Member = "CanMerge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData), typeof(int), typeof(int)}, ReturnType = typeof(PassBreakAudit))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceUnversionedData>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ResourceUnversionedData&))]
	[Calls(Type = typeof(SystemInfo), Member = "GetTiledRenderTargetStorageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool TotalAttachmentsSizeExceedPixelStorageLimit(CompilerContextData contextData, ref NativePassData nativePass, ref FixedAttachmentArray<PassFragmentData>& attachmentsToTryAdding) { }

	[CalledBy(Type = typeof(NativePassCompiler), Member = "TryMergeNativePasses", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativePassData), Member = "CanMerge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData), typeof(int), typeof(int)}, ReturnType = typeof(PassBreakAudit))]
	[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(NativePassData&))]
	[Calls(Type = typeof(NativePassData), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativePassData), Member = "AddDepthAttachmentFirstDuringMerge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData), typeof(PassFragmentData&)}, ReturnType = typeof(void))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.FixedAttachmentArray`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassFragmentData>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassFragmentData&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NativePassData), Member = "TryMergeNativeSubPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData), typeof(NativePassData&), typeof(PassData&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public static PassBreakAudit TryMerge(CompilerContextData contextData, int activeNativePassId, int passIdToMerge) { }

	[CalledBy(Type = typeof(NativePassData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PassData&), typeof(CompilerContextData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativePassData), Member = "TryMerge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData), typeof(int), typeof(int)}, ReturnType = typeof(PassBreakAudit))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativePassData), Member = "GetSubPassFlagForMerging", ReturnType = typeof(SubPassFlags))]
	[Calls(Type = typeof(AttachmentIndexArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(AttachmentIndexArray), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(NativePassCompiler), Member = "IsSameNativeSubPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SubPassDescriptor&), typeof(SubPassDescriptor&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	public static void TryMergeNativeSubPass(CompilerContextData contextData, ref NativePassData nativePass, ref PassData passToMerge) { }

}

