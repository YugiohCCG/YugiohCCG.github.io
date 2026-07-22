namespace UnityEngine.Rendering.UI;

public class DebugUIHandlerWidget : MonoBehaviour
{
	[HideInInspector]
	public Color colorDefault; //Field offset: 0x20
	[HideInInspector]
	public Color colorSelected; //Field offset: 0x30
	[CompilerGenerated]
	private DebugUIHandlerWidget <parentUIHandler>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private DebugUIHandlerWidget <previousUIHandler>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private DebugUIHandlerWidget <nextUIHandler>k__BackingField; //Field offset: 0x50
	protected Widget m_Widget; //Field offset: 0x58

	public DebugUIHandlerWidget nextUIHandler
	{
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public DebugUIHandlerWidget parentUIHandler
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public DebugUIHandlerWidget previousUIHandler
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DebugUIHandlerWidget() { }

	[CallerCount(Count = 21)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	[DeduplicatedMethod]
	protected T CastWidget() { }

	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DebugUIHandlerWidget get_nextUIHandler() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DebugUIHandlerWidget get_parentUIHandler() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DebugUIHandlerWidget get_previousUIHandler() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	internal Widget GetWidget() { }

	[CalledBy(Type = typeof(DebugUIHandlerBitField), Member = "Next", ReturnType = typeof(DebugUIHandlerWidget))]
	[CalledBy(Type = typeof(DebugUIHandlerColor), Member = "Next", ReturnType = typeof(DebugUIHandlerWidget))]
	[CalledBy(Type = typeof(DebugUIHandlerFoldout), Member = "Next", ReturnType = typeof(DebugUIHandlerWidget))]
	[CalledBy(Type = typeof(DebugUIHandlerGroup), Member = "Next", ReturnType = typeof(DebugUIHandlerWidget))]
	[CalledBy(Type = typeof(DebugUIHandlerHBox), Member = "Next", ReturnType = typeof(DebugUIHandlerWidget))]
	[CalledBy(Type = typeof(DebugUIHandlerRenderingLayerField), Member = "Next", ReturnType = typeof(DebugUIHandlerWidget))]
	[CalledBy(Type = typeof(DebugUIHandlerVBox), Member = "Next", ReturnType = typeof(DebugUIHandlerWidget))]
	[CalledBy(Type = typeof(DebugUIHandlerVector2), Member = "Next", ReturnType = typeof(DebugUIHandlerWidget))]
	[CalledBy(Type = typeof(DebugUIHandlerVector3), Member = "Next", ReturnType = typeof(DebugUIHandlerWidget))]
	[CalledBy(Type = typeof(DebugUIHandlerVector4), Member = "Next", ReturnType = typeof(DebugUIHandlerWidget))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public override DebugUIHandlerWidget Next() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnAction() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnDecrement(bool fast) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnDeselection() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void OnEnable() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnIncrement(bool fast) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	public override DebugUIHandlerWidget Previous() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_nextUIHandler(DebugUIHandlerWidget value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_parentUIHandler(DebugUIHandlerWidget value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_previousUIHandler(DebugUIHandlerWidget value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal override void SetWidget(Widget widget) { }

}

