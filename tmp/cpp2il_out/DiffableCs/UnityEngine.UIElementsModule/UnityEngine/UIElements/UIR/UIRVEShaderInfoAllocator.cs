namespace UnityEngine.UIElements.UIR;

internal class UIRVEShaderInfoAllocator
{
	private static readonly Vector2Int identityTransformTexel; //Field offset: 0x0
	private static readonly Vector2Int infiniteClipRectTexel; //Field offset: 0x8
	private static readonly Vector2Int fullOpacityTexel; //Field offset: 0x10
	private static readonly Vector2Int clearColorTexel; //Field offset: 0x18
	private static readonly Vector2Int defaultTextCoreSettingsTexel; //Field offset: 0x20
	private static readonly Matrix4x4 identityTransformValue; //Field offset: 0x28
	private static readonly Vector4 identityTransformRow0Value; //Field offset: 0x68
	private static readonly Vector4 identityTransformRow1Value; //Field offset: 0x78
	private static readonly Vector4 identityTransformRow2Value; //Field offset: 0x88
	private static readonly Vector4 infiniteClipRectValue; //Field offset: 0x98
	private static readonly Vector4 fullOpacityValue; //Field offset: 0xA8
	private static readonly Vector4 clearColorValue; //Field offset: 0xB8
	private static readonly TextCoreSettings defaultTextCoreSettingsValue; //Field offset: 0xC8
	public static readonly BMPAlloc identityTransform; //Field offset: 0x108
	public static readonly BMPAlloc infiniteClipRect; //Field offset: 0x110
	public static readonly BMPAlloc fullOpacity; //Field offset: 0x118
	public static readonly BMPAlloc clearColor; //Field offset: 0x120
	public static readonly BMPAlloc defaultTextCoreSettings; //Field offset: 0x128
	private static int s_DefaultShaderInfoTextureRefCount; //Field offset: 0x130
	private static Texture2D s_DefaultShaderInfoTexture; //Field offset: 0x138
	private BaseShaderInfoStorage m_Storage; //Field offset: 0x10
	private BitmapAllocator32 m_TransformAllocator; //Field offset: 0x18
	private BitmapAllocator32 m_ClipRectAllocator; //Field offset: 0x38
	private BitmapAllocator32 m_OpacityAllocator; //Field offset: 0x58
	private BitmapAllocator32 m_ColorAllocator; //Field offset: 0x78
	private BitmapAllocator32 m_TextSettingsAllocator; //Field offset: 0x98
	private bool m_StorageReallyCreated; //Field offset: 0xB8
	private ColorSpace m_ColorSpace; //Field offset: 0xBC

	public Texture atlas
	{
		[CalledBy(Type = typeof(RenderChain), Member = "SerializeCommandsForCameras", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderChain), Member = "Render", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 133
	}

	private static int pageHeight
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 8
	}

