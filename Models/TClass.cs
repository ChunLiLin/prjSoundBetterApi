﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjSoundBetterApi.Models;

public partial class TClass
{
    public int FClassId { get; set; }

    public int? FTeacherId { get; set; }

    public string FClassName { get; set; }

    public decimal? FPrice { get; set; }

    public string FDescription { get; set; }

    public DateTime? FStartdate { get; set; }

    public DateTime? FEnddate { get; set; }

    public int? FSiteId { get; set; }

    public string FThumbnailPath { get; set; }

    public virtual TSite FSite { get; set; }

    public virtual TMember FTeacher { get; set; }

    public virtual ICollection<TDealClass> TDealClasses { get; set; } = new List<TDealClass>();
}