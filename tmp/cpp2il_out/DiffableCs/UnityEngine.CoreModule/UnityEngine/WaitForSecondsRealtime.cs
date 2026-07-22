namespace UnityEngine;

public class WaitForSecondsRealtime : CustomYieldInstruction
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private float <waitTime>k__BackingField; //Field offset: 0x10
	private float m_WaitUntilTime; //Field offset: 0x14

	public virtual bool keepWaiting
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 150
	}

	public float waitTime
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	[CalledBy(Type = "UI.Dates.DatePickerTimer", Member = "GetWaitForSecondsRealtimeInstruction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(WaitForSecondsRealtime))]
	[CalledBy(Type = "TMPro.TMP_Dropdown+<DelayedDestroyDropdownList>d__90", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_InputField+<MouseDragOutsideRect>d__314", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown+<DelayedDestroyDropdownList>d__75", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.InputField+<MouseDragOutsideRect>d__194", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	public WaitForSecondsRealtime(float time) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public virtual bool get_keepWaiting() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public float get_waitTime() { }

	[CallerCount(Count = 0)]
	public virtual void Reset() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_waitTime(float value) { }

}

