namespace UnityEngine.UIElements.UIR;

internal class MeshGenerator : IMeshGenerator, IDisposable
{
	internal struct BackgroundRepeatInstance
	{
		public Rect rect; //Field offset: 0x0
		public Rect backgroundRepeatRect; //Field offset: 0x10
		public Rect uv; //Field offset: 0x20

	}

	internal struct BorderParams
	{
		public Rect rect; //Field offset: 0x0
		public Color playmodeTintColor; //Field offset: 0x10
		public Color leftColor; //Field offset: 0x20
		public Color topColor; //Field offset: 0x30
		public Color rightColor; //Field offset: 0x40
		public Color bottomColor; //Field offset: 0x50
		public float leftWidth; //Field offset: 0x60
		public float topWidth; //Field offset: 0x64
		public float rightWidth; //Field offset: 0x68
		public float bottomWidth; //Field offset: 0x6C
		public Vector2 topLeftRadius; //Field offset: 0x70
		public Vector2 topRightRadius; //Field offset: 0x78
		public Vector2 bottomRightRadius; //Field offset: 0x80
		public Vector2 bottomLeftRadius; //Field offset: 0x88
		internal ColorPage leftColorPage; //Field offset: 0x90
		internal ColorPage topColorPage; //Field offset: 0x98
		internal ColorPage rightColorPage; //Field offset: 0xA0
		internal ColorPage bottomColorPage; //Field offset: 0xA8

		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+TessellationJob", Member = "DrawBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode), typeof(BorderParams&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ColorPage), Member = "ToNativeColorPage", ReturnType = typeof(NativeColorPage))]
		[CallsUnknownMethods(Count = 1)]
		internal NativeBorderParams ToNativeParams() { }

	}

	internal struct RectangleParams
	{
		public Rect rect; //Field offset: 0x0
		public Rect uv; //Field offset: 0x10
		public Color color; //Field offset: 0x20
		public Rect subRect; //Field offset: 0x30
		public Rect backgroundRepeatRect; //Field offset: 0x40
		public NativePagedList<BackgroundRepeatInstance> backgroundRepeatInstanceList; //Field offset: 0x50
		public int backgroundRepeatInstanceListStartIndex; //Field offset: 0x58
		public int backgroundRepeatInstanceListEndIndex; //Field offset: 0x5C
		public BackgroundPosition backgroundPositionX; //Field offset: 0x60
		public BackgroundPosition backgroundPositionY; //Field offset: 0x6C
		public BackgroundRepeat backgroundRepeat; //Field offset: 0x78
		public BackgroundSize backgroundSize; //Field offset: 0x80
		public Texture texture; //Field offset: 0x98
		public Sprite sprite; //Field offset: 0xA0
		public VectorImage vectorImage; //Field offset: 0xA8
		public ScaleMode scaleMode; //Field offset: 0xB0
		public Color playmodeTintColor; //Field offset: 0xB4
		public Vector2 topLeftRadius; //Field offset: 0xC4
		public Vector2 topRightRadius; //Field offset: 0xCC
		public Vector2 bottomRightRadius; //Field offset: 0xD4
		public Vector2 bottomLeftRadius; //Field offset: 0xDC
		public Vector2 contentSize; //Field offset: 0xE4
		public Vector2 textureSize; //Field offset: 0xEC
		public int leftSlice; //Field offset: 0xF4
		public int topSlice; //Field offset: 0xF8
		public int rightSlice; //Field offset: 0xFC
		public int bottomSlice; //Field offset: 0x100
		public float sliceScale; //Field offset: 0x104
		internal Rect spriteGeomRect; //Field offset: 0x108
		public Vector4 rectInset; //Field offset: 0x118
		internal ColorPage colorPage; //Field offset: 0x128
		internal MeshFlags meshFlags; //Field offset: 0x130

		[CalledBy(Type = typeof(RectangleParams), Member = "MakeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Sprite), typeof(ScaleMode), typeof(Color), typeof(bool), typeof(Vector4&), typeof(bool)}, ReturnType = typeof(RectangleParams))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(Sprite), Member = "get_bounds", ReturnType = typeof(Bounds))]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		private static void AdjustSpriteUVsForScaleMode(Rect containerRect, Rect srcRect, Rect spriteGeomRect, Sprite sprite, ScaleMode scaleMode, out Rect rectOut, out Rect uvOut) { }

		[CalledBy(Type = typeof(RectangleParams), Member = "MakeTextured", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Texture), typeof(ScaleMode), typeof(Color)}, ReturnType = typeof(RectangleParams))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		private static void AdjustUVsForScaleMode(Rect rect, Rect uv, Texture texture, ScaleMode scaleMode, out Rect rectOut, out Rect uvOut) { }

		[CallerCount(Count = 0)]
		private static Rect ApplyPackingRotation(Rect uv, SpritePackingRotation rotation) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sprite), Member = "get_vertices", ReturnType = typeof(Vector2[]))]
		[CallsUnknownMethods(Count = 2)]
		private static Rect ComputeGeomRect(Sprite sprite) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sprite), Member = "get_uv", ReturnType = typeof(Vector2[]))]
		[CallsUnknownMethods(Count = 2)]
		private static Rect ComputeUVRect(Sprite sprite) { }

		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool HasRadius(float epsilon) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal bool HasSlices(float epsilon) { }

		[CalledBy(Type = typeof(Image), Member = "OnGenerateVisualContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Sprite), Member = "get_border", ReturnType = typeof(Vector4))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(RectangleParams), Member = "AdjustSpriteUVsForScaleMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Rect), typeof(Sprite), typeof(ScaleMode), typeof(Rect&), typeof(Rect&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Sprite), Member = "get_packed", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Sprite), Member = "get_uv", ReturnType = typeof(Vector2[]))]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Sprite), Member = "get_vertices", ReturnType = typeof(Vector2[]))]
		[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
		[Calls(Type = typeof(Sprite), Member = "get_bounds", ReturnType = typeof(Bounds))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 9)]
		[ContainsUnimplementedInstructions]
		public static RectangleParams MakeSprite(Rect containerRect, Rect subRect, Sprite sprite, ScaleMode scaleMode, Color playModeTintColor, bool hasRadius, ref Vector4 slices, bool useForRepeat = false) { }

		[CalledBy(Type = typeof(Image), Member = "OnGenerateVisualContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(RectangleParams), Member = "AdjustUVsForScaleMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Texture), typeof(ScaleMode), typeof(Rect&), typeof(Rect&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		public static RectangleParams MakeTextured(Rect rect, Rect uv, Texture texture, ScaleMode scaleMode, Color playModeTintColor) { }

		[CalledBy(Type = typeof(Image), Member = "OnGenerateVisualContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		public static RectangleParams MakeVectorTextured(Rect rect, Rect uv, VectorImage vectorImage, ScaleMode scaleMode, Color playModeTintColor) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal static Rect RectIntersection(Rect a, Rect b) { }

		[CalledBy(Type = typeof(MeshGenerator), Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectangleParams)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ColorPage), Member = "ToNativeColorPage", ReturnType = typeof(NativeColorPage))]
		[CallsUnknownMethods(Count = 2)]
		internal NativeRectParams ToNativeParams() { }

	}

	private struct RepeatRectUV
	{
		public Rect rect; //Field offset: 0x0
		public Rect uv; //Field offset: 0x10

	}

	private struct TessellationJob : IJobParallelFor
	{
		[ReadOnly]
		public TempMeshAllocator allocator; //Field offset: 0x0
		[ReadOnly]
		public NativeSlice<TessellationJobParameters> jobParameters; //Field offset: 0x8

		[CalledBy(Type = typeof(TessellationJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(BorderParams), Member = "ToNativeParams", ReturnType = typeof(NativeBorderParams))]
		[Calls(Type = typeof(MeshBuilderNative), Member = "MakeBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeBorderParams), typeof(float)}, ReturnType = typeof(MeshWriteDataInterface))]
		[Calls(Type = typeof(UIRenderDevice), Member = "PtrToSlice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vertex)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>))]
		[Calls(Type = typeof(UIRenderDevice), Member = "PtrToSlice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<System.UInt16>))]
		[Calls(Type = typeof(TempMeshAllocator), Member = "AllocateTempMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<System.UInt16>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MeshGenerationNodeImpl), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(Texture), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		private void DrawBorder(UnsafeMeshGenerationNode node, ref BorderParams borderParams) { }

		[CalledBy(Type = typeof(TessellationJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ushort))]
		[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeSlice`1<T>", typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
		[Calls(Type = typeof(UnityEngine.UIElements.UIR.NativePagedList`1+Enumerator<UnityEngine.UIElements.UIR.MeshGenerator+BackgroundRepeatInstance>), Member = "GetNext", ReturnType = typeof(BackgroundRepeatInstance))]
		[Calls(Type = typeof(Enumerator), Member = "HasNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(UnityEngine.UIElements.UIR.NativePagedList`1+Enumerator<UnityEngine.UIElements.UIR.MeshGenerator+BackgroundRepeatInstance>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.UIR.NativePagedList`1<UnityEngine.UIElements.UIR.MeshGenerator+BackgroundRepeatInstance>), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(MeshGenerationNodeImpl), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(Texture), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<System.UInt16>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TempMeshAllocator), Member = "AllocateTempMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UIRenderDevice), Member = "PtrToSlice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<System.UInt16>))]
		[Calls(Type = typeof(UIRenderDevice), Member = "PtrToSlice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vertex)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>))]
		[Calls(Type = typeof(MeshBuilderNative), Member = "MakeTexturedRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeRectParams), typeof(float)}, ReturnType = typeof(MeshWriteDataInterface))]
		[Calls(Type = typeof(MeshBuilderNative), Member = "MakeSolidRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeRectParams), typeof(float)}, ReturnType = typeof(MeshWriteDataInterface))]
		[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ushort)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 30)]
		[CallsUnknownMethods(Count = 10)]
		[ContainsUnimplementedInstructions]
		private void DrawRectangle(UnsafeMeshGenerationNode node, ref NativeRectParams rectParams, Texture tex) { }

		[CalledBy(Type = typeof(TessellationJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TessellationJob), Member = "ExtractHandle", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[Calls(Type = typeof(TempMeshAllocator), Member = "AllocateTempMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MeshGenerator), Member = "AdjustSpriteWinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2[]), typeof(UInt16[]), typeof(Unity.Collections.NativeSlice`1<System.UInt16>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vertex)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MeshGenerationNodeImpl), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(Texture), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		[ContainsUnimplementedInstructions]
		private void DrawSprite(UnsafeMeshGenerationNode node, ref NativeRectParams rectParams, Sprite sprite) { }

		[CalledBy(Type = typeof(TessellationJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(MeshBuilderNative), Member = "MakeVectorGraphicsStretchBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vertex[]), typeof(UInt16[]), typeof(float), typeof(float), typeof(Rect), typeof(Rect), typeof(ScaleMode), typeof(Color), typeof(NativeColorPage)}, ReturnType = typeof(MeshWriteDataInterface))]
		[Calls(Type = typeof(MeshBuilderNative), Member = "MakeVectorGraphics9SliceBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vertex[]), typeof(UInt16[]), typeof(float), typeof(float), typeof(Rect), typeof(Vector4), typeof(Color), typeof(NativeColorPage)}, ReturnType = typeof(MeshWriteDataInterface))]
		[Calls(Type = typeof(UIRenderDevice), Member = "PtrToSlice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vertex)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>))]
		[Calls(Type = typeof(UIRenderDevice), Member = "PtrToSlice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<System.UInt16>))]
		[Calls(Type = typeof(TempMeshAllocator), Member = "AllocateTempMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<System.UInt16>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MeshGenerationNodeImpl), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(Texture), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MeshGenerationNodeImpl), Member = "DrawGradients", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(VectorImage)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 6)]
		[ContainsUnimplementedInstructions]
		private void DrawVectorImage(UnsafeMeshGenerationNode node, ref NativeRectParams rectParams, VectorImage vi) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.UIR.MeshGenerator+TessellationJobParameters>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.UIElements.UIR.MeshGenerator+TessellationJobParameters")]
		[Calls(Type = typeof(TessellationJob), Member = "ExtractHandle", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[Calls(Type = typeof(TessellationJob), Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode), typeof(NativeRectParams&), typeof(Texture)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TessellationJob), Member = "DrawSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode), typeof(NativeRectParams&), typeof(Sprite)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TessellationJob), Member = "DrawVectorImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode), typeof(NativeRectParams&), typeof(VectorImage)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TessellationJob), Member = "DrawBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode), typeof(BorderParams&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void Execute(int i) { }

		[CalledBy(Type = typeof(TessellationJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TessellationJob), Member = "DrawSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode), typeof(NativeRectParams&), typeof(Sprite)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private T ExtractHandle(IntPtr handlePtr) { }

	}

	private struct TessellationJobParameters
	{
		public bool isBorderJob; //Field offset: 0x0
		public NativeRectParams rectParams; //Field offset: 0x8
		public BorderParams borderParams; //Field offset: 0x120
		public UnsafeMeshGenerationNode node; //Field offset: 0x1D0

	}

	private static readonly ProfilerMarker k_MarkerDrawRectangle; //Field offset: 0x0
	private static readonly ProfilerMarker k_MarkerDrawBorder; //Field offset: 0x8
	private static readonly ProfilerMarker k_MarkerDrawVectorImage; //Field offset: 0x10
	private static readonly ProfilerMarker k_MarkerDrawRectangleRepeat; //Field offset: 0x18
	private MeshGenerationContext m_MeshGenerationContext; //Field offset: 0x10
	private List<RepeatRectUV>[] m_RepeatRectUVList; //Field offset: 0x18
	private NativePagedList<BackgroundRepeatInstance> m_BackgroundRepeatInstanceList; //Field offset: 0x20
	private GCHandlePool m_GCHandlePool; //Field offset: 0x28
	private NativeArray<TessellationJobParameters> m_JobParameters; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VisualElement <currentElement>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private TextJobSystem <textJobSystem>k__BackingField; //Field offset: 0x48
	private TextInfo m_TextInfo; //Field offset: 0x50
	private TextGenerationSettings m_Settings; //Field offset: 0x58
	private List<NativeSlice`1<Vertex>> m_VerticesArray; //Field offset: 0x60
	private List<NativeSlice`1<UInt16>> m_IndicesArray; //Field offset: 0x68
	private List<Texture2D> m_Atlases; //Field offset: 0x70
	private List<Single> m_SdfScales; //Field offset: 0x78
	private List<GlyphRenderMode> m_RenderModes; //Field offset: 0x80
	private MeshGenerationCallback m_OnMeshGenerationDelegate; //Field offset: 0x88
	private List<TessellationJobParameters> m_TesselationJobParameters; //Field offset: 0x90
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposed>k__BackingField; //Field offset: 0x98

	public override VisualElement currentElement
	{
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	internal bool disposed
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 7
	}

	public override TextJobSystem textJobSystem
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 254
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	private static MeshGenerator() { }

	[CalledBy(Type = typeof(MeshGenerationContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshWriteDataPool), typeof(EntryRecorder), typeof(TempMeshAllocatorImpl), typeof(MeshGenerationDeferrer), typeof(MeshGenerationNodeManager)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GCHandlePool), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextInfo", Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGenerationSettings", Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 20)]
	public MeshGenerator(MeshGenerationContext mgc) { }

	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	public static void AdjustBackgroundSizeForBorders(VisualElement visualElement, ref RectangleParams rectParams) { }

	[CalledBy(Type = typeof(TessellationJob), Member = "DrawSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode), typeof(NativeRectParams&), typeof(Sprite)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ushort)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private static void AdjustSpriteWinding(Vector2[] vertices, UInt16[] indices, NativeSlice<UInt16> newIndices) { }

	[CallerCount(Count = 0)]
	private static Vector2 ConvertBorderRadiusPercentToPoints(Vector2 borderRectSize, Length length) { }

	[CalledBy(Type = typeof(ATGTextJobSystem), Member = "ConvertMeshInfoToUIRVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ATGMeshInfo[]), typeof(TempMeshAllocator), typeof(TextElement), typeof(List`1<Texture2D>&), typeof(List`1<NativeSlice`1<Vertex>>&), typeof(List`1<NativeSlice`1<UInt16>>&), typeof(List`1<GlyphRenderMode>&), typeof(List`1<Single>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static Vertex ConvertTextVertexToUIRVertex(TextCoreVertex vertex, Vector2 posOffset, bool isDynamicColor = false, bool isColorGlyph = false) { }

	[CalledBy(Type = typeof(MeshGenerationContext), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerationContext), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.NativePagedList`1<UnityEngine.UIElements.UIR.MeshGenerator+BackgroundRepeatInstance>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandlePool), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.NativePagedList`1<UnityEngine.UIElements.UIR.MeshGenerator+BackgroundRepeatInstance>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandlePool), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = "StampRectangleWithSubRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectangleParams), typeof(Rect), typeof(Rect), typeof(Rect), typeof(NativePagedList`1<BackgroundRepeatInstance>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<UnityEngine.UIElements.UIR.MeshGenerator+RepeatRectUV>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(NativePagedList`1), Member = "GetCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.NativePagedList`1<UnityEngine.UIElements.UIR.MeshGenerator+BackgroundRepeatInstance>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.MeshGenerator+RepeatRectUV>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RepeatRectUV)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectangleParams)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(AlignmentUtils), Member = "CeilToPixelGrid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Length), Member = "IsAuto", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BackgroundSize), Member = "get_y", ReturnType = typeof(Length))]
	[Calls(Type = typeof(Length), Member = "IsNone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallsUnknownMethods(Count = 115)]
	[ContainsUnimplementedInstructions]
	private void DoDrawRectangleRepeat(ref RectangleParams rectParams, Rect totalRect, float scaledPixelsPerPoint) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MeshGenerationContext), Member = "InsertUnsafeMeshGenerationNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override void DrawBorder(BorderParams borderParams) { }

	[CalledBy(Type = typeof(EntryProcessor), Member = "AppendCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "DoDrawRectangleRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectangleParams&), typeof(Rect), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "StampRectangleWithSubRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectangleParams), typeof(Rect), typeof(Rect), typeof(Rect), typeof(NativePagedList`1<BackgroundRepeatInstance>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(RectangleParams), Member = "ToNativeParams", ReturnType = typeof(NativeRectParams))]
	[Calls(Type = typeof(GCHandlePool), Member = "GetIntPtr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Sprite), Member = "get_vertices", ReturnType = typeof(Vector2[]))]
	[Calls(Type = typeof(Sprite), Member = "get_uv", ReturnType = typeof(Vector2[]))]
	[Calls(Type = typeof(Sprite), Member = "get_triangles", ReturnType = typeof(UInt16[]))]
	[Calls(Type = typeof(MeshGenerationContext), Member = "InsertUnsafeMeshGenerationNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public override void DrawRectangle(RectangleParams rectParams) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override void DrawRectangleRepeat(RectangleParams rectParams, Rect totalRect, float scaledPixelsPerPoint) { }

	[CalledBy(Type = typeof(MeshGenerator), Member = "DrawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>>), typeof(System.Collections.Generic.List`1<Unity.Collections.NativeSlice`1<System.UInt16>>), typeof(System.Collections.Generic.List`1<UnityEngine.Material>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.LowLevel.GlyphRenderMode>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Texture2D), Member = "get_format", ReturnType = typeof(TextureFormat))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Single>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(EntryRecorder), Member = "AppendMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Entry)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public override void DrawText(List<NativeSlice`1<Vertex>> vertices, List<NativeSlice`1<UInt16>> indices, List<Texture2D> atlases, List<GlyphRenderMode> renderModes, List<Single> sdfScales) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "get_mainTexture", ReturnType = typeof(Texture))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGeneratorUtilities", Member = "IsBitmapRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphRenderMode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Texture2D), Member = "get_format", ReturnType = typeof(TextureFormat))]
	[Calls(Type = typeof(MeshGenerator), Member = "DrawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>>), typeof(System.Collections.Generic.List`1<Unity.Collections.NativeSlice`1<System.UInt16>>), typeof(System.Collections.Generic.List`1<UnityEngine.Texture2D>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.LowLevel.GlyphRenderMode>), typeof(System.Collections.Generic.List`1<System.Single>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public override void DrawText(List<NativeSlice`1<Vertex>> vertices, List<NativeSlice`1<UInt16>> indices, List<Material> materials, List<GlyphRenderMode> renderModes) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_disposed() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override TextJobSystem get_textJobSystem() { }

	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "GenerateStencilClipEntryForRoundedRectBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_borderTopLeftRadius", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_borderBottomLeftRadius", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_borderTopRightRadius", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_borderBottomRightRadius", ReturnType = typeof(Length))]
	[CallsUnknownMethods(Count = 3)]
	public static void GetVisualElementRadii(VisualElement ve, out Vector2 topLeft, out Vector2 bottomLeft, out Vector2 topRight, out Vector2 bottomRight) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(EntryRecorder), Member = "AppendMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Entry)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void MakeText(Texture texture, NativeSlice<Vertex> vertices, NativeSlice<UInt16> indices, bool isSdf, float sdfScale, float sharpness, bool multiChannel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativePagedList`1), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandlePool), Member = "ReturnAll", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnMeshGeneration(MeshGenerationContext ctx, object data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<UnityEngine.UIElements.UIR.MeshGenerator+TessellationJobParameters>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.MeshGenerator+TessellationJobParameters>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TessellationJobParameters))]
	[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TessellationJobParameters)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.UIElements.UIR.MeshGenerator+TessellationJobParameters>), typeof(int), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.UIR.MeshGenerator+TessellationJobParameters>))]
	[Calls(Type = typeof(MeshGenerationContext), Member = "GetTempMeshAllocator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TempMeshAllocator&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ManagedJobExtension), Member = "ScheduleOrRunJob", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TessellationJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TessellationJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(MeshGenerationContext), Member = "AddMeshGenerationJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerationContext), Member = "AddMeshGenerationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationCallback), typeof(object), typeof(MeshGenerationCallbackType), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override void ScheduleJobs(MeshGenerationContext mgc) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override void set_currentElement(VisualElement value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_disposed(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override void set_textJobSystem(TextJobSystem value) { }

	[CalledBy(Type = typeof(EntryProcessor), Member = "AppendCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "DoDrawRectangleRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectangleParams&), typeof(Rect), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.NativePagedList`1<UnityEngine.UIElements.UIR.MeshGenerator+BackgroundRepeatInstance>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundRepeatInstance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectangleParams)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void StampRectangleWithSubRect(RectangleParams rectParams, Rect targetRect, Rect totalRect, Rect targetUV, ref NativePagedList<BackgroundRepeatInstance>& backgroundRepeatInstanceList) { }

}

