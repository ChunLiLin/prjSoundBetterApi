﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjSoundBetterApi.Models;

public partial class TSitePeriod
{
    public int FSitePeriodId { get; set; }

    public int FSiteId { get; set; }

    public int? FMonMorning { get; set; }

    public int? FMonAfternoon { get; set; }

    public int? FMonNight { get; set; }

    public int? FMonMidnight { get; set; }

    public int? FTuesMorning { get; set; }

    public int? FTuesAfternoon { get; set; }

    public int? FTuesNight { get; set; }

    public int? FTuesMidnight { get; set; }

    public int? FWedMorning { get; set; }

    public int? FWedAfternoon { get; set; }

    public int? FWedNight { get; set; }

    public int? FWedMidnight { get; set; }

    public int? FThurMorning { get; set; }

    public int? FThurAfternoon { get; set; }

    public int? FThurNight { get; set; }

    public int? FThurMidnight { get; set; }

    public int? FFriMorning { get; set; }

    public int? FFriAfternoon { get; set; }

    public int? FFriNight { get; set; }

    public int? FFriMidnight { get; set; }

    public int? FSatMorning { get; set; }

    public int? FSatAfternoon { get; set; }

    public int? FSatNight { get; set; }

    public int? FSatMidnight { get; set; }

    public int? FSunMorning { get; set; }

    public int? FSunAfternoon { get; set; }

    public int? FSunNight { get; set; }

    public int? FSunMidnight { get; set; }

    public virtual TSitePeriodStatus FFriAfternoonNavigation { get; set; }

    public virtual TSitePeriodStatus FFriMidnightNavigation { get; set; }

    public virtual TSitePeriodStatus FFriMorningNavigation { get; set; }

    public virtual TSitePeriodStatus FFriNightNavigation { get; set; }

    public virtual TSitePeriodStatus FMonAfternoonNavigation { get; set; }

    public virtual TSitePeriodStatus FMonMidnightNavigation { get; set; }

    public virtual TSitePeriodStatus FMonMorningNavigation { get; set; }

    public virtual TSitePeriodStatus FMonNightNavigation { get; set; }

    public virtual TSitePeriodStatus FSatAfternoonNavigation { get; set; }

    public virtual TSitePeriodStatus FSatMidnightNavigation { get; set; }

    public virtual TSitePeriodStatus FSatMorningNavigation { get; set; }

    public virtual TSitePeriodStatus FSatNightNavigation { get; set; }

    public virtual TSite FSite { get; set; }

    public virtual TSitePeriodStatus FSunAfternoonNavigation { get; set; }

    public virtual TSitePeriodStatus FSunMidnightNavigation { get; set; }

    public virtual TSitePeriodStatus FSunMorningNavigation { get; set; }

    public virtual TSitePeriodStatus FSunNightNavigation { get; set; }

    public virtual TSitePeriodStatus FThurAfternoonNavigation { get; set; }

    public virtual TSitePeriodStatus FThurMidnightNavigation { get; set; }

    public virtual TSitePeriodStatus FThurMorningNavigation { get; set; }

    public virtual TSitePeriodStatus FThurNightNavigation { get; set; }

    public virtual TSitePeriodStatus FTuesAfternoonNavigation { get; set; }

    public virtual TSitePeriodStatus FTuesMidnightNavigation { get; set; }

    public virtual TSitePeriodStatus FTuesMorningNavigation { get; set; }

    public virtual TSitePeriodStatus FTuesNightNavigation { get; set; }

    public virtual TSitePeriodStatus FWedAfternoonNavigation { get; set; }

    public virtual TSitePeriodStatus FWedMidnightNavigation { get; set; }

    public virtual TSitePeriodStatus FWedMorningNavigation { get; set; }

    public virtual TSitePeriodStatus FWedNightNavigation { get; set; }
}