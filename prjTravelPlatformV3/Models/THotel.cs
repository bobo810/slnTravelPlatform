﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjTravelPlatformV3.Models;

public partial class THotel
{
    public int FHotelId { get; set; }

    public string FHotelName { get; set; }

    public string FHotelEngName { get; set; }

    public string FHotelAddress { get; set; }

    public string FPhone { get; set; }

    public string FRegion { get; set; }

    public string FViewsNum { get; set; }

    public string FTexId { get; set; }

    public virtual ICollection<THfacilityRelation> THfacilityRelations { get; set; } = new List<THfacilityRelation>();

    public virtual ICollection<THimage> THimages { get; set; } = new List<THimage>();

    public virtual ICollection<THorder> THorders { get; set; } = new List<THorder>();

    public virtual ICollection<THroomType> THroomTypes { get; set; } = new List<THroomType>();

    public virtual ICollection<THroom> THrooms { get; set; } = new List<THroom>();
}