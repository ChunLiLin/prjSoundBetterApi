﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjSoundBetterApi.Models;

public partial class TNotification
{
    public int FNotificationId { get; set; }

    public int? FMemberId { get; set; }

    public string FNotification { get; set; }

    public virtual TMember FMember { get; set; }
}