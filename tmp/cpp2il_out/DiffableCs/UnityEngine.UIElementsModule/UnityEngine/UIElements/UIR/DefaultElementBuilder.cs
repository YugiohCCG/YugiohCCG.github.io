namespace UnityEngine.UIElements.UIR;

internal class DefaultElementBuilder : BaseElementBuilder
{
	private RenderChain m_RenderChain; //Field offset: 0x10

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public DefaultElementBuilder(RenderChain renderChain) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ComputedStyle), Member = "get_backgroundPositionX", ReturnType = typeof(BackgroundPosition))]
	[Calls(Type = typeof(BackgroundPropertyHelper), Member = "ConvertScaleModeToBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleMode)}, ReturnType = typeof(BackgroundSize))]
	[Calls(Type = typeof(BackgroundPropertyHelper), Member = "ConvertScaleModeToBackgroundRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleMode)}, ReturnType = typeof(BackgroundRepeat))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unitySliceType", ReturnType = typeof(SliceType))]
	[Calls(Type = typeof(UIElementsUtility), Member = "PixelsPerUnitScaleForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Sprite)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RectangleParams), Member = "MakeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Sprite), typeof(ScaleMode), typeof(Color), typeof(bool), typeof(Vector4&), typeof(bool)}, ReturnType = typeof(RectangleParams))]
	[Calls(Type = typeof(RectangleParams), Member = "HasRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectangleParams), Member = "MakeTextured", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Texture), typeof(ScaleMode), typeof(Color)}, ReturnType = typeof(RectangleParams))]
	[Calls(Type = typeof(RectangleParams), Member = "MakeVectorTextured", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(VectorImage), typeof(ScaleMode), typeof(Color)}, ReturnType = typeof(RectangleParams))]
	[Calls(Type = typeof(BackgroundPropertyHelper), Member = "ResolveUnityBackgroundScaleMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundPosition), typeof(BackgroundPosition), typeof(BackgroundRepeat), typeof(BackgroundSize), typeof(Boolean&)}, ReturnType = typeof(ScaleMode))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_backgroundSize", ReturnType = typeof(BackgroundSize))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_backgroundRepeat", ReturnType = typeof(BackgroundRepeat))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_backgroundPositionY", ReturnType = typeof(BackgroundPosition))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityBackgroundImageTintColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_backgroundImage", ReturnType = typeof(Background))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unitySliceBottom", ReturnType = typeof(int))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unitySliceRight", ReturnType = typeof(int))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unitySliceTop", ReturnType = typeof(int))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unitySliceLeft", ReturnType = typeof(int))]
	[Calls(Type = typeof(MeshGenerator), Member = "AdjustBackgroundSizeForBorders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RectangleParams&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = "GetVisualElementRadii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_playModeTintColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(ColorPage), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(BMPAlloc)}, ReturnType = typeof(ColorPage))]
	[Calls(Type = typeof(VisualElement), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_backgroundColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 19)]
	[ContainsUnimplementedInstructions]
	protected virtual void DrawVisualElementBackground(MeshGenerationContext mgc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(VisualElement), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ColorPage), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(BMPAlloc)}, ReturnType = typeof(ColorPage))]
	[Calls(Type = typeof(VisualElement), Member = "get_playModeTintColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(MeshGenerator), Member = "GetVisualElementRadii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	protected virtual void DrawVisualElementBorder(MeshGenerationContext mgc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRUtility), Member = "IsVectorImageBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DefaultElementBuilder), Member = "GenerateStencilClipEntryForRoundedRectBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void DrawVisualElementStencilMask(MeshGenerationContext mgc) { }

	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementStencilMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(MeshGenerator), Member = "GetVisualElementRadii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&), typeof(Vector2&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_playModeTintColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityOverflowClipBox", ReturnType = typeof(OverflowClipBox))]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	private static void GenerateStencilClipEntryForRoundedRectBackground(MeshGenerationContext mgc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRUtility), Member = "IsRoundRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIRUtility), Member = "IsVectorImageBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	public virtual bool RequiresStencilMask(VisualElement ve) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MeshGenerationContext), Member = "get_painter2D", ReturnType = typeof(Painter2D))]
	[Calls(Type = typeof(Painter2D), Member = "ScheduleJobs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void ScheduleMeshGenerationJobs(MeshGenerationContext mgc) { }

}

