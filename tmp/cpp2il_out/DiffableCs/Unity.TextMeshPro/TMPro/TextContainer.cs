namespace TMPro;

[RequireComponent(typeof(RectTransform))]
public class TextContainer : UIBehaviour
{
	private static Vector2 k_defaultSize; //Field offset: 0x0
	private bool m_hasChanged; //Field offset: 0x20
	[SerializeField]
	private Vector2 m_pivot; //Field offset: 0x24
	[SerializeField]
	private TextContainerAnchors m_anchorPosition; //Field offset: 0x2C
	[SerializeField]
	private Rect m_rect; //Field offset: 0x30
	private bool m_isDefaultWidth; //Field offset: 0x40
	private bool m_isDefaultHeight; //Field offset: 0x41
	private bool m_isAutoFitting; //Field offset: 0x42
	private Vector3[] m_corners; //Field offset: 0x48
	private Vector3[] m_worldCorners; //Field offset: 0x50
	[SerializeField]
	private Vector4 m_margins; //Field offset: 0x58
	private RectTransform m_rectTransform; //Field offset: 0x68
	private TextMeshPro m_textMeshPro; //Field offset: 0x70

	public TextContainerAnchors anchorPosition
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 256
	}

	public Vector3[] corners
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
	}

	public bool hasChanged
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public float height
	{
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
		 set { } //Length: 48
	}

	public bool isAutoFitting
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool isDefaultHeight
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool isDefaultWidth
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Vector4 margins
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 106
	}

	public Vector2 pivot
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 19
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextContainer), Member = "GetAnchorPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextContainerAnchors))]
		[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 130
	}

	public Rect rect
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 72
	}

	public RectTransform rectTransform
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 141
	}

	public Vector2 size
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 21
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 111
	}

	public TextMeshPro textMeshPro
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 141
	}

	public float width
	{
		[CallerCount(Count = 41)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
		 set { } //Length: 48
	}

	public Vector3[] worldCorners
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	private static TextContainer() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public TextContainer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Awake() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TextContainerAnchors get_anchorPosition() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public Vector3[] get_corners() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_hasChanged() { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public float get_height() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_isAutoFitting() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_isDefaultHeight() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public bool get_isDefaultWidth() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Vector4 get_margins() { }

	[CallerCount(Count = 0)]
	public Vector2 get_pivot() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Rect get_rect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public RectTransform get_rectTransform() { }

	[CallerCount(Count = 0)]
	public Vector2 get_size() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public TextMeshPro get_textMeshPro() { }

	[CallerCount(Count = 41)]
	[DeduplicatedMethod]
	public float get_width() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public Vector3[] get_worldCorners() { }

	[CalledBy(Type = typeof(TextContainer), Member = "set_pivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextContainer), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	private TextContainerAnchors GetAnchorPosition(Vector2 pivot) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private Vector2 GetPivot(TextContainerAnchors anchor) { }

	[CalledBy(Type = typeof(TextContainer), Member = "set_pivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextContainer), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextContainer), Member = "set_margins", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextContainer), Member = "set_height", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextContainer), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextContainer), Member = "set_size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextContainer), Member = "set_rect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextContainer), Member = "set_anchorPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextContainerAnchors)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextContainer), Member = "set_width", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(TextContainer), Member = "UpdateCorners", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_hasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void OnContainerChanged() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected virtual void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
	protected virtual void OnEnable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(TextContainer), Member = "GetAnchorPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextContainerAnchors))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	protected virtual void OnRectTransformDimensionsChange() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_anchorPosition(TextContainerAnchors value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_hasChanged(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
	public void set_height(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_isAutoFitting(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public void set_margins(Vector4 value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextContainer), Member = "GetAnchorPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextContainerAnchors))]
	[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public void set_pivot(Vector2 value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public void set_rect(Rect value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public void set_size(Vector2 value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
	public void set_width(float value) { }

	[CallerCount(Count = 0)]
	private void SetRect(Vector2 size) { }

	[CalledBy(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "set_pivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateCorners() { }

}

