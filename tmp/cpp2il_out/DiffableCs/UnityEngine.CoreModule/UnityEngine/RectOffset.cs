namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUIStyle.h")]
[UsedByNativeCode]
public class RectOffset : IFormattable
{
	public static class BindingsMarshaller
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static IntPtr ConvertToNative(RectOffset rectOffset) { }

	}

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule"})]
	internal IntPtr m_Ptr; //Field offset: 0x10
	private readonly object m_SourceStyle; //Field offset: 0x18

	[NativeProperty("bottom", False, TargetType::Field (1))]
	public int bottom
	{
		[CalledBy(Type = "UI.Tables.TableLayout", Member = "UpdateLayout", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "SetVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "CalcHeight", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "ApplyStyleSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUIStyle"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.GUILayoutEntry", Member = "get_marginBottom", ReturnType = typeof(int))]
		[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.NoOptions", "DG.Tweening.Tween", typeof(bool), "DG.Tweening.Core.DOGetter`1<RectOffset>", "DG.Tweening.Core.DOSetter`1<RectOffset>", typeof(float), typeof(RectOffset), typeof(RectOffset), typeof(float), typeof(bool), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "GetSpeedBasedDuration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.NoOptions", typeof(float), typeof(RectOffset)}, ReturnType = typeof(float))]
		[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetRelativeEndValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetChangeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>", typeof(RectOffset), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.General", Member = "GetDynamicConstraintCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.GridLayoutGroup"}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectBase", Member = "AdjustContentSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker_ContentLayout", Member = "SetBorderSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker_ContentLayout", Member = "SetBorderSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectOffset)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "ConvertToStartValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>", typeof(RectOffset)}, ReturnType = typeof(RectOffset))]
		[CallerCount(Count = 30)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 81
		[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectGridController", Member = "UpdateSizing", ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>", typeof(RectOffset), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetRelativeEndValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.NoOptions", "DG.Tweening.Tween", typeof(bool), "DG.Tweening.Core.DOGetter`1<RectOffset>", "DG.Tweening.Core.DOSetter`1<RectOffset>", typeof(float), typeof(RectOffset), typeof(RectOffset), typeof(float), typeof(bool), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 88
	}

	public int horizontal
	{
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "get_preferredWidth", ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.UI.GridLayoutGroup", Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.GridLayoutGroup", Member = "CalculateLayoutInputVertical", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.GridLayoutGroup", Member = "SetCellsAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.HorizontalOrVerticalLayoutGroup", Member = "CalcAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.HorizontalOrVerticalLayoutGroup", Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "GetStartOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "CalcWidth", ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 81
	}

	[NativeProperty("left", False, TargetType::Field (1))]
	public int left
	{
		[CallerCount(Count = 37)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 81
		[CalledBy(Type = "Scenes.General.HandCards", Member = "AdjustLayoutSize", ReturnType = typeof(void))]
		[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectGridController", Member = "UpdateSizing", ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>", typeof(RectOffset), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetRelativeEndValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.NoOptions", "DG.Tweening.Tween", typeof(bool), "DG.Tweening.Core.DOGetter`1<RectOffset>", "DG.Tweening.Core.DOSetter`1<RectOffset>", typeof(float), typeof(RectOffset), typeof(RectOffset), typeof(float), typeof(bool), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 88
	}

	[NativeProperty("right", False, TargetType::Field (1))]
	public int right
	{
		[CalledBy(Type = "UI.Tables.TableLayout", Member = "UpdateLayout", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "SetHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "CalcWidth", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "ApplyStyleSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUIStyle"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.GUILayoutEntry", Member = "get_marginRight", ReturnType = typeof(int))]
		[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.NoOptions", "DG.Tweening.Tween", typeof(bool), "DG.Tweening.Core.DOGetter`1<RectOffset>", "DG.Tweening.Core.DOSetter`1<RectOffset>", typeof(float), typeof(RectOffset), typeof(RectOffset), typeof(float), typeof(bool), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "GetSpeedBasedDuration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.NoOptions", typeof(float), typeof(RectOffset)}, ReturnType = typeof(float))]
		[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetRelativeEndValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetChangeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>", typeof(RectOffset), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.General", Member = "GetDynamicConstraintCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.GridLayoutGroup"}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectBase", Member = "AdjustContentSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker_ContentLayout", Member = "SetBorderSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker_ContentLayout", Member = "SetBorderSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectOffset)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "ConvertToStartValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>", typeof(RectOffset)}, ReturnType = typeof(RectOffset))]
		[CallerCount(Count = 31)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 81
		[CalledBy(Type = "Scenes.General.HandCards", Member = "AdjustLayoutSize", ReturnType = typeof(void))]
		[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectGridController", Member = "UpdateSizing", ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>", typeof(RectOffset), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetRelativeEndValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.NoOptions", "DG.Tweening.Tween", typeof(bool), "DG.Tweening.Core.DOGetter`1<RectOffset>", "DG.Tweening.Core.DOSetter`1<RectOffset>", typeof(float), typeof(RectOffset), typeof(RectOffset), typeof(float), typeof(bool), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 88
	}

	[NativeProperty("top", False, TargetType::Field (1))]
	public int top
	{
		[CallerCount(Count = 36)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 81
		[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "CalculateMainDeckOverlap", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectGridController", Member = "UpdateSizing", ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>", typeof(RectOffset), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetRelativeEndValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.NoOptions", "DG.Tweening.Tween", typeof(bool), "DG.Tweening.Core.DOGetter`1<RectOffset>", "DG.Tweening.Core.DOSetter`1<RectOffset>", typeof(float), typeof(RectOffset), typeof(RectOffset), typeof(float), typeof(bool), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 88
	}

	public int vertical
	{
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "get_preferredHeight", ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.UI.GridLayoutGroup", Member = "CalculateLayoutInputVertical", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.GridLayoutGroup", Member = "SetCellsAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.HorizontalOrVerticalLayoutGroup", Member = "CalcAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.HorizontalOrVerticalLayoutGroup", Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "GetStartOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "CalcHeight", ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 81
	}

	[CalledBy(Type = "UI.Tables.TableLayout", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public RectOffset() { }

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule"})]
	internal RectOffset(object sourceStyle, IntPtr source) { }

	[CalledBy(Type = "UI.Tables.TableLayout", Member = "UpdateLayout", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePickerHeaderConfig", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_Header"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_ContentLayout", Member = "SetBorderSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "ConvertToStartValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>", typeof(RectOffset)}, ReturnType = typeof(RectOffset))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetChangeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.NoOptions", "DG.Tweening.Tween", typeof(bool), "DG.Tweening.Core.DOGetter`1<RectOffset>", "DG.Tweening.Core.DOSetter`1<RectOffset>", typeof(float), typeof(RectOffset), typeof(RectOffset), typeof(float), typeof(bool), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public RectOffset(int left, int right, int top, int bottom) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void Destroy() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void Finalize() { }

	[CalledBy(Type = "UI.Tables.TableLayout", Member = "UpdateLayout", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "ConvertToStartValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>", typeof(RectOffset)}, ReturnType = typeof(RectOffset))]
	[CalledBy(Type = "UI.Dates.DatePicker_ContentLayout", Member = "SetBorderSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectOffset)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_ContentLayout", Member = "SetBorderSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectBase", Member = "AdjustContentSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.General", Member = "GetDynamicConstraintCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.GridLayoutGroup"}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetChangeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>", typeof(RectOffset), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "GetSpeedBasedDuration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.NoOptions", typeof(float), typeof(RectOffset)}, ReturnType = typeof(float))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.NoOptions", "DG.Tweening.Tween", typeof(bool), "DG.Tweening.Core.DOGetter`1<RectOffset>", "DG.Tweening.Core.DOSetter`1<RectOffset>", typeof(float), typeof(RectOffset), typeof(RectOffset), typeof(float), typeof(bool), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.GUILayoutEntry", Member = "get_marginBottom", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "ApplyStyleSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUIStyle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "CalcHeight", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "SetVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetRelativeEndValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 30)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int get_bottom() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_bottom_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "TMPro.TMP_InputField", Member = "get_preferredWidth", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UI.GridLayoutGroup", Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.GridLayoutGroup", Member = "CalculateLayoutInputVertical", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.GridLayoutGroup", Member = "SetCellsAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.HorizontalOrVerticalLayoutGroup", Member = "CalcAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.HorizontalOrVerticalLayoutGroup", Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "GetStartOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "CalcWidth", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int get_horizontal() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_horizontal_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 37)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int get_left() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_left_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UI.Tables.TableLayout", Member = "UpdateLayout", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "ConvertToStartValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>", typeof(RectOffset)}, ReturnType = typeof(RectOffset))]
	[CalledBy(Type = "UI.Dates.DatePicker_ContentLayout", Member = "SetBorderSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectOffset)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_ContentLayout", Member = "SetBorderSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectBase", Member = "AdjustContentSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.General", Member = "GetDynamicConstraintCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.GridLayoutGroup"}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetChangeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>", typeof(RectOffset), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "GetSpeedBasedDuration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.NoOptions", typeof(float), typeof(RectOffset)}, ReturnType = typeof(float))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.NoOptions", "DG.Tweening.Tween", typeof(bool), "DG.Tweening.Core.DOGetter`1<RectOffset>", "DG.Tweening.Core.DOSetter`1<RectOffset>", typeof(float), typeof(RectOffset), typeof(RectOffset), typeof(float), typeof(bool), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.GUILayoutEntry", Member = "get_marginRight", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "ApplyStyleSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUIStyle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "CalcWidth", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "SetHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetRelativeEndValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 31)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int get_right() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_right_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 36)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int get_top() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_top_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "TMPro.TMP_InputField", Member = "get_preferredHeight", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UI.GridLayoutGroup", Member = "CalculateLayoutInputVertical", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.GridLayoutGroup", Member = "SetCellsAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.HorizontalOrVerticalLayoutGroup", Member = "CalcAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.HorizontalOrVerticalLayoutGroup", Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "GetStartOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "CalcHeight", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int get_vertical() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_vertical_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadAndSerializationSafe]
	private static IntPtr InternalCreate() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadAndSerializationSafe]
	private static void InternalDestroy(IntPtr ptr) { }

	[CalledBy(Type = "UnityEngine.GUIStyle", Member = "GetCursorPixelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), "UnityEngine.GUIContent", typeof(int)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.GUIStyle", Member = "GetPreferredSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Rect)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.GUIStyle", Member = "GetDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect), typeof(Vector2&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextEditor", Member = "UpdateTextHandle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextEditor", Member = "UpdateScrollOffset", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Rect Remove(Rect rect) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Remove_Injected(IntPtr _unity_self, in Rect rect, out Rect ret) { }

	[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectGridController", Member = "UpdateSizing", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>", typeof(RectOffset), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetRelativeEndValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.NoOptions", "DG.Tweening.Tween", typeof(bool), "DG.Tweening.Core.DOGetter`1<RectOffset>", "DG.Tweening.Core.DOSetter`1<RectOffset>", typeof(float), typeof(RectOffset), typeof(RectOffset), typeof(float), typeof(bool), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_bottom(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_bottom_Injected(IntPtr _unity_self, int value) { }

	[CalledBy(Type = "Scenes.General.HandCards", Member = "AdjustLayoutSize", ReturnType = typeof(void))]
	[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectGridController", Member = "UpdateSizing", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>", typeof(RectOffset), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetRelativeEndValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.NoOptions", "DG.Tweening.Tween", typeof(bool), "DG.Tweening.Core.DOGetter`1<RectOffset>", "DG.Tweening.Core.DOSetter`1<RectOffset>", typeof(float), typeof(RectOffset), typeof(RectOffset), typeof(float), typeof(bool), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_left(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_left_Injected(IntPtr _unity_self, int value) { }

	[CalledBy(Type = "Scenes.General.HandCards", Member = "AdjustLayoutSize", ReturnType = typeof(void))]
	[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectGridController", Member = "UpdateSizing", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>", typeof(RectOffset), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetRelativeEndValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.NoOptions", "DG.Tweening.Tween", typeof(bool), "DG.Tweening.Core.DOGetter`1<RectOffset>", "DG.Tweening.Core.DOSetter`1<RectOffset>", typeof(float), typeof(RectOffset), typeof(RectOffset), typeof(float), typeof(bool), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_right(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_right_Injected(IntPtr _unity_self, int value) { }

	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "CalculateMainDeckOverlap", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectGridController", Member = "UpdateSizing", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>", typeof(RectOffset), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "SetRelativeEndValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<RectOffset, RectOffset, NoOptions>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.RectOffsetPlugin", Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.NoOptions", "DG.Tweening.Tween", typeof(bool), "DG.Tweening.Core.DOGetter`1<RectOffset>", "DG.Tweening.Core.DOSetter`1<RectOffset>", typeof(float), typeof(RectOffset), typeof(RectOffset), typeof(float), typeof(bool), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_top(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_top_Injected(IntPtr _unity_self, int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 26)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

}