	private static int pageWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
		private get { } //Length: 124
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Matrix4x4), Member = "GetRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector4))]
	private static UIRVEShaderInfoAllocator() { }

	[CalledBy(Type = typeof(RenderChain), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel), typeof(UIRenderDevice), typeof(AtlasBase), typeof(VectorImageManager)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitmapAllocator32), Member = "Construct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitmapAllocator32), Member = "ForceFirstAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "AcquireDefaultShaderInfoTexture", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public UIRVEShaderInfoAllocator(ColorSpace colorSpace) { }

	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorSpace)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "set_filterMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FilterMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "SetPixel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static void AcquireDefaultShaderInfoTexture() { }

	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnClippingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(uint), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(UIRenderDevice), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "ReallyCreateStorage", ReturnType = typeof(void))]
	[Calls(Type = typeof(BitmapAllocator32), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseShaderInfoStorage)}, ReturnType = typeof(BMPAlloc))]
	public BMPAlloc AllocClipRect() { }

	[CalledBy(Type = typeof(RenderEvents), Member = "InitColorIDs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "ReallyCreateStorage", ReturnType = typeof(void))]
	[Calls(Type = typeof(BitmapAllocator32), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseShaderInfoStorage)}, ReturnType = typeof(BMPAlloc))]
	public BMPAlloc AllocColor() { }

	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnOpacityChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(float), typeof(VisualElement), typeof(uint), typeof(bool), typeof(ChainBuilderStats&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "ReallyCreateStorage", ReturnType = typeof(void))]
	[Calls(Type = typeof(BitmapAllocator32), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseShaderInfoStorage)}, ReturnType = typeof(BMPAlloc))]
	public BMPAlloc AllocOpacity() { }

	[CalledBy(Type = typeof(RenderEvents), Member = "UpdateTextCoreSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "ReallyCreateStorage", ReturnType = typeof(void))]
	[Calls(Type = typeof(BitmapAllocator32), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseShaderInfoStorage)}, ReturnType = typeof(BMPAlloc))]
	public BMPAlloc AllocTextCoreSettings(TextCoreSettings settings) { }

	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "ReallyCreateStorage", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "SetTransformValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "SetClipRectValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc), typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "SetOpacityValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "SetColorValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "SetTextCoreSettingValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc), typeof(TextCoreSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(BitmapAllocator32), Member = "GetAllocPageAtlasLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt16&), typeof(UInt16&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	private static Vector2Int AllocToTexelCoord(ref BitmapAllocator32 allocator, BMPAlloc alloc) { }

	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(int), typeof(bool)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "ReallyCreateStorage", ReturnType = typeof(void))]
	[Calls(Type = typeof(BitmapAllocator32), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseShaderInfoStorage)}, ReturnType = typeof(BMPAlloc))]
	public BMPAlloc AllocTransform() { }

	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "ReallyCreateStorage", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BitmapAllocator32), Member = "GetAllocPageAtlasLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt16&), typeof(UInt16&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool AtlasRectMatchesPage(ref BitmapAllocator32 allocator, BMPAlloc defAlloc, RectInt atlasRect) { }

	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(TextureId)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitmapAllocator32), Member = "GetAllocPageAtlasLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt16&), typeof(UInt16&)}, ReturnType = typeof(void))]
	public Color32 ClipRectAllocToVertexData(BMPAlloc alloc) { }

	[CalledBy(Type = typeof(ColorPage), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(BMPAlloc)}, ReturnType = typeof(ColorPage))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitmapAllocator32), Member = "GetAllocPageAtlasLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt16&), typeof(UInt16&)}, ReturnType = typeof(void))]
	public Color32 ColorAllocToVertexData(BMPAlloc alloc) { }

	[CalledBy(Type = typeof(RenderChain), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseShaderInfoStorage), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRUtility), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void Dispose() { }

	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildRemoving", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnClippingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(uint), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(UIRenderDevice), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BMPAlloc), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitmapAllocator32), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	public void FreeClipRect(BMPAlloc alloc) { }

	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildRemoving", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(BMPAlloc), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitmapAllocator32), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	public void FreeColor(BMPAlloc alloc) { }

	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildRemoving", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BMPAlloc), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitmapAllocator32), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	public void FreeOpacity(BMPAlloc alloc) { }

	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildRemoving", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BMPAlloc), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitmapAllocator32), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	public void FreeTextCoreSettings(BMPAlloc alloc) { }

	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildRemoving", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BMPAlloc), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitmapAllocator32), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	public void FreeTransform(BMPAlloc alloc) { }

	[CalledBy(Type = typeof(RenderChain), Member = "SerializeCommandsForCameras", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChain), Member = "Render", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Texture get_atlas() { }

	[CallerCount(Count = 0)]
	private static int get_pageHeight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	private static int get_pageWidth() { }

	[CalledBy(Type = typeof(RenderChain), Member = "ProcessChanges", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void IssuePendingStorageChanges() { }

	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(TextureId)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain+VisualChangesProcessor", Member = "DoUpdateOpacityId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderChain), typeof(MeshHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitmapAllocator32), Member = "GetAllocPageAtlasLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt16&), typeof(UInt16&)}, ReturnType = typeof(void))]
	public Color32 OpacityAllocToVertexData(BMPAlloc alloc) { }

	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocTransform", ReturnType = typeof(BMPAlloc))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocClipRect", ReturnType = typeof(BMPAlloc))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocOpacity", ReturnType = typeof(BMPAlloc))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocColor", ReturnType = typeof(BMPAlloc))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocTextCoreSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextCoreSettings)}, ReturnType = typeof(BMPAlloc))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "SetTextCoreSettingValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc), typeof(TextCoreSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mathf), Member = "GammaToLinearSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Matrix4x4), Member = "GetRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(BMPAlloc), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "AtlasRectMatchesPage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitmapAllocator32&), typeof(BMPAlloc), typeof(RectInt)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ShaderInfoStorageRGBAFloat), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocToTexelCoord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitmapAllocator32&), typeof(BMPAlloc)}, ReturnType = typeof(Vector2Int))]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 26)]
	private void ReallyCreateStorage() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRUtility), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void ReleaseDefaultShaderInfoTexture() { }

	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnTransformOrSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(uint), typeof(UIRenderDevice), typeof(bool), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BMPAlloc), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocToTexelCoord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitmapAllocator32&), typeof(BMPAlloc)}, ReturnType = typeof(Vector2Int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetClipRectValue(BMPAlloc alloc, Vector4 clipRect) { }

	[CalledBy(Type = typeof(RenderEvents), Member = "SetColorValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(BMPAlloc), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocToTexelCoord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitmapAllocator32&), typeof(BMPAlloc)}, ReturnType = typeof(Vector2Int))]
	[Calls(Type = typeof(Mathf), Member = "GammaToLinearSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetColorValue(BMPAlloc alloc, Color color) { }

	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnOpacityChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(float), typeof(VisualElement), typeof(uint), typeof(bool), typeof(ChainBuilderStats&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BMPAlloc), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocToTexelCoord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitmapAllocator32&), typeof(BMPAlloc)}, ReturnType = typeof(Vector2Int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetOpacityValue(BMPAlloc alloc, float opacity) { }

	[CalledBy(Type = typeof(RenderEvents), Member = "UpdateTextCoreSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "ReallyCreateStorage", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BMPAlloc), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocToTexelCoord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitmapAllocator32&), typeof(BMPAlloc)}, ReturnType = typeof(Vector2Int))]
	[Calls(Type = typeof(Mathf), Member = "GammaToLinearSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public void SetTextCoreSettingValue(BMPAlloc alloc, TextCoreSettings settings) { }

	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(int), typeof(bool)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnTransformOrSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(uint), typeof(UIRenderDevice), typeof(bool), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BMPAlloc), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocToTexelCoord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitmapAllocator32&), typeof(BMPAlloc)}, ReturnType = typeof(Vector2Int))]
	[Calls(Type = typeof(Matrix4x4), Member = "GetRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector4))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void SetTransformValue(BMPAlloc alloc, Matrix4x4 xform) { }

	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(TextureId)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitmapAllocator32), Member = "GetAllocPageAtlasLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt16&), typeof(UInt16&)}, ReturnType = typeof(void))]
	public Color32 TextCoreSettingsToVertexData(BMPAlloc alloc) { }

	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(TextureId)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitmapAllocator32), Member = "GetAllocPageAtlasLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt16&), typeof(UInt16&)}, ReturnType = typeof(void))]
	public Color32 TransformAllocToVertexData(BMPAlloc alloc) { }

}

