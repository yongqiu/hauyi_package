using UnrealBuildTool;

public class huayi2Target : TargetRules
{
	public huayi2Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("huayi2");
	}
}
