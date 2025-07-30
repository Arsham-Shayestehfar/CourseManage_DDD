﻿using DDD.Shared.Abstraction.Exceptions;

namespace DDD.Domain.Exception.CourseManagementException;

internal class FullNameNullOrEmptyException : Sahred.Absraction.Exceptions.CourseManagementException
{
    public FullNameNullOrEmptyException() : base("Full Name Can Not Be Empty...!")
    {
    }
}
