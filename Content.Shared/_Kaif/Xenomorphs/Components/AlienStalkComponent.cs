﻿using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Shared.Aliens.Components;

/// <summary>
/// This is used for...
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class AlienStalkComponent : Component
{

    [DataField]
    public EntProtoId? StalkAction = "ActionStalkAlien";

    [DataField]
    public EntityUid? StalkActionEntity;

    [DataField]
    public int PlasmaCost = 5;

    public bool IsActive;

    public float Sprint;
}
