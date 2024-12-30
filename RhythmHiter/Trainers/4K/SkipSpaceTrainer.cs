using RhythmHiter.Utils;
using SharpHook;
using SharpHook.Native;

namespace RhythmHiter.Trainers._4K;

public class SkipSpaceTrainer : Singleton<SkipSpaceTrainer>, ITrainer
{
    public string Name { get; set; } = nameof(SkipSpaceTrainer);

    public async Task<ITrainer> Run()
    {
        var hook = new TaskPoolGlobalHook();

        hook.KeyPressed += (_, e) =>
        {
            List<KeyCode> targetKeys = [KeyCode.VcD, KeyCode.VcF, KeyCode.VcJ, KeyCode.VcK];

            if (targetKeys.Contains(e.RawEvent.Keyboard.KeyCode))
            {
                InputSimulator.SimulateKeyPress(0x20);
            }
        };

        await hook.RunAsync();

        return this;
    }
}
