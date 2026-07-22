namespace UnityEngine.Rendering;

[DefaultMember("Item")]
public struct AttachmentIndexArray
{
	public static AttachmentIndexArray Emtpy; //Field offset: 0x0
	private int a0; //Field offset: 0x0
	private int a1; //Field offset: 0x4
	private int a2; //Field offset: 0x8
	private int a3; //Field offset: 0xC
	private int a4; //Field offset: 0x10
	private int a5; //Field offset: 0x14
	private int a6; //Field offset: 0x18
	private int a7; //Field offset: 0x1C
	private int activeAttachments; //Field offset: 0x20

	public int Item
	{
		[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "IsSameNativeSubPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SubPassDescriptor&), typeof(SubPassDescriptor&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData", Member = "CanMergeNativeSubPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData", Member = "AddDepthAttachmentFirstDuringMerge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassFragmentData&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		 get { } //Length: 281
		[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData", Member = "TryMergeNativeSubPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData&", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData", Member = "AddDepthAttachmentFirstDuringMerge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassFragmentData&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		 set { } //Length: 282
	}

	public int Length
	{
		[CallerCount(Count = 30)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AttachmentIndexArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	private static AttachmentIndexArray() { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData", Member = "TryMergeNativeSubPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData&", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AttachmentIndexArray), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public AttachmentIndexArray(int numAttachments) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "IsSameNativeSubPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SubPassDescriptor&), typeof(SubPassDescriptor&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData", Member = "CanMergeNativeSubPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData", Member = "AddDepthAttachmentFirstDuringMerge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassFragmentData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public int get_Item(int index) { }

	[CallerCount(Count = 30)]
	[DeduplicatedMethod]
	public int get_Length() { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData", Member = "TryMergeNativeSubPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData&", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData", Member = "AddDepthAttachmentFirstDuringMerge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.PassFragmentData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public void set_Item(int index, int value) { }

}

