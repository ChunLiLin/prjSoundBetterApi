﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjSoundBetterApi.Models;

public partial class TWork
{
    public int FWorkId { get; set; }

    public int? FMemberId { get; set; }

    public int? FWorkTypeId { get; set; }

    public string FWorkName { get; set; }

    public int? FStyleId { get; set; }

    public DateTime? FUpdateTime { get; set; }

    public string FDescription { get; set; }

    public string FThumbnail { get; set; }

    public string FFilePath { get; set; }

    public virtual TMember FMember { get; set; }

    public virtual TStyle FStyle { get; set; }

    public virtual TWorkType FWorkType { get; set; }

    public virtual ICollection<TEvaluate> TEvaluates { get; set; } = new List<TEvaluate>();
}