namespace UnityEngine.UIElements.UIR;

internal class EntryRecorder
{
	private EntryPool m_EntryPool; //Field offset: 0x10

	[CalledBy(Type = typeof(RenderChain), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel), typeof(UIRenderDevice), typeof(AtlasBase), typeof(VectorImageManager)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public EntryRecorder(EntryPool entryPool) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private static void Append(Entry parentEntry, Entry entry) { }

	[CalledBy(Type = typeof(EntryRecorder), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(Texture), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryRecorder), Member = "DrawRasterText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(Texture), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryRecorder), Member = "DrawSdfText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(Texture), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryRecorder), Member = "DrawGradients", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(VectorImage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "DrawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>>), typeof(System.Collections.Generic.List`1<Unity.Collections.NativeSlice`1<System.UInt16>>), typeof(System.Collections.Generic.List`1<UnityEngine.Texture2D>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.LowLevel.GlyphRenderMode>), typeof(System.Collections.Generic.List`1<System.Single>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "MakeText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(bool), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private static void AppendMeshEntry(Entry parentEntry, Entry entry) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[CallsUnknownMethods(Count = 2)]
	public void BeginStencilMask(Entry parentEntry) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[CallsUnknownMethods(Count = 2)]
	public void BlitAndPopRenderTexture(Entry parentEntry) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[CallsUnknownMethods(Count = 2)]
	public void CutRenderChain(Entry parentEntry) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[CallsUnknownMethods(Count = 2)]
	public void DrawChildren(Entry parentEntry) { }

	[CalledBy(Type = typeof(UnsafeMeshGenerationNode), Member = "DrawGradientsInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(VectorImage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerationNodeImpl), Member = "DrawGradients", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(VectorImage)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(EntryRecorder), Member = "AppendMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Entry)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void DrawGradients(Entry parentEntry, NativeSlice<Vertex> vertices, NativeSlice<UInt16> indices, VectorImage gradientsOwner) { }

	[CalledBy(Type = typeof(IMGUIContainer), Member = "OnGenerateVisualContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[CallsUnknownMethods(Count = 3)]
	public void DrawImmediate(Entry parentEntry, Action callback, bool cullingEnabled) { }

	[CalledBy(Type = typeof(UnsafeMeshGenerationNode), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeMeshGenerationNode), Member = "DrawMeshInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(Texture), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerationNodeImpl), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(Texture), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Painter2D+Painter2DJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(EntryRecorder), Member = "AppendMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Entry)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void DrawMesh(Entry parentEntry, NativeSlice<Vertex> vertices, NativeSlice<UInt16> indices, Texture texture, bool skipAtlas) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(EntryRecorder), Member = "AppendMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Entry)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void DrawRasterText(Entry parentEntry, NativeSlice<Vertex> vertices, NativeSlice<UInt16> indices, Texture texture, bool multiChannel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(EntryRecorder), Member = "AppendMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Entry)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void DrawSdfText(Entry parentEntry, NativeSlice<Vertex> vertices, NativeSlice<UInt16> indices, Texture texture, float scale, float sharpness) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[CallsUnknownMethods(Count = 2)]
	public void EndStencilMask(Entry parentEntry) { }

	[CalledBy(Type = typeof(MeshGenerationContext), Member = "InsertMeshGenerationNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationNode&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerationContext), Member = "InsertUnsafeMeshGenerationNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[CallsUnknownMethods(Count = 2)]
	public Entry InsertPlaceholder(Entry parentEntry) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[CallsUnknownMethods(Count = 2)]
	public void PopClippingRect(Entry parentEntry) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[CallsUnknownMethods(Count = 2)]
	public void PopDefaultMaterial(Entry parentEntry) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[CallsUnknownMethods(Count = 2)]
	public void PopGroupMatrix(Entry parentEntry) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[CallsUnknownMethods(Count = 2)]
	public void PopScissors(Entry parentEntry) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[CallsUnknownMethods(Count = 2)]
	public void PopStencilMask(Entry parentEntry) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[CallsUnknownMethods(Count = 2)]
	public void PushClippingRect(Entry parentEntry) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[CallsUnknownMethods(Count = 3)]
	public void PushDefaultMaterial(Entry parentEntry, Material material) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[CallsUnknownMethods(Count = 2)]
	public void PushGroupMatrix(Entry parentEntry) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[CallsUnknownMethods(Count = 2)]
	public void PushRenderTexture(Entry parentEntry) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[CallsUnknownMethods(Count = 2)]
	public void PushScissors(Entry parentEntry) { }

}

