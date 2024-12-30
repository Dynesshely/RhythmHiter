using RhythmHiter.Utils;
using SharpHook.Native;

namespace RhythmHiter.Trainers._4K;

public class RandomInputTrainer : Singleton<RandomInputTrainer>, ITrainer
{
    public string Name { get; set; } = nameof(RandomInputTrainer);

    public async Task<ITrainer> Run()
    {
        while (true)
        {
            await Task.Delay(200);
            InputSimulator.SimulateKeyPress((ushort)KeyCode.VcD);
        }

        return this;
    }
}
