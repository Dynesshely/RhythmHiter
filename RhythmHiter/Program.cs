using RhythmHiter.Trainers;
using RhythmHiter.Trainers._4K;
using Spectre.Console;

var trainers = new List<ITrainer>() { SkipSpaceTrainer.Instance, RandomInputTrainer.Instance };

var trainer = AnsiConsole.Prompt(
    new SelectionPrompt<ITrainer>() { Converter = x => x.Name }
        .Title("Which trainer you want to run?")
        .PageSize(10)
        .MoreChoicesText("[grey](Move up and down to reveal more trainers)[/]")
        .AddChoices(trainers)
);

AnsiConsole.WriteLine($"Launching trainer: {trainer.Name}");

await trainer.Run();
