﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjSoundBetterApi.Models;

public partial class TArticleFav
{
    public int FArticleFavId { get; set; }

    public int? FArticleId { get; set; }

    public int? FMemberId { get; set; }

    public virtual TArticle FArticle { get; set; }

    public virtual TMember FMember { get; set; }
}