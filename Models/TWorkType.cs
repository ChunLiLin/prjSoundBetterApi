﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjSoundBetterApi.Models;

public partial class TWorkType
{
    public int FWorkTypeId { get; set; }

    public string FWorkType { get; set; }

    public virtual ICollection<TWork> TWorks { get; set; } = new List<TWork>();
}