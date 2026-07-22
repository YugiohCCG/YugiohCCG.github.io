namespace UnityEngine.UIElements.UIR;

internal class RenderChainCommand : LinkedPoolItem<RenderChainCommand>
{
	private static readonly int k_ID_MainTex; //Field offset: 0x0
	private static ProfilerMarker s_ImmediateOverheadMarker; //Field offset: 0x8
	internal VisualElement owner; //Field offset: 0x18
	internal RenderChainCommand prev; //Field offset: 0x20
	internal RenderChainCommand next; //Field offset: 0x28
	internal bool isTail; //Field offset: 0x30
	internal CommandType type; //Field offset: 0x34
	internal State state; //Field offset: 0x38
	internal MeshHandle mesh; //Field offset: 0x50
	internal int indexOffset; //Field offset: 0x58
	internal int indexCount; //Field offset: 0x5C
	internal Action callback; //Field offset: 0x60

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	private static RenderChainCommand() { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain+<>c", Member = "<.ctor>b__31_0", ReturnType = typeof(RenderChainCommand))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public RenderChainCommand() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GL), Member = "PushMatrix", ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "LoadOrtho", ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GL), Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "TexCoord2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "Vertex3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "End", ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "PopMatrix", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void Blit(Texture source, RenderTexture destination, float depth) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	private static Rect CombineScissorRects(Rect r0, Rect r1) { }

	[CalledBy(Type = typeof(UIRenderDevice), Member = "EvaluateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(Material), typeof(Material), typeof(Texture), typeof(Texture), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<UnityEngine.Matrix4x4>), Member = "Pop", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Utility), Member = "DisableScissor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat)}, ReturnType = typeof(RenderTexture))]
	[Calls(Type = typeof(GL), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(Color), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "ReleaseTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "PushMatrix", ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "LoadOrtho", ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GL), Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "TexCoord2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "Vertex3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack`1), Member = "Peek", ReturnType = "T")]
	[Calls(Type = typeof(Stack`1), Member = "Pop", ReturnType = "T")]
	[Calls(Type = typeof(Utility), Member = "SetScissorRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectInt)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "End", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RenderChainCommand), Member = "RectPointsToPixelsAndFlipYAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(float)}, ReturnType = typeof(RectInt))]
	[Calls(Type = typeof(Utility), Member = "GetActiveViewport", ReturnType = typeof(RectInt))]
	[Calls(Type = typeof(RectInt), Member = "Overlaps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectInt)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Utility), Member = "GetUnityProjectionMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldTransform", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(GL), Member = "set_modelview", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldClip", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RenderChainCommand), Member = "PushScissor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(Rect), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChainCommand), Member = "PopScissor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "SetupCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<UnityEngine.Matrix4x4>), Member = "Peek", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(GL), Member = "LoadProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "set_invertCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<UnityEngine.Matrix4x4>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "PopMatrix", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	internal void ExecuteNonDrawMesh(DrawParams drawParams, float pixelsPerPoint, ref Exception immediateException) { }

	[CalledBy(Type = typeof(RenderChainCommand), Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Stack`1), Member = "Pop", ReturnType = "T")]
	[Calls(Type = typeof(Stack`1), Member = "Peek", ReturnType = "T")]
	[Calls(Type = typeof(Utility), Member = "DisableScissor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Utility), Member = "GetActiveViewport", ReturnType = typeof(RectInt))]
	[Calls(Type = typeof(Utility), Member = "SetScissorRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectInt)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public static void PopScissor(DrawParams drawParams, float pixelsPerPoint) { }

	[CalledBy(Type = typeof(RenderChainCommand), Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Stack`1), Member = "Peek", ReturnType = "T")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Utility), Member = "GetActiveViewport", ReturnType = typeof(RectInt))]
	[Calls(Type = typeof(Utility), Member = "SetScissorRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectInt)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static void PushScissor(DrawParams drawParams, Rect scissor, float pixelsPerPoint) { }

	[CalledBy(Type = typeof(RenderChainCommand), Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utility), Member = "GetActiveViewport", ReturnType = typeof(RectInt))]
	[CallsUnknownMethods(Count = 4)]
	private static RectInt RectPointsToPixelsAndFlipYAxis(Rect rect, float pixelsPerPoint) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain+<>c", Member = "<.ctor>b__31_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChain), Member = "FreeCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	internal void Reset() { }

}

