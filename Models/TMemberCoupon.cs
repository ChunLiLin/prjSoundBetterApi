﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjSoundBetterApi.Models;

public partial class TMemberCoupon
{
    public int FMemberCouponId { get; set; }

    public int FCouponId { get; set; }

    public int FMemberId { get; set; }

    public virtual TCoupon FCoupon { get; set; }

    public virtual TMember FMember { get; set; }
}