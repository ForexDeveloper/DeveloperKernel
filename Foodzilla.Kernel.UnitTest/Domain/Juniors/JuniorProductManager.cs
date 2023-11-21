﻿using Foodzilla.Kernel.Patch;
using Foodzilla.Kernel.UnitTest.Domain.Freshers;
using Foodzilla.Kernel.UnitTest.Domain.MidLevels;

namespace Foodzilla.Kernel.UnitTest.Domain.Juniors;

public sealed class JuniorProductManager : Identity<long>, IPatchValidator
{
    public long MidlevelProductManagerId { get; private set; }

    public MidlevelProductManager MidlevelProductManager { get; private set; }

    public IList<FresherProductManager> Freshers => new List<FresherProductManager>();

    private JuniorProductManager(string name, string lastName, string nationalCode, string personalCode, string address, int age, int? daysOfVacation, decimal? height, decimal? weight, bool isFired, Guid uniqueIdentifier, EyeColor? eyeColor, Graduation graduation, Experience experience, DateTimeOffset? modifiedDate, DateTimeOffset birthDate, DateTimeOffset contraDateEnd, DateTimeOffset contraDateStart, long midlevelProductManagerId)
        : base(name, lastName, nationalCode, personalCode, address, age, daysOfVacation, height, weight, isFired, uniqueIdentifier, eyeColor, graduation, experience, modifiedDate, birthDate, contraDateEnd, contraDateStart)
    {
        MidlevelProductManagerId = midlevelProductManagerId;
    }

    public static JuniorProductManager Create(string name, string lastName, string nationalCode, string personalCode, string address, int age, int? daysOfVacation, decimal? height, decimal? weight, bool isFired, Guid uniqueIdentifier, EyeColor? eyeColor, Graduation graduation, Experience experience, DateTimeOffset? modifiedDate, DateTimeOffset birthDate, DateTimeOffset contraDateEnd, DateTimeOffset contraDateStart, long midlevelProductManagerId)
    {
        return new JuniorProductManager(name, lastName, nationalCode, personalCode, address, age, daysOfVacation, height, weight, isFired, uniqueIdentifier, eyeColor, graduation, experience, modifiedDate, birthDate, contraDateEnd, contraDateStart, midlevelProductManagerId);
    }

    public void AddFresherProductManager(FresherProductManager fresher)
    {
        Freshers.Add(fresher);
    }

    public bool OnPatchCompleted()
    {
        return true;
    }
}