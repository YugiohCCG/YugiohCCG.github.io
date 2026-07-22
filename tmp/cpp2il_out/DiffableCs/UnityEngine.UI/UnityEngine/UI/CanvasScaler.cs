namespace UnityEngine.UI;

[AddComponentMenu("Layout/Canvas Scaler", 101)]
[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(Canvas))]
public class CanvasScaler : UIBehaviour
{
	internal enum ScaleMode
	{
		ConstantPixelSize = 0,
		ScaleWithScreenSize = 1,
		ConstantPhysicalSize = 2,
	}

	internal enum ScreenMatchMode
	{
		MatchWidthOrHeight = 0,
		Expand = 1,
		Shrink = 2,
	}

	internal enum Unit
	{
		Centimeters = 0,
		Millimeters = 1,
		Inches = 2,
		Points = 3,
		Picas = 4,
	}

	private const float kLogBase = 2; //Field offset: 0x0
	[SerializeField]
	[Tooltip("Determines how UI elements in the Canvas are scaled.")]
	private ScaleMode m_UiScaleMode; //Field offset: 0x20
	[SerializeField]
	[Tooltip("If a sprite has this 'Pixels Per Unit' setting, then one pixel in the sprite will cover one unit in the UI.")]
	protected float m_ReferencePixelsPerUnit; //Field offset: 0x24
	[SerializeField]
	[Tooltip("Scales all UI elements in the Canvas by this factor.")]
	protected float m_ScaleFactor; //Field offset: 0x28
	[SerializeField]
	[Tooltip("The resolution the UI layout is designed for. If the screen resolution is larger, the UI will be scaled up, and if it's smaller, the UI will be scaled down. This is done in accordance with the Screen Match Mode.")]
	protected Vector2 m_ReferenceResolution; //Field offset: 0x2C
	[SerializeField]
	[Tooltip("A mode used to scale the canvas area if the aspect ratio of the current resolution doesn't fit the reference resolution.")]
	protected ScreenMatchMode m_ScreenMatchMode; //Field offset: 0x34
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("Determines if the scaling is using the width or height as reference, or a mix in between.")]
	protected float m_MatchWidthOrHeight; //Field offset: 0x38
	[SerializeField]
	[Tooltip("The physical unit to specify positions and sizes in.")]
	protected Unit m_PhysicalUnit; //Field offset: 0x3C
	[SerializeField]
	[Tooltip("The DPI to assume if the screen DPI is not known.")]
	protected float m_FallbackScreenDPI; //Field offset: 0x40
	[SerializeField]
	[Tooltip("The pixels per inch to use for sprites that have a 'Pixels Per Unit' setting that matches the 'Reference Pixels Per Unit' setting.")]
	protected float m_DefaultSpriteDPI; //Field offset: 0x44
	[SerializeField]
	[Tooltip("The amount of pixels per unit to use for dynamically created bitmaps in the UI, such as Text.")]
	protected float m_DynamicPixelsPerUnit; //Field offset: 0x48
	private Canvas m_Canvas; //Field offset: 0x50
	private float m_PrevScaleFactor; //Field offset: 0x58
	private float m_PrevReferencePixelsPerUnit; //Field offset: 0x5C
	[SerializeField]
	protected bool m_PresetInfoIsWorld; //Field offset: 0x60

	public float defaultSpriteDPI
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		 set { } //Length: 20
	}

	public float dynamicPixelsPerUnit
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float fallbackScreenDPI
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float matchWidthOrHeight
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public Unit physicalUnit
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public float referencePixelsPerUnit
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public Vector2 referenceResolution
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 19
		[CallerCount(Count = 0)]
		 set { } //Length: 116
	}

	public float scaleFactor
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		 set { } //Length: 20
	}

	public ScreenMatchMode screenMatchMode
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public ScaleMode uiScaleMode
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected CanvasScaler() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private void Canvas_preWillRenderCanvases() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float get_defaultSpriteDPI() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_dynamicPixelsPerUnit() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float get_fallbackScreenDPI() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_matchWidthOrHeight() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Unit get_physicalUnit() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_referencePixelsPerUnit() { }

	[CallerCount(Count = 0)]
	public Vector2 get_referenceResolution() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float get_scaleFactor() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public ScreenMatchMode get_screenMatchMode() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public ScaleMode get_uiScaleMode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_isRootCanvas", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	protected override void Handle() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Screen), Member = "get_dpi", ReturnType = typeof(float))]
	[Calls(Type = typeof(Canvas), Member = "set_scaleFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "set_referencePixelsPerUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected override void HandleConstantPhysicalSize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Canvas), Member = "set_scaleFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "set_referencePixelsPerUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected override void HandleConstantPixelSize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Canvas), Member = "get_renderingDisplaySize", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Canvas), Member = "get_targetDisplay", ReturnType = typeof(int))]
	[Calls(Type = typeof(Display), Member = "get_renderingWidth", ReturnType = typeof(int))]
	[Calls(Type = typeof(Display), Member = "get_renderingHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(Canvas), Member = "set_scaleFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "set_referencePixelsPerUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	protected override void HandleScaleWithScreenSize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Canvas), Member = "set_scaleFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "set_referencePixelsPerUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected override void HandleWorldCanvas() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Canvas), Member = "set_scaleFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "set_referencePixelsPerUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "remove_preWillRenderCanvases", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WillRenderCanvases)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected virtual void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Canvas), Member = "add_preWillRenderCanvases", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WillRenderCanvases)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnEnable() { }

	[CallerCount(Count = 0)]
	public void set_defaultSpriteDPI(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_dynamicPixelsPerUnit(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_fallbackScreenDPI(float value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_matchWidthOrHeight(float value) { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public void set_physicalUnit(Unit value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_referencePixelsPerUnit(float value) { }

	[CallerCount(Count = 0)]
	public void set_referenceResolution(Vector2 value) { }

	[CallerCount(Count = 0)]
	public void set_scaleFactor(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_screenMatchMode(ScreenMatchMode value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_uiScaleMode(ScaleMode value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Canvas), Member = "set_referencePixelsPerUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Canvas), Member = "set_scaleFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected void SetScaleFactor(float scaleFactor) { }

}

