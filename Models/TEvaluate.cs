﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjSoundBetterApi.Models;

public partial class TEvaluate
{
    public int FEvaluateId { get; set; }

    public int FWorkId { get; set; }

    public int FMemberId { get; set; }

    public int FEvaluateStatusId { get; set; }

    public string FContent { get; set; }

    public DateTime? FEvaluateTime { get; set; }

    public virtual TEvaluateStatus FEvaluateStatus { get; set; }

    public virtual TMember FMember { get; set; }

    public virtual TWork FWork { get; set; }
}