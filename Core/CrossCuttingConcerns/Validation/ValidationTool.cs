﻿using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;


namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator , object entity)
        {

            var context = new ValidationContext<Object>(entity);
           var result = validator.Validate(context);
            if (!result.IsValid)
            {
                throw new FluentValidation.ValidationException(result.Errors);
            }
        }
    }
}
