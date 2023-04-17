﻿using Postgrest.Models;
using Postgrest.Attributes;

using System;
namespace Supabase_Dotnet.Models;

[Table("newsletter")]

public class Newsletter : BaseModel
{
	[PrimaryKey("id", false)]

	public long Id { get; set; }

	[Column("name")]
	public string Name { get; set; }

	[Column("description")]
    public string Description { get; set; }

	[Column("read_time")]
    public string ReadTime { get; set; }

	[Column("created_at")]
	public DateTime CreateedAt { get; set; }
}


