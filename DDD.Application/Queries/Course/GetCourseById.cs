﻿using DDD.Application.Dtos;
using DDD.Shared.Abstraction.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application.Queries.Course
{
    public class GetCourseById : IQuery<CourseDto>
    {
        public Guid CourseId { get; set; }
    }
}
