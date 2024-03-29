﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjTravelPlatformV3.Models;

public partial class THroomType
{
    public int FRoomTypeId { get; set; }

    public int? FHotelId { get; set; }

    public string FRoomTypeName { get; set; }

    public string FBedType { get; set; }

    public int? FBedNum { get; set; }

    public int? FMaxCapacity { get; set; }

    public decimal FPrice { get; set; }

    public virtual THotel FHotel { get; set; }

    public virtual ICollection<THorder> THorders { get; set; } = new List<THorder>();

    public virtual ICollection<THroomTypeFacilityRelation> THroomTypeFacilityRelations { get; set; } = new List<THroomTypeFacilityRelation>();

    public virtual ICollection<THroomTypeImage> THroomTypeImages { get; set; } = new List<THroomTypeImage>();

    public virtual ICollection<THroom> THrooms { get; set; } = new List<THroom>();
}