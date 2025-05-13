using Content.Server.Sound.Components;
using Content.Shared.Interaction.Events;
using Robust.Shared.Audio.Systems;

namespace Content.Server.Sound;

public sealed class FunnySoundSystem : EntitySystem
{
    [Dependency] private readonly SharedAudioSystem _audio = default!;

    public override void Initialize()
    {
        SubscribeLocalEvent<PlayFunnySoundComponent, UseInHandEvent>(UseThisItem);
    }

    private void UseThisItem(Entity<PlayFunnySoundComponent> ent, ref UseInHandEvent args)
    {
        _audio.PlayPvs(ent.Comp.Noise, ent.Owner);
    }

}
