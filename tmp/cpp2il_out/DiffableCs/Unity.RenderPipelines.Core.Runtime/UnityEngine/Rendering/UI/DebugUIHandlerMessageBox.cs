namespace UnityEngine.Rendering.UI;

public class DebugUIHandlerMessageBox : DebugUIHandlerWidget
{
	private static Color32 k_WarningBackgroundColor; //Field offset: 0x0
	private static Color32 k_WarningTextColor; //Field offset: 0x4
	private static Color32 k_ErrorBackgroundColor; //Field offset: 0x8
	private static Color32 k_ErrorTextColor; //Field offset: 0xC
	public Text nameLabel; //Field offset: 0x60
	private MessageBox m_Field; //Field offset: 0x68

	[CallerCount(Count = 0)]
	private static DebugUIHandlerMessageBox() { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DebugUIHandlerMessageBox() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUIHandlerWidget), Member = "CastWidget", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal virtual void SetWidget(Widget widget) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageBox), Member = "get_message", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Update() { }

}

