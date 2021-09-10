// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ProjectNoobTarget : TargetRules
{
	public ProjectNoobTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("ProjectNoob");
	}
}
