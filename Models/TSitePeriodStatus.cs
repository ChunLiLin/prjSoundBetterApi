﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjSoundBetterApi.Models;

public partial class TSitePeriodStatus
{
    public int FSitePeriodStatusId { get; set; }

    public string FDescription { get; set; }

    public virtual ICollection<TSitePeriod> TSitePeriodFFriAfternoonNavigations { get; set; } = new List<TSitePeriod>();

    public virtual ICollection<TSitePeriod> TSitePeriodFFriMidnightNavigations { get; set; } = new List<TSitePeriod>();

    public virtual ICollection<TSitePeriod> TSitePeriodFFriMorningNavigations { get; set; } = new List<TSitePeriod>();

    public virtual ICollection<TSitePeriod> TSitePeriodFFriNightNavigations { get; set; } = new List<TSitePeriod>();

    public virtual ICollection<TSitePeriod> TSitePeriodFMonAfternoonNavigations { get; set; } = new List<TSitePeriod>();

    public virtual ICollection<TSitePeriod> TSitePeriodFMonMidnightNavigations { get; set; } = new List<TSitePeriod>();

    public virtual ICollection<TSitePeriod> TSitePeriodFMonMorningNavigations { get; set; } = new List<TSitePeriod>();

    public virtual ICollection<TSitePeriod> TSitePeriodFMonNightNavigations { get; set; } = new List<TSitePeriod>();

    public virtual ICollection<TSitePeriod> TSitePeriodFSatAfternoonNavigations { get; set; } = new List<TSitePeriod>();

    public virtual ICollection<TSitePeriod> TSitePeriodFSatMidnightNavigations { get; set; } = new List<TSitePeriod>();

    public virtual ICollection<TSitePeriod> TSitePeriodFSatMorningNavigations { get; set; } = new List<TSitePeriod>();

    public virtual ICollection<TSitePeriod> TSitePeriodFSatNightNavigations { get; set; } = new List<TSitePeriod>();

    public virtual ICollection<TSitePeriod> TSitePeriodFSunAfternoonNavigations { get; set; } = new List<TSitePeriod>();

    public virtual ICollection<TSitePeriod> TSitePeriodFSunMidnightNavigations { get; set; } = new List<TSitePeriod>();

    public virtual ICollection<TSitePeriod> TSitePeriodFSunMorningNavigations { get; set; } = new List<TSitePeriod>();

    public virtual ICollection<TSitePeriod> TSitePeriodFSunNightNavigations { get; set; } = new List<TSitePeriod>();

    public virtual ICollection<TSitePeriod> TSitePeriodFThurAfternoonNavigations { get; set; } = new List<TSitePeriod>();

    public virtual ICollection<TSitePeriod> TSitePeriodFThurMidnightNavigations { get; set; } = new List<TSitePeriod>();

    public virtual ICollection<TSitePeriod> TSitePeriodFThurMorningNavigations { get; set; } = new List<TSitePeriod>();

    public virtual ICollection<TSitePeriod> TSitePeriodFThurNightNavigations { get; set; } = new List<TSitePeriod>();

    public virtual ICollection<TSitePeriod> TSitePeriodFTuesAfternoonNavigations { get; set; } = new List<TSitePeriod>();

    public virtual ICollection<TSitePeriod> TSitePeriodFTuesMidnightNavigations { get; set; } = new List<TSitePeriod>();

    public virtual ICollection<TSitePeriod> TSitePeriodFTuesMorningNavigations { get; set; } = new List<TSitePeriod>();

    public virtual ICollection<TSitePeriod> TSitePeriodFTuesNightNavigations { get; set; } = new List<TSitePeriod>();

    public virtual ICollection<TSitePeriod> TSitePeriodFWedAfternoonNavigations { get; set; } = new List<TSitePeriod>();

    public virtual ICollection<TSitePeriod> TSitePeriodFWedMidnightNavigations { get; set; } = new List<TSitePeriod>();

    public virtual ICollection<TSitePeriod> TSitePeriodFWedMorningNavigations { get; set; } = new List<TSitePeriod>();

    public virtual ICollection<TSitePeriod> TSitePeriodFWedNightNavigations { get; set; } = new List<TSitePeriod>();
}