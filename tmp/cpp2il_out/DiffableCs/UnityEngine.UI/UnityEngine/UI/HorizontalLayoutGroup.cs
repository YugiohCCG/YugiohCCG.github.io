namespace UnityEngine.UI;

[AddComponentMenu("Layout/Horizontal Layout Group", 150)]
public class HorizontalLayoutGroup : HorizontalOrVerticalLayoutGroup
{

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected HorizontalLayoutGroup() { }

	[CalledBy(Type = "UI.Tables.TableCell", Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LayoutGroup), Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
	[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "CalcAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	public virtual void CalculateLayoutInputHorizontal() { }

	[CalledBy(Type = "UI.Tables.TableCell", Member = "CalculateLayoutInputVertical", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "CalcAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	public virtual void CalculateLayoutInputVertical() { }

	[CalledBy(Type = "UI.Tables.TableCell", Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	public virtual void SetLayoutHorizontal() { }

	[CalledBy(Type = "UI.Tables.TableCell", Member = "SetLayoutVertical", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	public virtual void SetLayoutVertical() { }

}

