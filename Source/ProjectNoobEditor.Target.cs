// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ProjectNoobEditorTarget : TargetRules
{
	public ProjectNoobEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("ProjectNoob");
	}
}
