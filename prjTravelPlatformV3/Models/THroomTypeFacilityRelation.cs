﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjTravelPlatformV3.Models;

public partial class THroomTypeFacilityRelation
{
    public int FSid { get; set; }

    public int FRoomTypeId { get; set; }

    public int FRoomTypeFacilityId { get; set; }

    public virtual THroomType FRoomType { get; set; }

    public virtual THroomFacility FRoomTypeFacility { get; set; }
}