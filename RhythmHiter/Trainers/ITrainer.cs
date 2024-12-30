namespace RhythmHiter.Trainers;

public interface ITrainer
{
    public string Name { get; set; }

    public Task<ITrainer> Run();
}
