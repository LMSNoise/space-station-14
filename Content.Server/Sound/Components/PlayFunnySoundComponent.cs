using Robust.Shared.Audio;

namespace Content.Server.Sound.Components;

[RegisterComponent]
public sealed partial class PlayFunnySoundComponent : Component
{
    [DataField(required: true)]
    public SoundSpecifier? Noise;

}
