﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjSoundBetterApi.Models;

public partial class TClassFav
{
    public int FClassFav { get; set; }

    public int? FClassId { get; set; }

    public int? FMemberId { get; set; }

    public virtual TClass FClass { get; set; }

    public virtual TMember FMember { get; set; }
}