﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjSoundBetterApi.Models;

public partial class TMemberRelation
{
    public int FMemberRelationId { get; set; }

    public int FMemberId { get; set; }

    public int FRelationMemberId { get; set; }

    public int FMemberRelationStatusId { get; set; }

    public virtual TMember FMember { get; set; }

    public virtual TMemberRelationStatus FMemberRelationStatus { get; set; }
}